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
    public partial class Auterar : Form
    {
        int IDAuterar;
        public Auterar()
        {
            InitializeComponent();
           
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

            listaCBcategorias();
            Listadeprodutos();
            
        }
        public void Listadeprodutos()
        {
            conectabanco con = new conectabanco();
            dglista.DataSource = con.listaprodutos();
            dglista.Columns["ProdutoID"].Visible = false;
        }

        public void listaCBcategorias()
        {
            conectabanco con = new conectabanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listacategorias();
            cbauteracategoria.DataSource = tabelaDados;
            cbauteracategoria.DisplayMember = "Nomecategoria";
            cbauteracategoria.ValueMember = "CategoriaID";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            Close();
            listaCBcategorias();
        }
        public void listaderodutos()
        {
            conectabanco con = new conectabanco();
            dglista.DataSource = con.listaprodutos();
            dglista.Columns["ProdutoID"].Visible = false;
        }


        public void txtauteranome_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void cbauteracategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void txtauterapreço_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void addimagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            conectabanco con = new conectabanco();
            Produtos novoProduto = new Produtos();
            novoProduto.Nome1 = txtauteranome.Text;
            novoProduto.Categoria1 = Convert.ToInt32(cbauteracategoria.SelectedValue.ToString());
            novoProduto.Preco1 = Convert.ToDouble(txtauterapreço.Text);
            bool retorno = con.alteraproduto(novoProduto, IDAuterar);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Item auterado com sucesso!!!");
            Listadeprodutos();
            Close();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btdeauterar_Click(object sender, EventArgs e)
        {
            int linha = dglista.CurrentRow.Index;
            IDAuterar = Convert.ToInt32(
                dglista.Rows[linha].Cells["ProdutoID"].Value.ToString());
            txtauteranome.Text =
                dglista.Rows[linha].Cells["Nomeproduto"].Value.ToString();
            cbauteracategoria.Text =
               dglista.Rows[linha].Cells["Nomecategoria"].Value.ToString();
            txtauterapreço.Text =
               dglista.Rows[linha].Cells["Preco"].Value.ToString();

        }
    }
}
