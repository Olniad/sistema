using System;
using Caelum.Stella.CSharp.Validation;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sistema
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {
            sql = "select * from clientes;";   
        }
        ConexaoBD bd = new ConexaoBD();
        public void limpar()
        {
            txtClienteCPF.Clear();
            txtClienteEmail.Clear();
            txtClienteEndereco.Clear();
            txtClienteNome.Clear();
            txtClienteSenha.Clear();
        }
        string sql;
        //double carga;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // double carga = Convert.ToDouble(txt_carga.Text);
            this.Visible = false;          
            Login login = new Login();
            login.ShowDialog();
            this.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = txtClienteCPF.Text;
            if (cpf == "")
            {
                MessageBox.Show("Digite o cpf");
            }
            else
            {
                try
                {
                    new CPFValidator().AssertValid(cpf);
                    sql = string.Format("insert into clientes values (null, '{0}','{1}','{2}','{3}','{4}')"
                                    , txtClienteCPF.Text, txtClienteNome.Text, txtClienteEmail.Text, txtClienteSenha.Text, txtClienteEndereco.Text);
                    bd.AlterarTabelas(sql);
                    MessageBox.Show("Cadastrado com sucesso!!", "Cadastro ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listar();
                    limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CPF INVALIDO: " + cpf + " Digite seu CPF correto.");
                }
            }
                
            
            
            
        }
    }
}
