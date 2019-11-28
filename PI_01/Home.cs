using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_01
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tela de home do sistema
            //Strip menu com os items para redirecionamento de telas
            //Quando criado no item de Clientes, abre a tela de cadastro de clientes
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Caso clique no botão sair, a tela fecha
            Close();
        }

        private void EstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Quando a opção de estoque é clicada aparece a tela de cadastro de estoque
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void ManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Quando a opção de manutenção é clicada, a tela de cadastro de manutenção é aberta
            Manutencao manutencao = new Manutencao();
            manutencao.Show();
        }
    }
}
