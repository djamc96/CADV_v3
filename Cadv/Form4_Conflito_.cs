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
    public partial class F_usuario : Form
    {
        private string usuario;
        private string senha;
        private string email;
        private string criacao;
        private int nivel;
        DataTable dt = new DataTable();
        public F_usuario()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //volta para o forme principal
            F_principal frm_principal = new F_principal();
            frm_principal.Show();
            this.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conexao_mysql cm = new conexao_mysql();
            CB_us.DataSource = cm.buscartodos("user");
            CB_us.DisplayMember = "usuario";
            CB_us.ValueMember = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {   
            //Mostra e abilita campos para alterar senha
            P_senha.Visible = true;
            P_senha.Location = new Point(21, 135);
            P_email.Visible = false;
            P_email.Location = new Point(21, 350);
        }

        private void B_email_Click(object sender, EventArgs e)
        {
            //Mostra e abilita campos para alterar email
            P_senha.Visible = false;
            P_senha.Location = new Point(21, 350);
            P_email.Visible = true;
            P_email.Location = new Point(21, 135);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Limpar campos
            TB_usuario.Clear();
            TB_email.Clear();
            MTB_c_senha.Clear();
            MTB_senha.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Minimizar o programa
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            conexao_mysql cm = new conexao_mysql();
            dt = cm.buscartodos("user");
            int c = 0,i=0;
            if (TB_usuario.Text != "")  c++;
            else MessageBox.Show("Campo usuario vazio\nDigite um usuario");
            if (MTB_senha.Text != "")   c++;
            else MessageBox.Show("Campo senha vazio\nDigite um senha");
            if (MTB_senha.Text == MTB_c_senha.Text)  c++; 
            else MessageBox.Show("Campo senha e confirmação de senha não conferem");
            if (RB_n_0.Checked == true || RB_n_1.Checked == true) c++;
            else MessageBox.Show("Selecione o nivel de usuario");
            if(TB_email.Text == "") MessageBox.Show("Campo email vazio\nNão é obrigado digitar o email para cadastrar um usuario");
            if (c == 4) 
            {
                //DataRow[] result = dt.Select("{1} == usuario", TB_usuario.Text);
                //MessageBox.Show(Convert.ToString(result));
                if (i == 0)
                {
                    usuario = TB_usuario.Text;
                    senha = MTB_senha.Text;
                    email = TB_email.Text;
                    criacao = "";
                    if (RB_n_0.Checked == true) nivel = 0;
                    if (RB_n_1.Checked == true) nivel = 1;
                    string query = string.Format("insert into pinheiro_e_cruz.user(usuario,senha,email,us_cre,nivel)values('{0}','{1}','{2}','{3}','{4}');", usuario, senha, email, criacao, nivel);
                    cm.inserir(query);
                }
                else MessageBox.Show("Usuario já existe");
            }
        }

        private void B_del_Click(object sender, EventArgs e)
        {
            string query = "delete from user where usuario = '" + CB_us.Text +"';";
            conexao_mysql cm = new conexao_mysql();
            cm.deletar(query);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (tb_t_email.Text == TB_t_cemail.Text)
            {
                if (MessageBox.Show("Tem certeza que deseja trocar o email", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = string.Format("UPDATE user SET email = '{0}' WHERE usuario = '{1}';",TB_email.Text,CB_us.Text);
                    conexao_mysql cm = new conexao_mysql();
                    cm.atuaizar(query);
                }
                else 
                {
                    MessageBox.Show("O email não foi alterado","Aviso");
                }
            }
            else 
            {
                MessageBox.Show("Os email não conferem","Aviso");
            }
        }
    }
}
