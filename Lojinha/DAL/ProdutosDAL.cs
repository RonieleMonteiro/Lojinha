using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.Modelos;
using System.Data;
namespace Lojinha.DAL
{
    public class ProdutosDAL
    {

        public void Incluir(ProdutosInformation produtos)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insere_cliente";
                //Paramentros da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = produtos.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Value = produtos.Preco;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 100);
                ptelefone.Value = produtos.Estoque;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;


            }
            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados." + ex.Number);
            }
            catch
            {
                throw new Exception("Erro ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();

            }

        }
        public void Alterar(ClienteInformation produtos)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "alterar_produtos";
                //Paramentros da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = produtos.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.VarChar, 100);
                ppreco.Value = produtos.Preco;
                cmd.Parameters.Add(ppreco);

                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.VarChar, 100);
                pestoque.Value = produtos.Estoque;
                cmd.Parameters.Add(pestoque);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;

            }
            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados." + ex.Number);
            }
            catch
            {
                throw new Exception("Erro ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();

            }


        }


        public void Excluir(int codigo)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exluir_cliente";
                //Paramentros da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados." + ex.Number);
            }
            catch
            {
                throw new Exception("Erro ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();

            }



        }
        public DataTable Listagem(string filtro)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "lista_cliente";
                //Paramentros da Stored Procedure
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar, 100);
                pfiltro.Value = filtro;
                cmd.Parameters.Add(pfiltro);
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;


            }
            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados." + ex.Number);
            }
            catch
            {
                throw new Exception("Erro ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();

            }


        }

    }
}	
    }
}
