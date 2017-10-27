using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cadv
{
    class conexao_mysql
    {
        public MySqlConnection conexao;
        private string server;
        private string uid;
        private string database;
        private string password;
        txt arquivos = new txt();

        private void criar_string_conexao()
        {
            server = arquivos.lertxt("conf.txt", 0);
            uid = arquivos.lertxt("conf.txt", 1);
            database = arquivos.lertxt("conf.txt", 2);
            password = arquivos.lertxt("conf.txt", 3);
            string conexaoString;
            conexaoString = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + password + ";";
            conexao = new MySqlConnection(conexaoString);
        }

        public bool abrirconexao()
        {
            this.criar_string_conexao();
            try
            {

                conexao.Open();
                return true;
            }
            
            catch (MySqlException ex)
            {
                

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível se conectar no banco de dados\nVerifique o servidor ou entre em contato com o administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Usuário e/ou senha inválido, por favor tente novamente");
                        break;
                }
                return false;
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show(x.Message);
                return false;
            }
        }

        private bool fecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable buscartodos(string tabela,string ordem) 
        {
            string query = "select * from " + tabela + " order by '" + ordem + "';";
            DataTable dt = new DataTable();
            if (this.abrirconexao() == true) 
            {
                MySqlDataAdapter ca = new MySqlDataAdapter(query,conexao);
                ca.Fill(dt);

                this.fecharConexao();

            }
            return dt;
        }

        public DataTable buscaseletiva(string query) 
        {
            DataTable dt = new DataTable();
            if (this.abrirconexao() == true)
            {
                MySqlDataAdapter ca = new MySqlDataAdapter(query, conexao);
                ca.Fill(dt);

                this.fecharConexao();

            }
            return dt;
        }

        public void inserir(string query) 
        {
            if (this.abrirconexao() == true)
            {
                MySqlCommand ca = new MySqlCommand(query, conexao);
                try
                {
                    ca.ExecuteNonQuery();
                }
                catch (MySqlException ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                this.fecharConexao();
                MessageBox.Show("Dados salvo com sucesso");

            }
        }

        public void deletar(string query)   
        {
            MySqlCommand ca = new MySqlCommand();
            if (this.abrirconexao() == true)
            {
                try
                {
                    ca.CommandText = query;
                    ca.Connection = conexao;
                    ca.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.fecharConexao();
                MessageBox.Show("Dados deletado com sucesso");
            }
        }

        public void atuaizar(string query)
        {
            if (this.abrirconexao() == true)
            {
                MySqlCommand ca = new MySqlCommand();
                try
                {
                    ca.CommandText = query;
                    ca.Connection = conexao;
                    ca.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.fecharConexao();
                MessageBox.Show("Dados salvo com sucesso");

            }
        }

        public int contador(string query)
        {
            Int32 cont=0;
            if (this.abrirconexao() == true)
            { 
                MySqlCommand ca = new MySqlCommand();
                try
                {
                    ca.CommandText = query;
                    ca.Connection = conexao;
                    cont = Convert.ToInt32(ca.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.fecharConexao();
            }
            return cont;
        }
    }
}
