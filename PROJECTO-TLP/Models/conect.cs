using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PROJECTO_TLP.Models
{
    public class conect
    {
        static string conector = "server=127.0.0.1;database=Uniao_TJ;User Id=root;password=";
        MySqlConnection connexao = new MySqlConnection(conector);
        
        public void abrirConexao()
        {
            connexao.Open();
        }
        public void fecharConexao()
        {
            connexao.Close();
        }
    }
}