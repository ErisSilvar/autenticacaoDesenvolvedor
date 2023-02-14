namespace autenticacaoCadastro
{
    partial class JanelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaLogin));
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnlPrincipalLogin = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExibir = new System.Windows.Forms.Label();
            this.Erro = new System.Windows.Forms.Label();
            this.pnlPrincipalLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(42, 323);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 14);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha:";
            // 
            // pnlPrincipalLogin
            // 
            this.pnlPrincipalLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipalLogin.Controls.Add(this.Erro);
            this.pnlPrincipalLogin.Controls.Add(this.lblExibir);
            this.pnlPrincipalLogin.Controls.Add(this.label2);
            this.pnlPrincipalLogin.Controls.Add(this.label3);
            this.pnlPrincipalLogin.Controls.Add(this.label1);
            this.pnlPrincipalLogin.Controls.Add(this.btnfechar);
            this.pnlPrincipalLogin.Controls.Add(this.txtSenha);
            this.pnlPrincipalLogin.Controls.Add(this.txtEmail);
            this.pnlPrincipalLogin.Controls.Add(this.lblErro);
            this.pnlPrincipalLogin.Controls.Add(this.btnAutenticar);
            this.pnlPrincipalLogin.Controls.Add(this.lblSenha);
            this.pnlPrincipalLogin.Location = new System.Drawing.Point(2, -1);
            this.pnlPrincipalLogin.Name = "pnlPrincipalLogin";
            this.pnlPrincipalLogin.Size = new System.Drawing.Size(427, 438);
            this.pnlPrincipalLogin.TabIndex = 12;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha.Location = new System.Drawing.Point(96, 321);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(282, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyUp);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Location = new System.Drawing.Point(97, 286);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(10, 142);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 15;
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutenticar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutenticar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAutenticar.Location = new System.Drawing.Point(45, 382);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(119, 34);
            this.btnAutenticar.TabIndex = 14;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.UseVisualStyleBackColor = false;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click_1);
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnfechar.Location = new System.Drawing.Point(259, 382);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(119, 34);
            this.btnfechar.TabIndex = 16;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(132, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "Welcome Back";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 60);
            this.label3.TabIndex = 18;
            this.label3.Text = "HEY!";
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExibir.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibir.ForeColor = System.Drawing.Color.Red;
            this.lblExibir.Location = new System.Drawing.Point(290, 344);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(88, 14);
            this.lblExibir.TabIndex = 20;
            this.lblExibir.Text = "Exibir senha";
            this.lblExibir.Click += new System.EventHandler(this.lblExibir_Click);
            // 
            // Erro
            // 
            this.Erro.AutoSize = true;
            this.Erro.ForeColor = System.Drawing.Color.Red;
            this.Erro.Location = new System.Drawing.Point(94, 270);
            this.Erro.Name = "Erro";
            this.Erro.Size = new System.Drawing.Size(16, 13);
            this.Erro.TabIndex = 21;
            this.Erro.Text = "...";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 436);
            this.Controls.Add(this.pnlPrincipalLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlPrincipalLogin.ResumeLayout(false);
            this.pnlPrincipalLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel pnlPrincipalLogin;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.Label Erro;
    }
}