namespace autenticacaoCadastro
{
    partial class JanelaProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaProjeto));
            this.pnlPrincipalProjetos = new System.Windows.Forms.Panel();
            this.dtpTerminoProjetos = new System.Windows.Forms.DateTimePicker();
            this.dtpPrevistoProjetos = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioProjetos = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarProjeto = new System.Windows.Forms.Button();
            this.txbNomeProjeto = new System.Windows.Forms.TextBox();
            this.txtTerminoProjeto = new System.Windows.Forms.Label();
            this.txtTerminoPlanejado = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.Label();
            this.txtNome_Projeto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPrincipalProjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipalProjetos
            // 
            this.pnlPrincipalProjetos.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipalProjetos.Controls.Add(this.dtpTerminoProjetos);
            this.pnlPrincipalProjetos.Controls.Add(this.dtpPrevistoProjetos);
            this.pnlPrincipalProjetos.Controls.Add(this.dtpInicioProjetos);
            this.pnlPrincipalProjetos.Controls.Add(this.btnSalvarProjeto);
            this.pnlPrincipalProjetos.Controls.Add(this.txbNomeProjeto);
            this.pnlPrincipalProjetos.Controls.Add(this.txtTerminoProjeto);
            this.pnlPrincipalProjetos.Controls.Add(this.txtTerminoPlanejado);
            this.pnlPrincipalProjetos.Controls.Add(this.txtInicio);
            this.pnlPrincipalProjetos.Controls.Add(this.txtNome_Projeto);
            this.pnlPrincipalProjetos.Controls.Add(this.lblTitulo);
            this.pnlPrincipalProjetos.Location = new System.Drawing.Point(1, 0);
            this.pnlPrincipalProjetos.Name = "pnlPrincipalProjetos";
            this.pnlPrincipalProjetos.Size = new System.Drawing.Size(453, 455);
            this.pnlPrincipalProjetos.TabIndex = 0;
            // 
            // dtpTerminoProjetos
            // 
            this.dtpTerminoProjetos.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.dtpTerminoProjetos.Location = new System.Drawing.Point(30, 319);
            this.dtpTerminoProjetos.Name = "dtpTerminoProjetos";
            this.dtpTerminoProjetos.Size = new System.Drawing.Size(379, 20);
            this.dtpTerminoProjetos.TabIndex = 3;
            // 
            // dtpPrevistoProjetos
            // 
            this.dtpPrevistoProjetos.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.dtpPrevistoProjetos.Location = new System.Drawing.Point(27, 257);
            this.dtpPrevistoProjetos.Name = "dtpPrevistoProjetos";
            this.dtpPrevistoProjetos.Size = new System.Drawing.Size(382, 20);
            this.dtpPrevistoProjetos.TabIndex = 2;
            // 
            // dtpInicioProjetos
            // 
            this.dtpInicioProjetos.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.dtpInicioProjetos.Location = new System.Drawing.Point(30, 195);
            this.dtpInicioProjetos.Name = "dtpInicioProjetos";
            this.dtpInicioProjetos.Size = new System.Drawing.Size(379, 20);
            this.dtpInicioProjetos.TabIndex = 1;
            // 
            // btnSalvarProjeto
            // 
            this.btnSalvarProjeto.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvarProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProjeto.Location = new System.Drawing.Point(173, 383);
            this.btnSalvarProjeto.Name = "btnSalvarProjeto";
            this.btnSalvarProjeto.Size = new System.Drawing.Size(116, 41);
            this.btnSalvarProjeto.TabIndex = 4;
            this.btnSalvarProjeto.Text = "Salvar";
            this.btnSalvarProjeto.UseVisualStyleBackColor = false;
            this.btnSalvarProjeto.Click += new System.EventHandler(this.btnSalvarProjeto_Click);
            // 
            // txbNomeProjeto
            // 
            this.txbNomeProjeto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbNomeProjeto.Location = new System.Drawing.Point(30, 133);
            this.txbNomeProjeto.Name = "txbNomeProjeto";
            this.txbNomeProjeto.Size = new System.Drawing.Size(379, 20);
            this.txbNomeProjeto.TabIndex = 0;
            this.txbNomeProjeto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbNomeProjeto_KeyUp);
            // 
            // txtTerminoProjeto
            // 
            this.txtTerminoProjeto.AutoSize = true;
            this.txtTerminoProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminoProjeto.Location = new System.Drawing.Point(26, 296);
            this.txtTerminoProjeto.Name = "txtTerminoProjeto";
            this.txtTerminoProjeto.Size = new System.Drawing.Size(131, 20);
            this.txtTerminoProjeto.TabIndex = 4;
            this.txtTerminoProjeto.Text = "Data de término: ";
            // 
            // txtTerminoPlanejado
            // 
            this.txtTerminoPlanejado.AutoSize = true;
            this.txtTerminoPlanejado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminoPlanejado.Location = new System.Drawing.Point(26, 234);
            this.txtTerminoPlanejado.Name = "txtTerminoPlanejado";
            this.txtTerminoPlanejado.Size = new System.Drawing.Size(133, 20);
            this.txtTerminoPlanejado.TabIndex = 3;
            this.txtTerminoPlanejado.Text = "Término previsto: ";
            // 
            // txtInicio
            // 
            this.txtInicio.AutoSize = true;
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(26, 172);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(113, 20);
            this.txtInicio.TabIndex = 2;
            this.txtInicio.Text = "Data de início: ";
            // 
            // txtNome_Projeto
            // 
            this.txtNome_Projeto.AutoSize = true;
            this.txtNome_Projeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_Projeto.Location = new System.Drawing.Point(26, 110);
            this.txtNome_Projeto.Name = "txtNome_Projeto";
            this.txtNome_Projeto.Size = new System.Drawing.Size(135, 20);
            this.txtNome_Projeto.TabIndex = 1;
            this.txtNome_Projeto.Text = "Nome do Projeto :";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(113, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastrar Projeto";
            // 
            // CadastrarProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 448);
            this.Controls.Add(this.pnlPrincipalProjetos);
            this.Name = "CadastrarProjeto";
            this.Text = "Novo Cadastro";
            this.pnlPrincipalProjetos.ResumeLayout(false);
            this.pnlPrincipalProjetos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipalProjetos;
        private System.Windows.Forms.Button btnSalvarProjeto;
        private System.Windows.Forms.TextBox txbNomeProjeto;
        private System.Windows.Forms.Label txtTerminoProjeto;
        private System.Windows.Forms.Label txtTerminoPlanejado;
        private System.Windows.Forms.Label txtInicio;
        private System.Windows.Forms.Label txtNome_Projeto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpTerminoProjetos;
        private System.Windows.Forms.DateTimePicker dtpPrevistoProjetos;
        private System.Windows.Forms.DateTimePicker dtpInicioProjetos;
    }
}