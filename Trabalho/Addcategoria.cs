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
    public partial class Addcategoria : Form
    {
        public Addcategoria()
        {
            InitializeComponent();
        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            conectabanco con = new conectabanco();            
            bool retorno = con.inserenovacategoria(txtaddcategoria.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Categoria adicionada com sucesso!!!");
            txtaddcategoria.Clear();
            txtaddcategoria.Focus();
        }
    }
}
