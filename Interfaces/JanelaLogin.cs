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
    public partial class JanelaLogin : Form
    {
        private static JanelaLogin instance;

        private JanelaLogin()
        {
            InitializeComponent();
            
        }
        public static JanelaLogin GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaLogin();
            }
            return instance;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Repository repository = new Repository();
        }
        private void btnAutenticar_Click_1(object sender, EventArgs e)
        {           
            if (txtEmail.Text != null)
            {
                if (CredencialRepository.Autenticar(txtEmail.Text, txtSenha.Text))
                {
                    this.Hide();
                    txtEmail.Clear();
                    txtSenha.Clear();

                    Form1.GetInstance().Show();
                    txtEmail.Focus();
                }
                else
                {
                    txtEmail.Clear();
                    txtSenha.Clear();
                    Erro.Text = "Email ou senha incorretos!";
                    txtEmail.Focus();
                }
            }
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }
        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAutenticar.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExibir_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }
    }
}

