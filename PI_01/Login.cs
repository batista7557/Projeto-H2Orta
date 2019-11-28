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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Bt_Logar_Click(object sender, EventArgs e)
        {
            //Tela de login
            //Conexão com o bando (SQL server)
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("select * from usuarios where Email=@Email and senha=@senha", sql);
            //Comando de relacionar tabelas com o sistema
            comand.Parameters.Add("@Email", SqlDbType.VarChar).Value = tb_Email.Text;
            comand.Parameters.Add("@senha", SqlDbType.VarChar).Value = tb_Senha.Text;

            if (tb_Email.Text != "" && tb_Senha.Text != "")
            {
                try
                {
                    //Abre o banco e executa o comando
                    sql.Open();
                    SqlDataReader login = comand.ExecuteReader();
                    if (login.HasRows == false)
                    {
                        //Mensagem de erro caso os valores não estejam certos
                        throw new Exception("Usuário ou senha incorretos!");
                    }
                    //Se o login funcionar, abre a página de home
                    login.Read();
                    Home home = new Home();
                    home.Show();
                    //Fecha tela de login
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    //Mensagem de erro
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //Fecha o SQL
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite todos os valores por favor!", "SISTEMA H2ORTA - LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //Caso clique no botão de cadastro, abre a tela de cadastro
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void Bt_Sair_Click(object sender, EventArgs e)
        {
            //Se clicar em sair, a tela fecha
            Close();
        }
    }
}
