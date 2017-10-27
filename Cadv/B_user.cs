using System;
using System.Data;
using Npgsql;

namespace PostgreSQL_CRUD
{
    public class B_user
    {
        static string serverName = "127.0.0.1";  //localhost
        static string port = "5432";             //porta default
        static string databaseName = "Pinheiro_e_cruz"; //nome do banco de dados
        static string userName = "postgres";     //nome do administrador
        static string password = "1903";     //senha do administrador
        NpgsqlConnection pgsqlConnection = null;
        string connString = null;

        public B_user()
        {
            connString = String.Format("Server={0};Port={1};Database={2};User Id={3};Password={4};", serverName, port, databaseName, userName, password);
            //connString = "Server=127.0.0.1;Port=5432;Database=Pinheiro_e_cruz;User Id=postgres;Password=1903;";
        }

        //Pega todos os registros
        public DataSet GetTodosRegistros()
        { 

            DataSet dt = new DataSet();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select * from pinheiro_e_cruz.user";
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
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


        //Pega um registro pelo codigo
        public DataTable GetRegistroPorId(int id)
        {

            DataTable dt = new DataTable();

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from funcionarios Where id = " + id;

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }                   
                }
            }
            catch (NpgsqlException ex)
            {
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
            return dt;
        }

        //Inserir registros
        public void InserirRegistros(string nome,string email, int idade)
        {
           
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();

                    string cmdInserir = String.Format("Insert Into funcionarios(nome,email,idade) values('{0}','{1}',{2})",nome,email,idade);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }                    
                }
            }
            catch (NpgsqlException ex)
            {
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
        }

        //Atualiza registros
        public void AtualizarRegistro(int codigo, string email, int idade)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();

                    string cmdAtualiza = String.Format("Update funcionarios Set email = '"  + email + "' , idade = " + idade + " Where id = " + codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
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
        }

        //Deleta registros
        public void DeletarRegistro(string nome)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("Delete From funcionarios Where nome = '{0}'",nome);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
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
        }
    }
}
