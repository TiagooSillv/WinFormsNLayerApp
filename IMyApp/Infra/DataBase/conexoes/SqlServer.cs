using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.conexoes
{
    internal static class SqlServer
    {
        internal static string StrConexao()
        {
            return "Data Source=.\\SQLEXPRESS;Initial Catalog=IMyApp;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        }
        
    }
}
