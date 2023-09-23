using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.conexoes
{
    /// <summary>
    /// A <c>SqlServer</c> é uma classe estatica coma string de connexão com o SqlServer
    /// </summary>
    internal static class SqlServer
    {
        /// <summary>
        /// Metodo que <c> StrConexao() </c> retorna a string de connexão sql
        /// </summary>
        /// <returns> string: ConnectionString </returns>
        internal static string StrConexao()
        {
            return "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        }


    }
}
