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
    public partial class ClienteFuncionario : Form
    {
        public ClienteFuncionario()
        {
            InitializeComponent();
        }

        private void imgFuncionario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroFuncionario cadastrofun = new CadastroFuncionario();
            cadastrofun.ShowDialog();
            this.Visible = true;
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroCliente cadastrocliente = new CadastroCliente();
            cadastrocliente.ShowDialog();
            this.Visible = true;
        }
    }
}
