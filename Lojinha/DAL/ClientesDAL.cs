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
    public class ClientesDAL
    {
		public void Incluir (ClienteInformation cliente)
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
				pnome.Value = cliente.Nome;
				cmd.Parameters.Add(pnome);

				SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
				pemail.Value = cliente.Email;
				cmd.Parameters.Add(pemail);

				SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 100);
				ptelefone.Value = cliente.Telefone;
				cmd.Parameters.Add(ptelefone);

				cn.Open();
				cmd.ExecuteNonQuery();

				cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;


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
