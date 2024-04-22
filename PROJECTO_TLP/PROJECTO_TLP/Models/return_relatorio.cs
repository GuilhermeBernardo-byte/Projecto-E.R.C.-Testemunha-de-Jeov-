using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PROJECTO_TLP.Models
{
    public class return_relatorio : Conector
    {
        public List<Relatorio> RecuperarRelatoriosPre(int idUsuario)
        {
            List<Relatorio> relatorios = new List<Relatorio>();

            try
            {
                abrirconexao();

                string query = @"SELECT data_relatorio, hora_relatorio, estudos FROM pre_relatorio WHERE id_user = @IdUsuario";
                MySqlCommand comando = new MySqlCommand(query, connexao);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Relatorio relatorio = new Relatorio();
                        relatorio.DataRelatorio = reader.GetDateTime("data_relatorio");
                        relatorio.HoraRelatorio = reader.GetTimeSpan("hora_relatorio");
                        relatorio.Estudos = reader.GetInt32("estudos");

                        relatorios.Add(relatorio);
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Erro ao recuperar relatórios prévios: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }

            return relatorios;
        }

        public List<Relatorio> RecuperarRelatoriosFinal(int idUsuario)
        {
            List<Relatorio> relatorios = new List<Relatorio>();

            try
            {
                abrirconexao();

                string query = @"SELECT data_relatorio, hora_relatorio, estudos FROM relatorio_final WHERE id_user = @IdUsuario";
                MySqlCommand cmd = new MySqlCommand(query, connexao);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Relatorio relatorio = new Relatorio();
                        relatorio.DataRelatorio = reader.GetDateTime("data_relatorio");
                        relatorio.HoraRelatorio = reader.GetTimeSpan("hora_relatorio");
                        relatorio.Estudos = reader.GetInt32("estudos");

                        relatorios.Add(relatorio);
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Erro ao recuperar relatórios finais: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }

            return relatorios;
        }
    }

    public class Relatorio
    {
        public DateTime DataRelatorio { get; set; }
        public TimeSpan HoraRelatorio { get; set; }
        public int Estudos { get; set; }
    }
}
