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

namespace PI_01
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Bt_Logar_Click(object sender, EventArgs e)
        {
            //Tela de cadastro de usuário
            //Conexão com o banco (SQL server)
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("insert into usuarios (Email, senha) values (@Email, @senha)", sql);
            //Comando para relacionar a tabela com o sistema
            comand.Parameters.Add("@Email", SqlDbType.VarChar).Value = tb_Email.Text;
            comand.Parameters.Add("@senha", SqlDbType.VarChar).Value = tb_Senha.Text;

            if (tb_Email.Text != "" && tb_Senha.Text != "")
            {
                try
                {
                    //Abre o banco e executa o comando
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Email.Text = "";
                    tb_Senha.Text = "";
                }
                catch (Exception ex)
                {
                    //Mensagem de erro
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //Fecha o banco
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite todos os valores por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Sair_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão sair, a tela fecha
            Close();
        }
    }
}
