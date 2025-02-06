using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaCBcategorias();
            
           
        }
       


        public void listaCBcategorias()
        {
            conectabanco con = new conectabanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listacategorias();
            cbcategoria.DataSource = tabelaDados;
            cbcategoria.DisplayMember = "Nomecategoria";
            cbcategoria.ValueMember = "CategoriaID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        void limpaCampos()
        {
            txtnome.Clear();
            cbcategoria.Text = "";
            txtpreco.Clear();
            txtnome.Focus();

        }



        private void button4_Click(object sender, EventArgs e)
        {
            conectabanco con = new conectabanco();
            Produtos novoProduto = new Produtos();
            novoProduto.Nome1 = txtnome.Text;
            novoProduto.Categoria1 = Convert.ToInt32(cbcategoria.SelectedValue.ToString());
            novoProduto.Preco1 = Convert.ToDouble(txtpreco.Text);
            bool retorno = con.insereproduto(novoProduto);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            limpaCampos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        /*private void addimagem_Click(object sender, EventArgs e)
        {
            if(txtnome.Text == "")
            {
                return;
            }

            OpenFileDialog caixa = new OpenFileDialog();

            caixa.Filter = "Arquivos imagem|*.jpg;*.jpeg;*.png;*gif;*.bmp";

            caixa.ShowDialog();

            if (caixa.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(caixa.FileName);
            }
           pra add imagem 
        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
