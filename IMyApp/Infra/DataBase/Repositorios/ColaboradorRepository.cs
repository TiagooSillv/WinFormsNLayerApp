using DataBase.conexoes;
using Microsoft.Data.SqlClient;
using Negocio.comun;
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
        public bool inserir(Colaborador colaborador) 
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Colaborador]
                           ([Nome]
                           ,[Telefone]
                           ,[Nascimento]
                           ,[cpf]
                           ,[Rg]
                           ,[Genero]
                           ,[Departamento]
                           ,[Cargo]
                           ,[CriadoEm]
                           ,[CriadoPor]
                           ,[AlteradoEm]
                           ,[AlteradoPor]
                           ,[Status]
                           ,[EnderecoEstado]
                           ,[EnderecoCidade]
                           ,[EnderecoBairro]
                           ,[EnderecoRua]
                           ,[EnderecoNumero]
                           ,[Nacionalidade]
                           ,[EstadoCivil]
                           ,[DataAdmissao])
                     VALUES
                           (Nome,
                           Telefone,
                           Nascimento,
                           cpf,
                           Rg,
                           Genero,
                           Departamento,
                           Cargo,
                           CriadoEm,
                           CriadoPor,
                           AlteradoEm,
                           AlteradoPor,
                           Status,
                           EnderecoEstado,
                           EnderecoCidade,
                           EnderecoBairro,
                           EnderecoRua,
                           EnderecoNumero,
                           Nacionalidade,
                           EstadoCivil,
                           DataAdmissao)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nome", colaborador.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", colaborador.Telefone);
                    cmd.Parameters.AddWithValue("@Nascimento", colaborador.Nascimento);
                    cmd.Parameters.AddWithValue("@cpf", colaborador.Cpf);
                    cmd.Parameters.AddWithValue("@Rg", colaborador.Rg);
                    cmd.Parameters.AddWithValue("@Genero", colaborador.Genero);
                    cmd.Parameters.AddWithValue("@Departamento", colaborador.Departamento);
                    cmd.Parameters.AddWithValue("@Cargo", colaborador.Cargo);
                    cmd.Parameters.AddWithValue("@CriadoEm", colaborador.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", colaborador.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", colaborador.AlteradoEm);
                    cmd.Parameters.AddWithValue("@AlteradoPor", colaborador.AlteradoPor);
                    cmd.Parameters.AddWithValue("@Status", colaborador.Status);
                    cmd.Parameters.AddWithValue("@EnderecoEstado", colaborador.EnderecoEstado);
                    cmd.Parameters.AddWithValue("@EnderecoCidade", colaborador.EnderecoCidade);
                    cmd.Parameters.AddWithValue("@EnderecoBairro", colaborador.EnderecoBairro);
                    cmd.Parameters.AddWithValue("@EnderecoRua", colaborador.EnderecoRua);
                    cmd.Parameters.AddWithValue("@EnderecoNumero", colaborador.EnderecoNumero);
                    cmd.Parameters.AddWithValue("@EnderecoRua", colaborador.EnderecoRua);
                    cmd.Parameters.AddWithValue("@Nacionalidade", colaborador.Nacionalidade);
                    cmd.Parameters.AddWithValue("@EstadoCivil", colaborador.EstadoCivil);




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
