using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            conectabanco conecta = new conectabanco();
            if (conecta.verifica(txtusernome.Text, txtsenha.Text) == true)
            {
                Pagina_Inicial pagina = new Pagina_Inicial();
                this.Hide();
                pagina.ShowDialog();
                this.Close();

            }// fim if
            else
            {
                MessageBox.Show("Usuario ou senha incorretos!!!"+ conecta.mensagem);

            }

        }

        private void txtusernome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
