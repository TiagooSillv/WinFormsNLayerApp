using Dapper;
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
    public class ProdutoRepository
    {
        public List <Produto> ObterRelatoriosEstoque()
        {
            var sql = @"SELECT  p.IDProduto as Codigo,
		                        p.NomeProduto  as Nome,
		                        p.PrecoUnitario as Preco,
		                        p.UnidadesEmEstoque as Estoque,
		                        c.NomeCategoria as Categoria
                        FROM Produtos p
                        INNER JOIN Categorias c
                        ON p.IDCategoria = c.IDCategoria
                        WHERE p.UnidadesEmEstoque > 0;";
            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var resultado = connection.Query<Produto>(sql);
                    return resultado.ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
