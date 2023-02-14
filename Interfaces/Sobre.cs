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
    public partial class Sobre : Form
    {
        private static Sobre instance;
        private Sobre()
        {
            InitializeComponent();
        }

        public static Sobre GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Sobre();
            }
            instance.MdiParent = Form1.ActiveForm;
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
