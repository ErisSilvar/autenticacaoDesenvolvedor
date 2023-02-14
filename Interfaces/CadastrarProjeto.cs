using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autenticacaoCadastro
{
    public partial class CadastrarProjeto : Form
    {
        private static CadastrarProjeto instance;
        private CadastrarProjeto()
        {
            InitializeComponent();
        }
        public static CadastrarProjeto GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CadastrarProjeto();
            }
            instance.MdiParent = Form1.ActiveForm;
            return instance;
        }

        private void btnSalvarProjeto_Click(object sender, EventArgs e)
        {
            ProjetoRepository.CadastrarProjeto(txbNomeProjeto.Text,dtpInicioProjetos.Value,dtpPrevistoProjetos.Value,dtpTerminoProjetos.Value);

            txbNomeProjeto.Focus();
            txbNomeProjeto.Text = "";
            dtpInicioProjetos.Value = DateTime.Now;
            dtpPrevistoProjetos.Value = DateTime.Now;
            dtpPrevistoProjetos.Value= DateTime.Now;          
        }
        private void txbNomeProjeto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpInicioProjetos.Focus();
            }        
        }
    }
}
