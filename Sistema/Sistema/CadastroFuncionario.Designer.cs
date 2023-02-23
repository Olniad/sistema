namespace Sistema
{
    partial class CadastroFuncionario
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
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtFuncionarioCetor = new System.Windows.Forms.TextBox();
            this.txtFuncionarioCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncionarioEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncionarioNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtFuncionarioSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(55, 255);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(143, 24);
            this.lblEndereco.TabIndex = 33;
            this.lblEndereco.Text = "Digite seu Cetor";
            // 
            // txtFuncionarioCetor
            // 
            this.txtFuncionarioCetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarioCetor.Location = new System.Drawing.Point(61, 289);
            this.txtFuncionarioCetor.Name = "txtFuncionarioCetor";
            this.txtFuncionarioCetor.Size = new System.Drawing.Size(207, 22);
            this.txtFuncionarioCetor.TabIndex = 32;
            // 
            // txtFuncionarioCPF
            // 
            this.txtFuncionarioCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtFuncionarioCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarioCPF.Location = new System.Drawing.Point(61, 136);
            this.txtFuncionarioCPF.Mask = "000.000.000-00";
            this.txtFuncionarioCPF.Name = "txtFuncionarioCPF";
            this.txtFuncionarioCPF.Size = new System.Drawing.Size(129, 22);
            this.txtFuncionarioCPF.TabIndex = 31;
            this.txtFuncionarioCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFuncionarioCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Digite seu Email";
            // 
            // txtFuncionarioEmail
            // 
            this.txtFuncionarioEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarioEmail.Location = new System.Drawing.Point(300, 210);
            this.txtFuncionarioEmail.Name = "txtFuncionarioEmail";
            this.txtFuncionarioEmail.Size = new System.Drawing.Size(289, 22);
            this.txtFuncionarioEmail.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Digite seu Nome";
            // 
            // txtFuncionarioNome
            // 
            this.txtFuncionarioNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarioNome.Location = new System.Drawing.Point(300, 127);
            this.txtFuncionarioNome.Name = "txtFuncionarioNome";
            this.txtFuncionarioNome.Size = new System.Drawing.Size(289, 22);
            this.txtFuncionarioNome.TabIndex = 27;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(61, 361);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(153, 38);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(388, 361);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(158, 38);
            this.btnEntrar.TabIndex = 25;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(55, 31);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(154, 31);
            this.lblBemVindo.TabIndex = 24;
            this.lblBemVindo.Text = "Bem Vindo";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(55, 176);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(152, 24);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Digite sua Senha";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(55, 102);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(135, 24);
            this.lblCPF.TabIndex = 22;
            this.lblCPF.Text = "Digite seu CPF";
            // 
            // txtFuncionarioSenha
            // 
            this.txtFuncionarioSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarioSenha.Location = new System.Drawing.Point(61, 210);
            this.txtFuncionarioSenha.Name = "txtFuncionarioSenha";
            this.txtFuncionarioSenha.Size = new System.Drawing.Size(207, 22);
            this.txtFuncionarioSenha.TabIndex = 21;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtFuncionarioCetor);
            this.Controls.Add(this.txtFuncionarioCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFuncionarioEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuncionarioNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtFuncionarioSenha);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtFuncionarioCetor;
        private System.Windows.Forms.MaskedTextBox txtFuncionarioCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuncionarioEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncionarioNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtFuncionarioSenha;
    }
}