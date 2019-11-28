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
    public partial class Manutencao : Form
    {
        public Manutencao()
        {
            InitializeComponent();
        }

        private void Bt_Consultar_Click(object sender, EventArgs e)
        {
            //Tela de cadastro de manutenção
            //Conexão com o banco
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("select * from manutencao where IDclient=@IDclient", sql);
            //Comando de relacionar tabelas com o sistema
            comand.Parameters.Add("@IDclient", SqlDbType.Int).Value = tb_ID.Text;

            if (tb_ID.Text != "")
            {
                try
                {
                    //Abre o SQL e executa o comando
                    sql.Open();
                    SqlDataReader drms = comand.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        //Caso o ID não tenha sido registrado, mensagem de erro
                        throw new Exception("ID não encontrado!");
                    }
                    //Passa os valores da tabela para as texts box
                    drms.Read();
                    tb_ID.Text = Convert.ToString(drms["IDclient"]);
                    tb_Valor.Text = Convert.ToString(drms["Valor"]);
                    tb_Data.Text = Convert.ToString(drms["Dia"]);

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
                MessageBox.Show("Informe o valor de ID, por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Limpar_Click(object sender, EventArgs e)
        {
            //Limpa os campos
            tb_ID.Text = "";
            tb_Valor.Text = "";
            tb_Data.Text = "";
            tb_ID.Focus();
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //Conexão com o banco (SQL server)
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("insert into manutencao (IDclient, Valor, Dia) values (@IDclient, @Valor, @Dia)", sql);
            //Comando para relacionar as tabelas com o sistema
            comand.Parameters.Add("@IDclient", SqlDbType.Int).Value = tb_ID.Text;
            comand.Parameters.Add("@Valor", SqlDbType.Int).Value = tb_Valor.Text;
            comand.Parameters.Add("@Dia", SqlDbType.Date).Value = tb_Data.Text;

            int valor = Convert.ToInt32(tb_Valor.Text);
            if (valor < 0)
            {
                //Mansagem de erro caso digitem um valor menor que 0
                MessageBox.Show("O valor cobrado não pode ser negativo!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (tb_ID.Text != "" && tb_Valor.Text != "" && tb_Data.Text != "")
                {
                        try
                        {
                            //Abre o banco e executa o comando
                            sql.Open();
                            comand.ExecuteNonQuery();
                            MessageBox.Show("Cadastro efetuado com sucesso!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tb_ID.Text = "";
                            tb_Valor.Text = "";
                            tb_Data.Text = "";
                            tb_ID.Focus();
                        }
                        catch (Exception ex)
                        {
                            //Mensagem de erro
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sql.Close();
                        }
                }
                    else
                    {
                        MessageBox.Show("Digite todos os valores por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {
            //Conexão com o banco
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("delete from manutencao where IDclient=@IDclient", sql);
            comand.Parameters.Add("@IDclient", SqlDbType.Int).Value = tb_ID.Text;

            if (tb_ID.Text != "")
            {
                try
                {
                    //Abre o banco e executa o comando
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Dados excluído com sucesso!", "SISTEMA H2ORTA - EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_ID.Text = "";
                    tb_Valor.Text = "";
                    tb_Data.Text = "";
                    tb_ID.Focus();
                }
                catch (Exception ex)
                {
                    //Mensagem de erro
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Informe o valor de ID, por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
