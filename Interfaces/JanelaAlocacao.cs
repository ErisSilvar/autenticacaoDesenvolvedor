using autenticacaoCadastro.Repositories;
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
    public partial class JanelaAlocacao : Form
    {
        private static JanelaAlocacao instance;

        private JanelaAlocacao()
        {
            InitializeComponent();
        }
        public static JanelaAlocacao GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaAlocacao();
            }
            instance.MdiParent = Form1.ActiveForm;
            return instance;
        }
        private void btnSalvarAlocacao_Click(object sender, EventArgs e)
        {
            Alocacao alocacao = new Alocacao();
            alocacao.Inicio = dtpInicioAlocacao.Value;
            alocacao.Termino = dtpTerminoAlocacao.Value;
            alocacao.HorasAtuacaoSemanal = Convert.ToByte(nupHoras.Value);
            alocacao.Remuneracao = Convert.ToDecimal(txtRemuneracaoAlocacao.Text);
            alocacao.Desenvolvedor = (Desenvolvedor)lstBoxDesenvolvedor.SelectedItem;
            alocacao.Projeto = (Projeto)lstBoxProjeto.SelectedItem;

            AlocacaoRepository.Save(alocacao);

            dtpInicioAlocacao.Value = DateTime.Now;
            dtpTerminoAlocacao.Value = DateTime.Now;
            nupHoras.Value = 1;
            txtRemuneracaoAlocacao.Text = "";
            txtDesenvolvedorAlocacao.Text = "";
            txtProjetoAlocacao.Text = "";
            lstBoxDesenvolvedor.DataSource = null;
            lstBoxProjeto.DataSource = null;
            dtpInicioAlocacao.Focus();
            txtDesenvolvedorAlocacao.Text = "";
            txtProjetoAlocacao.Text = "";
        }
        private void txtDesenvolvedorAlocacao_TextChanged(object sender, EventArgs e)
        {
            if (txtDesenvolvedorAlocacao.Text != null)
            {
                lstBoxDesenvolvedor.DataSource = DesenvolvedorRepository.BuscarDev(txtDesenvolvedorAlocacao.Text);
            }
            else
            {
                lstBoxDesenvolvedor.DataSource = null;
            }
        }
        private void txtProjetoAlocacao_TextChanged(object sender, EventArgs e)
        {
            if( txtProjetoAlocacao.Text != null)
            {
                lstBoxProjeto.DataSource = ProjetoRepository.BuscarProj(txtProjetoAlocacao.Text);
            }
            else
            {
                lstBoxProjeto.DataSource = null;
            }
        }
        private void lstBoxDesenvolvedor_DoubleClick(object sender, EventArgs e)
        {
            Desenvolvedor desenvolvedor = (Desenvolvedor)lstBoxDesenvolvedor.SelectedItem;
            lblInfoDev.Text = "Nome do Dev: " + desenvolvedor.Nome;
        }
        private void lstBoxProjeto_DoubleClick(object sender, EventArgs e)
        {
           Projeto projeto = (Projeto)lstBoxProjeto.SelectedItem;
            lblinfoProj.Text = "Nome do Projeto: " + projeto.Nome;
        }
    }
}
