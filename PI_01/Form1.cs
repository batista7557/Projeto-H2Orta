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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Tela inicial de carregamento
            //Contagem da barra
            if (pb_Inicial.Value < 100)
            {
                pb_Inicial.Value = pb_Inicial.Value + 2;
            }
            else
            {
                //Quando a barra terminar de carregar, abre a tela de login e essa tela fecha
                timer1.Enabled = false;
                Login log = new Login();
                log.Show();
                this.Visible = false;
            }
        }
    }
}
