using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PROJECTO_TLP.Models
{
    public class Conector
    {
        public static string connect { get; set; } = "server=127.0.0.1;database=uniao_tj;User Id=root;password=";
       public MySqlConnection connexao = new MySqlConnection(connect);

        public void abrirconexao()
        {
            try
            {
                connexao.Open();
            }
            catch (Exception e)
            {
                string erroabrir = e.ToString();
                throw;
            }

        }
        public void fecharconexao()
        {
            try
            {
                connexao.Close();
            }
            catch (Exception e)
            {
                string errofechar = e.ToString();
                throw;
            }
        }
    }
}