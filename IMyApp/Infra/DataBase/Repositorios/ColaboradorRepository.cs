using DataBase.conexoes;
using Microsoft.Data.SqlClient;
using Negocio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositorios
{
    public class ColaboradorRepository
    {
        public bool inserir(Cargo colaborador) 
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

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@nome", colaborador.Nome);
                    cmd.Parameters.AddWithValue("@Status", colaborador.Status);
                    cmd.Parameters.AddWithValue("@CriadoEm", colaborador.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", colaborador.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoPor", colaborador.AlteradoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", colaborador.AlteradoEm);
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
    }
}
