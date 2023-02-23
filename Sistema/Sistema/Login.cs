using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {
            sql = "select * from funcionarios";
            sql2 = "select * from clientes";
        }
        ConexaoBD bd = new ConexaoBD();
        string sql, sql2;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClienteFuncionario escolher = new ClienteFuncionario();
            escolher.ShowDialog();
            this.Visible = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
              DataTable buscar = new DataTable();
              DataTable buscar2 = new DataTable();
              sql = string.Format("select * from funcionarios where cpf = '{1}' or senha = '{3}'", txtCPF.Text, txtDigiteSenha.Text);
              sql2 = string.Format("select * from clientes where cpf = '{0}' or senha = '{3}'", txtCPF.Text, txtDigiteSenha.Text);
              buscar = bd.ConsultarTabelas(sql);
              buscar2 = bd.ConsultarTabelas(sql2);
              if (buscar2.Rows.Count > 0)
              {
                  txtCPF.Text = buscar2.Rows[0]["cpf"].ToString();
                  txtDigiteSenha.Text = buscar2.Rows[0]["senha"].ToString();
                  MessageBox.Show("logado com sucesso!");
              }
              else if(buscar2.Rows.Count > 0){
                  txtCPF.Text = buscar2.Rows[0]["cpf"].ToString();
                  txtDigiteSenha.Text = buscar2.Rows[0]["senha"].ToString();
                  MessageBox.Show("logado com sucesso!");
              }
              else
              {
                  MessageBox.Show("Cadastro nao encontrado!!!", "Buscar ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            
          /*  SqlConnection bd = new SqlConnection("persist security info = false;" +
                                      "server=localhost;" +
                                      "database=sistemas;" +
                                      "uid=root;pwd=;");
            string query = "Select * from clientes Where cpf = '" + txtCPF.Text.Trim() + "' and senha = '" + txtDigiteSenha.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, bd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Login Login = new Login();
                this.Hide();
                Login.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
          */
        }
    }
}


