using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PROJECTO_TLP.Models
{
    public class give_relatorio : Conector
    {
        public bool InserirRelatorioPre(int idUsuario, DateTime dataRelatorio, TimeSpan horaRelatorio, int estudos)
        {
            try
            {
                abrirconexao();

                string query = @"INSERT INTO pre_relatorio (id_user, data_relatorio, hora_relatorio, estudos)
                                 VALUES (@IdUsuario, @DataRelatorio, @HoraRelatorio, @Estudos)";
                MySqlCommand comando = new MySqlCommand(query, connexao);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@DataRelatorio", dataRelatorio.Date);
                comando.Parameters.AddWithValue("@HoraRelatorio", horaRelatorio);
                comando.Parameters.AddWithValue("@Estudos", estudos);

                int linhas_afectadas = comando.ExecuteNonQuery();

                return linhas_afectadas > 0;
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("Erro ao inserir relatório prévio: " + ex.Message);
                return false;
            }
            finally
            {
                fecharconexao();
            }
        }

        public bool InserirRelatorioFinal(int idUsuario, DateTime dataRelatorio, TimeSpan horaRelatorio, int estudos)
        {
            try
            {
                abrirconexao();

                string query = @"INSERT INTO relatorio_final (id_user, data_relatorio, hora_relatorio, estudos)
                                 VALUES (@IdUsuario, @DataRelatorio, @HoraRelatorio, @Estudos)";
                MySqlCommand comandos = new MySqlCommand(query, connexao);
                comandos.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comandos.Parameters.AddWithValue("@DataRelatorio", dataRelatorio.Date);
                comandos.Parameters.AddWithValue("@HoraRelatorio", horaRelatorio);
                comandos.Parameters.AddWithValue("@Estudos", estudos);

                int linhas_afectadas = comandos.ExecuteNonQuery();

                return linhas_afectadas > 0;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Erro ao inserir relatório final: " + ex.Message);
                return false;
            }
            finally
            {
                fecharconexao();
            }
        }
    }
}