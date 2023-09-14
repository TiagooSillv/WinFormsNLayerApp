using DataBase.conexoes;
using Microsoft.Data.SqlClient;
using Negocio.entidades;
using System.Data;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public bool Inserir(Cargo cargo)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Cargo]
                  ([Nome]
                 ,[Status]
                 ,[CriadoEm]
                 ,[CriadoPor]
                 ,[AlteradoPor]
                 ,[AlteradoEm])
              VALUES
                 (@Nome,
                 @Status,
                 @CriadoEm, 
                 @CriadoPor,
                 @AlteradoPor,
                 @AlteradoEm)";

                using(var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@CriadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;

                    connection.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Atualizar(Cargo cargo)
        {
            
            try
            {
                
                var sql = @"UPDATE [dbo].[Cargo]
                           SET ([Nome]
                 ,[Status]
                 ,[CriadoEm]
                 ,[CriadoPor]
                 ,[AlteradoPor]
                 ,[AlteradoEm])
                    VALUES
                 (@Nome,
                 @Status,
                 @CriadoEm, 
                 @CriadoPor,
                 @AlteradoPor,
                 @AlteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                    connection.Close() ;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Deletar (Cargo cargo)
        {
            try
            {
                var sql = @"DELETE FROM [dbo].[Cargo]
                          WHERE ([Nome]
                         ,[Status]
                         ,[CriadoEm]
                         ,[CriadoPor]
                         ,[AlteradoPor]
                         ,[AlteradoEm])
                            VALUES
                         (@Nome,
                         @Status,
                         @CriadoEm, 
                         @CriadoPor,
                         @AlteradoPor,
                         @AlteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        public DataTable ObterTodos (Cargo cargo)
        {
            var sql = @"SELECT * FROM [dbo].[Cargo]";
            SqlDataAdapter dataAdapter = null;
            var datatable = new DataTable();

            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();

                    cmd.CommandText = sql;

                    dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                    dataAdapter.Fill(datatable);
                    return datatable;

                    connection.Close ();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
