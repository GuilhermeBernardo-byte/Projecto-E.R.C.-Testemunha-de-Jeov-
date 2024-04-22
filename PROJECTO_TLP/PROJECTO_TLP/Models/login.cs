using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PROJECTO_TLP.Models
{
    public class login : Conector
    {
        public bool VerificarUsuario(string email, string senha)
        {
            bool usuarioExiste = false;
            try
            {
                abrirconexao();

                string query = "SELECT COUNT(*) FROM user WHERE email = @Email AND palavra_passe = @Senha";
                MySqlCommand comando = new MySqlCommand(query, connexao);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Senha", senha);

                int count = Convert.ToInt32(comando.ExecuteScalar());

                if (count > 0)
                    usuarioExiste = true;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Erro ao verificar usuário: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }

            return usuarioExiste;
        }
    }
}