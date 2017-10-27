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

        private int nivel;

        DataTable dt = new DataTable();

        public F_usuario(DataTable login)
        {
            InitializeComponent();
            dt = login;
        }

        private void adicionar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //volta para o forme principal
            new F_principal(dt).Show();
            this.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
            TB_user.Text = dt.Rows[0]["usuario"].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {   
            //Mostra e abilita campos para alterar senha
            P_senha.Visible = true;
            P_senha.Enabled = true;
            P_senha.Location = new Point(12, 140);
            P_email.Visible = false;
            P_email.Enabled = false;
            P_email.Location = new Point(12, 330);
            P_add.Visible = false;
            P_add.Enabled = false;
            P_add.Location = new Point(12, 330);
        }

        private void B_email_Click(object sender, EventArgs e)
        {
            //Mostra e abilita campos para alterar email

            P_senha.Visible = false;
            P_senha.Enabled = false;
            P_senha.Location = new Point(12, 330);
            P_email.Visible = true;
            P_email.Enabled = true;
            P_email.Location = new Point(12, 140);
            P_add.Visible = false;
            P_add.Enabled = false;
            P_add.Location = new Point(12, 330);
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
            int c = 0;
            if (TB_usuario.Text != "")  c++;
            else MessageBox.Show("Campo usuario vazio\nDigite um usuario");
            if (MTB_senha.Text != "")   c++;
            else MessageBox.Show("Campo senha vazio\nDigite um senha");
            if (MTB_senha.Text == MTB_c_senha.Text)  c++; 
            else MessageBox.Show("Campo senha e confirmação de senha não conferem");
            if (RB_n_0.Checked == true || RB_n_1.Checked == true) c++;
            else MessageBox.Show("Selecione o nivel de usuario");
            if(cm.contador("SELECT COUNT(*) from user WHERE usuario = '" + TB_usuario.Text + "'") == 0) c++;
            else MessageBox.Show("Usuario já existe","Aviso");
            if(TB_email.Text == "") MessageBox.Show("Campo email vazio\nNão é obrigado digitar o email para cadastrar um usuario");
            if (c == 5) 
            {
                usuario = TB_usuario.Text;
                senha = MTB_senha.Text;
                email = TB_email.Text;
                if (RB_n_0.Checked == true) nivel = 0;
                if (RB_n_1.Checked == true) nivel = 1;
                string query = string.Format("insert into pinheiro_e_cruz.user(usuario,senha,email,usu_cre,nivel)values('{0}','{1}','{2}','{3}','{4}');", usuario, senha, email, dt.Rows[0]["usuario"].ToString(), nivel);
                cm.inserir(query);
                F_principal frm_principal = new F_principal(dt);
                frm_principal.Show();
                this.Visible = false;
            }
        }

        private void B_del_Click(object sender, EventArgs e)
        {
            conexao_mysql cm = new conexao_mysql();
            if (cm.contador("SELECT COUNT(*) from user WHERE usuario = '" + TB_user.Text + "'") > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar o usuario", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "delete from user where usuario = '" + TB_user.Text + "';";
                    cm.deletar(query);
                    F_principal frm_principal = new F_principal(dt);
                    frm_principal.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario não foi deletado", "Aviso");
                }
            }
            else 
            {
                MessageBox.Show("Usuario não encontrado","Aviso");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            conexao_mysql cm = new conexao_mysql();
            if (cm.contador("SELECT COUNT(*) from user WHERE usuario = '" + TB_user.Text + "'") > 0)
            {
                if (tb_t_email.Text == TB_t_cemail.Text)
                {
                    if (MessageBox.Show("Tem certeza que deseja trocar o email", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string query = "update user set email = '" + tb_t_email.Text + "' where usuario = '" + TB_user.Text + "';";
                        cm.atuaizar(query);
                        F_principal frm_principal = new F_principal(dt);
                        frm_principal.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("O email não foi alterado", "Aviso");
                    }
                }
                else
                {
                    MessageBox.Show("Os email não conferem", "Aviso");
                }  
            }
            else
            {
                MessageBox.Show("Usuario não encontrado", "Aviso");
            }
        }

        private void TB_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_add_Click(object sender, EventArgs e)
        {
            P_senha.Visible = false;
            P_senha.Enabled = false;
            P_senha.Location = new Point(12, 330);
            P_email.Visible = false;
            P_email.Enabled = false;
            P_email.Location = new Point(12, 330);
            P_add.Visible = true;
            P_add.Enabled = true;
            P_add.Location = new Point(12, 140);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conexao_mysql cm = new conexao_mysql();
            if (cm.contador("SELECT COUNT(*) from user WHERE usuario = '" + TB_user.Text + "'") > 0)
            {
                dt = cm.buscaseletiva("SELECT * from user WHERE usuario = '" + TB_user.Text + "'");
                if (dt.Rows[0][1].ToString() == TB_senha_atu.Text)
                {
                    if (TB_senha_nov.Text == TB_senha_cn.Text)
                    {
                        cm.atuaizar("update user set senha = '" + TB_senha_nov.Text + "' where usuario = '" + TB_user.Text + "';");
                    }
                    else 
                    {
                        MessageBox.Show("Senhas novas não conferem","Aviso");
                    }
                }
                else 
                {
                    MessageBox.Show("Senha atual incorreta","Aviso");
                }
            }
            else
            {
                MessageBox.Show("Usuario não encontrado", "Aviso");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
        }
    }
}
