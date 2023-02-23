namespace Sistema
{
    partial class ListarClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.btnClienteExcluir = new System.Windows.Forms.Button();
            this.btnClienteEditar = new System.Windows.Forms.Button();
            this.txtClienteBuscar = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Location = new System.Drawing.Point(374, 335);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(76, 31);
            this.btnClienteBuscar.TabIndex = 1;
            this.btnClienteBuscar.Text = "Buscar";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // btnClienteExcluir
            // 
            this.btnClienteExcluir.Location = new System.Drawing.Point(466, 335);
            this.btnClienteExcluir.Name = "btnClienteExcluir";
            this.btnClienteExcluir.Size = new System.Drawing.Size(78, 31);
            this.btnClienteExcluir.TabIndex = 2;
            this.btnClienteExcluir.Text = "Excluir";
            this.btnClienteExcluir.UseVisualStyleBackColor = true;
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.Location = new System.Drawing.Point(563, 335);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(74, 31);
            this.btnClienteEditar.TabIndex = 3;
            this.btnClienteEditar.Text = "Editar";
            this.btnClienteEditar.UseVisualStyleBackColor = true;
            // 
            // txtClienteBuscar
            // 
            this.txtClienteBuscar.Location = new System.Drawing.Point(377, 51);
            this.txtClienteBuscar.Name = "txtClienteBuscar";
            this.txtClienteBuscar.Size = new System.Drawing.Size(260, 20);
            this.txtClienteBuscar.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(374, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(263, 13);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Digite aqui o cpf de quem deseja buscar/editar/excluir";
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtClienteBuscar);
            this.Controls.Add(this.btnClienteEditar);
            this.Controls.Add(this.btnClienteExcluir);
            this.Controls.Add(this.btnClienteBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListarClientes";
            this.Text = "ListarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.Button btnClienteExcluir;
        private System.Windows.Forms.Button btnClienteEditar;
        private System.Windows.Forms.TextBox txtClienteBuscar;
        private System.Windows.Forms.Label lblCliente;
    }
}