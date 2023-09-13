﻿namespace prjAula1
{
    partial class TelaAlterarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarDados));
            cmbAlterarEstados = new ComboBox();
            dtpAlterarDataNascimento = new DateTimePicker();
            txtAlterarCidade = new TextBox();
            pictureBox2 = new PictureBox();
            btnAlterarDados = new Button();
            txtAlterarEmail = new TextBox();
            txtAlterarCPF = new TextBox();
            txtAlterarNome = new TextBox();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            txtConfirmarSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbAlterarEstados
            // 
            cmbAlterarEstados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAlterarEstados.FormattingEnabled = true;
            cmbAlterarEstados.Items.AddRange(new object[] { "RR", "AP", "AM", "PA", "MA", "CE", "RN", "PB", "PE", "AC", "RO", "TO", "MT", "BA", "AL", "PI", "SE", "DF", "GO", "MG", "MS", "ES", "SP", "RJ", "PR", "SC", "RS" });
            cmbAlterarEstados.Location = new Point(92, 279);
            cmbAlterarEstados.Name = "cmbAlterarEstados";
            cmbAlterarEstados.Size = new Size(203, 33);
            cmbAlterarEstados.TabIndex = 55;
            cmbAlterarEstados.Text = "UF";
            cmbAlterarEstados.SelectedIndexChanged += cmbAlterarEstados_SelectedIndexChanged;
            // 
            // dtpAlterarDataNascimento
            // 
            dtpAlterarDataNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpAlterarDataNascimento.Location = new Point(92, 201);
            dtpAlterarDataNascimento.Name = "dtpAlterarDataNascimento";
            dtpAlterarDataNascimento.Size = new Size(203, 33);
            dtpAlterarDataNascimento.TabIndex = 54;
            // 
            // txtAlterarCidade
            // 
            txtAlterarCidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarCidade.ForeColor = SystemColors.ScrollBar;
            txtAlterarCidade.Location = new Point(92, 318);
            txtAlterarCidade.Name = "txtAlterarCidade";
            txtAlterarCidade.PlaceholderText = "cidade";
            txtAlterarCidade.Size = new Size(203, 33);
            txtAlterarCidade.TabIndex = 52;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(317, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // btnAlterarDados
            // 
            btnAlterarDados.BackColor = Color.DeepPink;
            btnAlterarDados.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarDados.ForeColor = Color.White;
            btnAlterarDados.Location = new Point(92, 382);
            btnAlterarDados.Name = "btnAlterarDados";
            btnAlterarDados.Size = new Size(203, 40);
            btnAlterarDados.TabIndex = 50;
            btnAlterarDados.Text = "Alterar Dados";
            btnAlterarDados.UseVisualStyleBackColor = false;
            btnAlterarDados.Click += button2_Click;
            // 
            // txtAlterarEmail
            // 
            txtAlterarEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarEmail.ForeColor = SystemColors.ScrollBar;
            txtAlterarEmail.Location = new Point(92, 240);
            txtAlterarEmail.Name = "txtAlterarEmail";
            txtAlterarEmail.PlaceholderText = "email";
            txtAlterarEmail.Size = new Size(203, 33);
            txtAlterarEmail.TabIndex = 49;
            // 
            // txtAlterarCPF
            // 
            txtAlterarCPF.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarCPF.ForeColor = SystemColors.ScrollBar;
            txtAlterarCPF.Location = new Point(92, 162);
            txtAlterarCPF.Name = "txtAlterarCPF";
            txtAlterarCPF.PlaceholderText = "CPF";
            txtAlterarCPF.Size = new Size(203, 33);
            txtAlterarCPF.TabIndex = 48;
            // 
            // txtAlterarNome
            // 
            txtAlterarNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarNome.ForeColor = SystemColors.ScrollBar;
            txtAlterarNome.Location = new Point(92, 123);
            txtAlterarNome.Name = "txtAlterarNome";
            txtAlterarNome.PlaceholderText = "Nome Completo";
            txtAlterarNome.Size = new Size(203, 33);
            txtAlterarNome.TabIndex = 46;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(92, 45);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(203, 45);
            lblLogin.TabIndex = 45;
            lblLogin.Text = "ALTERAR DADOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(73, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 269);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenha.ForeColor = SystemColors.ScrollBar;
            txtConfirmarSenha.Location = new Point(341, 123);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            txtConfirmarSenha.Size = new Size(153, 33);
            txtConfirmarSenha.TabIndex = 56;
            // 
            // TelaAlterarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(520, 439);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(cmbAlterarEstados);
            Controls.Add(dtpAlterarDataNascimento);
            Controls.Add(txtAlterarCidade);
            Controls.Add(pictureBox2);
            Controls.Add(btnAlterarDados);
            Controls.Add(txtAlterarEmail);
            Controls.Add(txtAlterarCPF);
            Controls.Add(txtAlterarNome);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "TelaAlterarDados";
            Text = "TelaAlterarDados";
            Load += TelaAlterarDados_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAlterarEstados;
        private DateTimePicker dtpAlterarDataNascimento;
        private TextBox txtAlterarCidade;
        internal protected PictureBox pictureBox2;
        private Button btnAlterarDados;
        private TextBox txtAlterarEmail;
        private TextBox txtAlterarCPF;
        private TextBox txtAlterarNome;
        private Label lblLogin;
        private PictureBox pictureBox1;
        private TextBox txtConfirmarSenha;
    }
}