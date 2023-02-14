using autenticacaoCadastro.Classes_em_geral;
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

namespace autenticacaoCadastro.Interfaces
{
    public partial class JanelaTarefa : Form
    {      
        private static JanelaTarefa instance;
        private JanelaTarefa()
        {
            InitializeComponent();
        }

        public static JanelaTarefa GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaTarefa();
            }
            instance.MdiParent = Form1.ActiveForm;
            return instance;
        }

       private void lstBoxAlocacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxAlocacoes.SelectedItem != null)
            {
                lblInfoTarefas.Text = lstBoxAlocacoes.SelectedItem.ToString();
            }
        }

        private void btnSalvarTarefa_Click(object sender, EventArgs e)
        {
          if(txtAlocacaoTarefa.Text.Length != 0)
          {
                Alocacao alocacao = (Alocacao)lstBoxAlocacoes.SelectedItem;
                Classes_em_geral.Tarefa tarefa = new Classes_em_geral.Tarefa(txtDescricaoTarefa.Text);
                AlocacaoRepository.AdicionarTarefas(alocacao, tarefa);
               
                txtAlocacaoTarefa.Focus();

                txtDescricaoTarefa.Text = "";
                lstBoxAlocacoes.DataSource = null;
          }
            else
            {
                MessageBox.Show("Erro ao adicionar nova tarefa");
            }
        }

        private void txtAlocacaoTarefa_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtAlocacaoTarefa.Text.Length != 0)
                {
                    lstBoxAlocacoes.DataSource = AlocacaoRepository.BuscarAlocacao(txtAlocacaoTarefa.Text);
                }
                else
                {
                    lstBoxAlocacoes.DataSource = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
