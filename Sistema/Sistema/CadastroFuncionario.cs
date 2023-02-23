using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
            listar();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql;

        public void listar()
        {
            sql = "select * from funcionarios;";
        }
        public void limpar()
        {
            txtFuncionarioCPF.Clear();
            txtFuncionarioEmail.Clear();
            txtFuncionarioCetor.Clear();
            txtFuncionarioNome.Clear();
            txtFuncionarioSenha.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = txtFuncionarioCPF.Text;
            if (cpf == "")
            {
                MessageBox.Show("Digite o cpf");
            }
            else
            {
                try
                {
                    new CPFValidator().AssertValid(cpf);
                    sql = string.Format("insert into funcionarios values (null, '{0}','{1}','{2}','{3}','{4}')"
                                    , txtFuncionarioCPF.Text, txtFuncionarioNome.Text, txtFuncionarioEmail.Text, txtFuncionarioSenha.Text, txtFuncionarioCetor.Text);
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
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            this.Visible = true;
        }
    }
}
