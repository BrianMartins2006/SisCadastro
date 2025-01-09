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
    public partial class Pagina_Inicial : Form
    {
        int IDAuterar;
        private object txtauteranome_TextChanged;

        public Pagina_Inicial()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            listaderodutos();
            
        }
       public void listaderodutos()
        {
            conectabanco con = new conectabanco();
            dglista.DataSource = con.listaprodutos();
            dglista.Columns["ProdutoID"].Visible = false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
          Form1 frm = new Form1();

            frm.ShowDialog();
            listaderodutos();
        }

        private void bteditarproduto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btaddcategoria_Click(object sender, EventArgs e)
        {

        }

        private void dglista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            (dglista.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("Nomeproduto like '{0}%'", txtbusca.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {
            (dglista.DataSource as DataTable).DefaultView.RowFilter =
    string.Format("CONVERT(Preco, 'System.String') LIKE '%{0}%'", txtpreco.Text);



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcategoria_TextChanged(object sender, EventArgs e)
        {
            (dglista.DataSource as DataTable).DefaultView.RowFilter =
               string.Format("Categoria like '{0}%'", txtcategoria.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btremover_Click(object sender, EventArgs e)
        {
            int linha = dglista.CurrentRow.Index;
            int ID = Convert.ToInt32(
                dglista.Rows[linha].Cells["ProdutoID"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Produto", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                conectabanco con = new conectabanco();
                bool retorno = con.deletaprodutos(ID);
                if (retorno == true)
                {
                    MessageBox.Show("Produto excluido com sucesso");
                    listaderodutos();
                }
                else
                    MessageBox.Show(con.mensagem);
            }
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            Auterar aut = new Auterar();
            

            aut.ShowDialog();
            listaderodutos();

        }

        private void btaddcategoria_Click_1(object sender, EventArgs e)
        {
           Addcategoria add = new Addcategoria();
            
            add.ShowDialog();
        }
    }
}
