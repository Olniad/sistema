namespace Sistema
{
    partial class ListarFuncionarios
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtClienteBuscar = new System.Windows.Forms.TextBox();
            this.btnClienteEditar = new System.Windows.Forms.Button();
            this.btnClienteExcluir = new System.Windows.Forms.Button();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(396, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(263, 13);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Digite aqui o cpf de quem deseja buscar/editar/excluir";
            // 
            // txtClienteBuscar
            // 
            this.txtClienteBuscar.Location = new System.Drawing.Point(399, 51);
            this.txtClienteBuscar.Name = "txtClienteBuscar";
            this.txtClienteBuscar.Size = new System.Drawing.Size(260, 20);
            this.txtClienteBuscar.TabIndex = 10;
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.Location = new System.Drawing.Point(585, 335);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(74, 31);
            this.btnClienteEditar.TabIndex = 9;
            this.btnClienteEditar.Text = "Editar";
            this.btnClienteEditar.UseVisualStyleBackColor = true;
            // 
            // btnClienteExcluir
            // 
            this.btnClienteExcluir.Location = new System.Drawing.Point(488, 335);
            this.btnClienteExcluir.Name = "btnClienteExcluir";
            this.btnClienteExcluir.Size = new System.Drawing.Size(78, 31);
            this.btnClienteExcluir.TabIndex = 8;
            this.btnClienteExcluir.Text = "Excluir";
            this.btnClienteExcluir.UseVisualStyleBackColor = true;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Location = new System.Drawing.Point(396, 335);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(76, 31);
            this.btnClienteBuscar.TabIndex = 7;
            this.btnClienteBuscar.Text = "Buscar";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 426);
            this.dataGridView1.TabIndex = 6;
            // 
            // ListarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtClienteBuscar);
            this.Controls.Add(this.btnClienteEditar);
            this.Controls.Add(this.btnClienteExcluir);
            this.Controls.Add(this.btnClienteBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListarFuncionarios";
            this.Text = "ListarFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtClienteBuscar;
        private System.Windows.Forms.Button btnClienteEditar;
        private System.Windows.Forms.Button btnClienteExcluir;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}