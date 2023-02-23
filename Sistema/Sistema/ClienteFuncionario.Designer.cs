namespace Sistema
{
    partial class ClienteFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteFuncionario));
            this.imgFuncionario = new System.Windows.Forms.PictureBox();
            this.imgCliente = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFuncionario
            // 
            this.imgFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("imgFuncionario.Image")));
            this.imgFuncionario.Location = new System.Drawing.Point(52, 128);
            this.imgFuncionario.Name = "imgFuncionario";
            this.imgFuncionario.Size = new System.Drawing.Size(202, 195);
            this.imgFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFuncionario.TabIndex = 0;
            this.imgFuncionario.TabStop = false;
            this.imgFuncionario.Click += new System.EventHandler(this.imgFuncionario_Click);
            // 
            // imgCliente
            // 
            this.imgCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCliente.Image = ((System.Drawing.Image)(resources.GetObject("imgCliente.Image")));
            this.imgCliente.Location = new System.Drawing.Point(445, 128);
            this.imgCliente.Name = "imgCliente";
            this.imgCliente.Size = new System.Drawing.Size(195, 202);
            this.imgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCliente.TabIndex = 1;
            this.imgCliente.TabStop = false;
            this.imgCliente.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Fmo2mf1WAAM8PVH.png");
            this.imageList.Images.SetKeyName(1, "pazpeacefulcochao.png");
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(46, 76);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(156, 31);
            this.lblFuncionario.TabIndex = 2;
            this.lblFuncionario.Text = "Funcionario";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(439, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(99, 31);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // ClienteFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.imgCliente);
            this.Controls.Add(this.imgFuncionario);
            this.Name = "ClienteFuncionario";
            this.Text = "ClienteFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFuncionario;
        private System.Windows.Forms.PictureBox imgCliente;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCliente;
    }
}