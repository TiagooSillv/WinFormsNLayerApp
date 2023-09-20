using DataBase.conexoes;
using Microsoft.Data.SqlClient;
using Negocio.entidades;
using System.Data;

namespace Database.Repositorios
{
    /// <summary>
    /// <c> Cargo Repository </c> - Executa comandos SQL (CROUD) na tabela de [dbo].[Cargo]
    /// <exemple> Exemplo: 
    ///     var repositorio = new CargoRepository(); 
    /// </exemple>
    /// </summary>
    /// <returns></returns>
    /// 
    public class CargoRepository
    {
       /// <summary>
       /// Insere um novo rgistro na tabela Cargo
       /// <exemple>
       /// <code>
       /// 
       /// var cargoRepositorio = new cargo Repository();
       /// var cargo = new Cargo() ("Nome","Status","AlteradoEm","AlteradoPor");
       /// var resultado = cargoRepositorio.Inserir(cargo);
       /// 
       /// </code>
       /// </exemple>
       /// </summary>
       /// <param name="cargo"></param>
       /// <returns> True or False </returns>
        public bool Inserir(Cargo cargo)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Cargo]([Nome],[Status],[CriadoEm] ,[CriadoPor],[AlteradoPor],[AlteradoEm])

                    VALUES

                        (@Nome, @Status, @CriadoEm, @CriadoPor, @AlteradoPor,@AlteradoEm)"
                ;

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

                    connection.Close();
                    
                    return resposta == 1;


                }
            }
            catch (Exception)
            {
                throw;
            }
        } 
        public bool Atualizar(Cargo cargo, int id)
        {
            
            try
            {
                
                var sql = @"UPDATE [dbo].[Cargo]
                           SET [Nome] = @Nome
                              ,[Status] = @Status
                              ,[AlteradoEm] = @AlteradoEm
                              ,[AlteradoPor] = @AlteradoPor
                         WHERE Id = @id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@id", id);

                    var resposta = cmd.ExecuteNonQuery();

                    connection.Close() ;
                    return resposta == 1;
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
       
        public DataTable ObterTodos ()
        {
            var sql = @"SELECT [Id],[Nome],[Status], [AlteradoEm] FROM [dbo].[Cargo]";

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

                    connection.Close();
                    
                    return datatable;

                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
