using autenticacaoCadastro.Interfaces;
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
    public partial class Form1 : Form
    {
        private Form1()
        {
            InitializeComponent();
        }
        private static Form1 instance;

        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }
            return instance;
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProjeto.GetInstance().Show();                   
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarDesenvolvedor.GetInstance().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre.GetInstance().Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            this.Close();
            Login.GetInstance().Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void alocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAlocacao.GetInstance().Show();
        }

        private void tarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarTarefa.GetInstance().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c is MdiClient)
                    c.BackColor = Color.Black;
        }
    }
}
