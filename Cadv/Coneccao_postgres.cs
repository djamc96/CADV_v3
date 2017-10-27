using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Cadv
{
    class Coneccao_postgres
    {
        static string serverName = "127.0.0.1";  //localhost
        static string port = "5432";             //porta default
        static string databaseName = "Pinheiro_e_cruz"; //nome do banco de dados
        static string userName = "postgres";     //nome do administrador
        static string password = "1903";     //senha do administrador
        NpgsqlConnection pgsqlConnection = null;
        string connString = null;
        public Coneccao_postgres()
        {
            connString = String.Format("Server={0};Port={1};Database={2};User Id={3};Password={4};", serverName, port, databaseName, userName, password);
            //connString = "Server=127.0.0.1;Port=5432;Database=Pinheiro_e_cruz;User Id=postgres;Password=1903;";
        }

        //Pega todos os registros
        public DataTable GetTodosRegistros()
        { 

            DataTable dt = new DataTable();

            try
            {
                //MessageBox.Show(connString);
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select * from user";
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                //MessageBox.Show(Npgsql);
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return (dt);
        }
    }
}
