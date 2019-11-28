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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //Tela de cadastro de clientes
            //Conexão com o banco de dados (SQL server)
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand  = new SqlCommand("insert into clientes (Nome, Telefone, CPF, Pagamento, Garantia, Estufa) values (@Nome, @Telefone, @CPF, @Pagamento, @Garantia, @Estufa)", sql);
            //Comando de relacionar as texts box do sistema com os valores das tabelas do banco de dados
            comand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = tb_Nome.Text;
            comand.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = Tb_Telefone.Text;
            comand.Parameters.Add("@CPF", SqlDbType.VarChar).Value = tb_CPF.Text;
            comand.Parameters.Add("@Pagamento", SqlDbType.Date).Value = tb_Pagamento.Text;
            comand.Parameters.Add("@Garantia", SqlDbType.Date).Value = tb_Garantia.Text;
            if (rb_Semi.Checked == true)
            {
                comand.Parameters.Add("@Estufa", SqlDbType.VarChar).Value = "Semi-aberto";
                rb_Semi.Checked = false;
            }
            else if(rb_Fechado.Checked == true)
            {
                comand.Parameters.Add("@Estufa", SqlDbType.VarChar).Value = "Fechado";
                rb_Fechado.Checked = false;
            }
            else if (rb_Aqua.Checked == true)
            {
                comand.Parameters.Add("@Estufa", SqlDbType.VarChar).Value = "Aquario";
                rb_Aqua.Checked = false;
            }

            if (tb_ID.Text == "")
            {
                if (tb_Nome.Text != "" && Tb_Telefone.Text != "" && tb_CPF.Text != "" && tb_Pagamento.Text != "" && tb_Garantia.Text != "")
                {
                    try
                    {
                        //Abrir o banco e executar o comando de relação entre as texts box e as tabelas
                        sql.Open();
                        comand.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado com sucesso!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpar campos
                        tb_Nome.Text = "";
                        Tb_Telefone.Text = "";
                        tb_CPF.Text = "";
                        tb_Pagamento.Text = "";
                        tb_Garantia.Text = "";
                        tb_Nome.Focus();
                    }
                    catch (Exception ex)
                    {
                        //Mensagem de erro caso algo dê errado
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
                else
                {
                    //Mensagem de erro caso os valores não tenham sido preenchidos
                    MessageBox.Show("Digite todos os valores por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Mensagem de erro caso o valor de ID tenha sido informado, tendo em vista que ele é definido como um número auto-geravel
                MessageBox.Show("O valor de ID não deve ser informado!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Limpar_Click(object sender, EventArgs e)
        {
            //Limpar campos
            tb_ID.Text = "";
            tb_Nome.Text = "";
            Tb_Telefone.Text = "";
            tb_CPF.Text = "";
            tb_Pagamento.Text = "";
            tb_Garantia.Text = "";
            rb_Semi.Checked = false;
            rb_Fechado.Checked = false;
            rb_Aqua.Checked = false;
            tb_Nome.Focus();
        }

        private void Bt_Consultar_Click(object sender, EventArgs e)
        {
            //Conexão com o banco (SQL server)
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("select * from clientes where IDuser=@IDuser", sql);
            //Comando de relacionar tabelas com os valores inseridos
            comand.Parameters.Add("@IDuser", SqlDbType.Int).Value = tb_ID.Text;

            if (tb_ID.Text != "")
            {
                try
                {
                    //Abrir o banco e executar o comando
                    sql.Open();
                    SqlDataReader drms = comand.ExecuteReader();
                    //Caso o ID não tenha sido cadastrado, mensagem de erro
                    if (drms.HasRows == false)
                    {
                        throw new Exception("ID não encontrado!");
                    }
                    //Passar os valores do banco para o sistema
                    drms.Read();
                    tb_ID.Text = Convert.ToString(drms["IDuser"]);
                    tb_Nome.Text = Convert.ToString(drms["Nome"]);
                    Tb_Telefone.Text = Convert.ToString(drms["Telefone"]);
                    tb_CPF.Text = Convert.ToString(drms["CPF"]);
                    tb_Pagamento.Text = Convert.ToString(drms["Pagamento"]);
                    tb_Garantia.Text = Convert.ToString(drms["Garantia"]);
                    if (drms["Estufa"].ToString() == "Semi-aberto")
                    {
                        rb_Semi.Checked = true;
                    }
                    else if (drms["Estufa"].ToString() == "Fechado")
                    {
                        rb_Fechado.Checked = true;
                    }
                    else if (drms["Estufa"].ToString() == "Aquario")
                    {
                        rb_Aqua.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    //Mensagem de erro
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //Fechar o SQL
                    sql.Close();
                }
            }
            else
            {
                //Mensagem de erro caso o ID não tenha sido informado
                MessageBox.Show("Informe o valor de ID, por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {
            //Conexão com o Banco (SQL server)
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=h2ortas01;Data Source=PC\\SQLEXPRESS");
            SqlCommand comand = new SqlCommand("delete from clientes where IDuser=@IDuser", sql);
            //Comando de relacionar tabelas com o sistema
            comand.Parameters.Add("@IDuser", SqlDbType.Int).Value = tb_ID.Text;

            if (tb_ID.Text != "")
            {
                try
                {
                    //Abrir o sistema e executar o comando
                    sql.Open();
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Dados excluído com sucesso!", "SISTEMA H2ORTA - EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar campos
                    tb_ID.Text = "";
                    tb_Nome.Text = "";
                    Tb_Telefone.Text = "";
                    tb_CPF.Text = "";
                    tb_Pagamento.Text = "";
                    tb_Garantia.Text = "";
                    rb_Semi.Checked = false;
                    rb_Fechado.Checked = false;
                    rb_Aqua.Checked = false;
                    tb_Nome.Focus();
                }
                catch (Exception ex)
                {
                    //Mensagem de erro
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //Fechar o SQL
                    sql.Close();
                }
            }
            else
            {
                //Mensagem de erro caso o ID não tenha sido encontrado
                MessageBox.Show("Informe o valor de ID, por favor!", "SISTEMA H2ORTA - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
