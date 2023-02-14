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
    public partial class CadastrarDesenvolvedor : Form
    {
        private static CadastrarDesenvolvedor instance;
        private CadastrarDesenvolvedor()
        {
            InitializeComponent();
        }

        public static CadastrarDesenvolvedor GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CadastrarDesenvolvedor();
            }
            instance.MdiParent = Form1.ActiveForm;
            return instance;
        }

        private void txbNomeDevs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpNascimentoDevs.Focus();
            }          
        }
        private void txbSenhaCredencial_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvarCredencial.Focus();
            }         
        }
        private void txbEmailCredencial_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSenhaCredencial.Focus();
            }
        }

        private void btnSalvarCredencial_Click(object sender, EventArgs e)
        {     
            {
                DesenvolvedorRepository.CadastrarDev(dtpNascimentoDevs.Value, txbNomeDevs.Text, ckbAdmin.Checked, ckbAtivo.Checked,

                Convert.ToChar(cmbNivel.Text), txbSenhaCredencial.Text, txbEmailCredencial.Text);
                txbNomeDevs.Focus();

                txbNomeDevs.Text = "'";
                txbEmailCredencial.Text = "";
                txbSenhaCredencial.Text = "";
                dtpNascimentoDevs.Value = DateTime.Now;
                cmbNivel.SelectedItem = null;   
            }            
        }
    }
}
