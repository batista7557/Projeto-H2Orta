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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Limpar_Click(object sender, EventArgs e)
        {
            //Limpar campos
            tb_ID.Text = "";
            tb_Peca.Text = "";
            tb_Data.Text = "";
            tb_Quant.Text = "";
            tb_Peca.Focus();
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //Tela de cadastro de estoque
            //Conexão com o banco (SQL server)
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("insert into estoque (Peça, Quantidade, Dia) values (@Peça, @Quantidade, @Dia)", sql);
            //Comando de relacionar tabelas e campos
            comand.Parameters.Add("@Peça", SqlDbType.VarChar).Value = tb_Peca.Text;
            comand.Parameters.Add("@Quantidade", SqlDbType.Int).Value = tb_Quant.Text;
            comand.Parameters.Add("@Dia", SqlDbType.Date).Value = tb_Data.Text;

            if (tb_ID.Text == "")
            {
                if (tb_Peca.Text != "" && tb_Quant.Text != "" && tb_Data.Text != "")
                {
                    try
                    {
                        //Abre SQL e executa o comando
                        sql.Open();
                        comand.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado com sucesso!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpa campos
                        tb_Peca.Text = "";
                        tb_Quant.Text = "";
                        tb_Data.Text = "";
                        tb_Peca.Focus();
                    }
                    catch (Exception ex)
                    {
                        //Mensagem caso algo de errado
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
                    MessageBox.Show("Digite todos os valores por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O valor de ID não deve ser informado!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Consultar_Click(object sender, EventArgs e)
        {
            //Conexão com o banco 
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("select * from estoque where IDpeca=@IDpeca", sql);
            comand.Parameters.Add("@IDpeca", SqlDbType.Int).Value = tb_ID.Text;

            if (tb_ID.Text != "")
            {
                try
                {
                    //Abre o banco e executa o comando
                    sql.Open();
                    SqlDataReader drms = comand.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        //Mensagem de erro caso o ID não tenha sido registrado
                        throw new Exception("ID não encontrado!");
                    }
                    //Converte os valores da tabela para o sistema
                    drms.Read();
                    tb_ID.Text = Convert.ToString(drms["IDpeca"]);
                    tb_Peca.Text = Convert.ToString(drms["Peça"]);
                    tb_Quant.Text = Convert.ToString(drms["Quantidade"]);
                    tb_Data.Text = Convert.ToString(drms["Dia"]);

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
                MessageBox.Show("Informe o valor de ID, por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {
            //Conexão com o banco 
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("delete from estoque where IDpeca=@IDpeca", sql);
            //Comando de relacionar tabelas com o sistema
            comand.Parameters.Add("@IDpeca", SqlDbType.Int).Value = tb_ID.Text;

            if (tb_ID.Text != "")
            {
                try
                {
                    //Abre o banco e executa o comando
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Dados excluído com sucesso!", "SISTEMA H2ORTA - EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_ID.Text = "";
                    tb_Peca.Text = "";
                    tb_Quant.Text = "";
                    tb_Data.Text = "";
                    tb_Peca.Focus();
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
    }
}
