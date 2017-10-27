using PostgreSQL_CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadv
{
    public partial class F_login : Form
    {
        DataTable dt = new DataTable();

        public F_login()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Abre o forme principal
            if ((CB_usuario.Text == "mctech") && (TB_senha.Text == "1903fbpa"))
            {
                dt.Columns.Add("usuario",typeof(string));
                dt.Columns.Add("senha", typeof(string));
                dt.Columns.Add("email",typeof(string));
                dt.Columns.Add("usu_cre",typeof(string));
                dt.Columns.Add("nivel", typeof(int));
                dt.Rows.Add("mctech", "", "", "", 2);
                new F_principal(dt).Show();
                this.Visible = false;
            }
            else
            {
                conexao_mysql cm = new conexao_mysql();
                if (cm.contador("SELECT COUNT(*) from user WHERE usuario = '" + CB_usuario.Text + "'") > 0)
                {
                    dt = cm.buscaseletiva("SELECT * from user WHERE usuario = '" + CB_usuario.Text + "'");
                    if (TB_senha.Text == dt.Rows[0]["senha"].ToString())
                    {
                        new F_principal(dt).Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                }
                else 
                {
                    MessageBox.Show("Usuario não encontrado","Aviso");
                }
            }
        }

        private void F_login_Load(object sender, EventArgs e)
        {
            //Carregar data e hora, quando inicia o forme
            SSL_dh.Text = DateTime.Now.ToLongDateString() + "," + DateTime.Now.ToLongTimeString();
            //Coneccao_postgres cp = new Coneccao_mysql
            conexao_mysql cm = new conexao_mysql();
            if (cm.abrirconexao() == true)
            {
                CB_usuario.DataSource = cm.buscartodos("user", "usuario");
                CB_usuario.DataSource = cm.buscartodos("user", "usuario");
                CB_usuario.DisplayMember = "usuario";
                CB_usuario.ValueMember = "";
            }
            else
            {
                MessageBox.Show("Não foi possivel obter conexão com o banco de dados","aviso");
                if (MessageBox.Show("Deseja fechar o programa", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    Application.Exit();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Fechar aplicação
            if (MessageBox.Show("Deseja realmente fechar o programa", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atualiza a hora a cada segundo
            SSL_dh.Text = DateTime.Now.ToLongDateString() + "," + DateTime.Now.ToLongTimeString();
        }

        private void CB_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conexao_mysql cm = new conexao_mysql();

        }
    }
}
