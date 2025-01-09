using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Trabalho
{
    class conectabanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=SisCadastro");
        public string mensagem;
        

        public bool insereproduto(Produtos novoProduto)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereproduto", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nomeproduto", novoProduto.Nome1);
                cmd.Parameters.AddWithValue("Preco", novoProduto.Preco1);
                cmd.Parameters.AddWithValue("CategoriaID", novoProduto.Categoria1);
                cmd.ExecuteNonQuery(); // Executar Banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }

        } // fim do insereBanda
        public bool inserenovacategoria(string novacategoria)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereCategorias", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nomecategoria", novacategoria);
               
                cmd.ExecuteNonQuery(); // Executar Banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }

        } // fim do inserecaregoria


        public DataTable listacategorias()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listacategorias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }//fim try
            catch (MySqlException e)
            {
                mensagem = "Erro: " + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }// fim lista_categorias
        public DataTable listaprodutos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaprodutos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }//fim try
            catch (MySqlException e)
            {
                mensagem = "Erro: " + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }/// fim lita produtos

        public bool deletaprodutos( int RemoveID)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeproduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("RemoveID", RemoveID);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); //executa o comando 
                return true;
            }//fim try
            catch (MySqlException e)
            {
                mensagem = "Erro: " + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim do remove
        public bool alteraproduto(Produtos P, int ProdutoID)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_alteraproduto", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", ProdutoID);
                cmd.Parameters.AddWithValue("nome", P.Nome1);
                cmd.Parameters.AddWithValue("preco", P.Preco1);
                cmd.Parameters.AddWithValue("categoria", P.Categoria1);
                cmd.ExecuteNonQuery(); // Executar Banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }

        } // fim do autera

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("sp_consultarlogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Usuario", user);
            cmd.Parameters.AddWithValue("Senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }



    }// fim da classe
}

