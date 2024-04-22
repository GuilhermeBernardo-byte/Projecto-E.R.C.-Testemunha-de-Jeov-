using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PROJECTO_TLP.Models
{
    public class cadastrar : Conector
    {
        public bool CadastrarUsuario(string nome, string email, string senha, string tipoUsuario, int idCategoria, int idServico, int idGrupo)
        {
            try
            {
                abrirconexao();

                string query = @"INSERT INTO user (nome, email, palavra_passe, user_tipo, id_categoria, id_servico, id_grupo)
                                 VALUES (@Nome, @Email, @Senha, @TipoUsuario, @IdCategoria, @IdServico, @IdGrupo)";
                MySqlCommand comando = new MySqlCommand(query, connexao);
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Senha", senha);
                comando.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                comando.Parameters.AddWithValue("@IdCategoria", idCategoria);
                comando.Parameters.AddWithValue("@IdServico", idServico);
                comando.Parameters.AddWithValue("@IdGrupo", idGrupo);

                int linhas_afectadas = comando.ExecuteNonQuery();

                return linhas_afectadas > 0;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Erro ao cadastrar usuário: " + ex.Message);
                return false;
            }
            finally
            {
                fecharconexao();
            }
        }
    }
}