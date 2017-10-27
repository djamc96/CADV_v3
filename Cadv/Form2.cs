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
    public partial class F_principal : Form
    {
        DataTable dt = new DataTable();
        DataTable dt_ane = new DataTable();
        conexao_mysql cm = new conexao_mysql();
        txt arquivo = new txt();
        public F_principal(DataTable login)
        {
            InitializeComponent();
            dt = login;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void F_principal_Load(object sender, EventArgs e)
        {
            dt_ane.Columns.Add("Nome_modelo",typeof(string));
            dt_ane.Columns.Add("Tipo_modelo", typeof(int));
            dt_ane.Columns.Add("Caminho_modelo", typeof(string));
            carrega_modelos_rec();
            SSL_DH.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Volta para o forme login
            if (MessageBox.Show("Deseja realmentente sair", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                F_login frm_login = new F_login();
                frm_login.Show();
                this.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Abre a calculadora
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("calc.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Abre o excel
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("excel.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Abre o power point
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("powerpnt.exe");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Abre o word
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("winword.exe");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Abre o google no navegador padrão
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("https://www.google.com.br/?gws_rd=cr,ssl&ei=HPCBWfKuJ4rBwAST4rLgBg");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //Abre o trt4 no navegador principal
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("http://www.trt4.jus.br/portal/portal/trt4/consultas/consulta_lista/MenuWindow?action=2");
        }

        private void timer_hd_Tick(object sender, EventArgs e)
        {
            //Atualiza a hora a cada segundo
            SSL_DH.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
        }

        private void B_cadastro_Click(object sender, EventArgs e)
        {
            //Abre o forme de cadastro de clientes
            if (cm.abrirconexao() == true)
            {
                new F_Cadastro_clientes(dt).Show();
                this.Visible = false;
            }
            else MessageBox.Show("Não é possivel acessar a pagina consulta de clientes pois não há conexão com servidor", "Aviso");
        }

        private void B_usuarios_Click(object sender, EventArgs e)
        {
            //Abre o forme de usuarios pra usuario 1 e 2
            if (Convert.ToInt32(dt.Rows[0]["nivel"].ToString()) > 0)
            {
                if (cm.abrirconexao() == true)
                {
                    new F_usuario(dt).Show();
                    this.Visible = false;
                }
                else MessageBox.Show("Não é possivel acessar a pagina consulta de clientes pois não há conexão com servidor", "Aviso");
            }
            else
            {
                MessageBox.Show("Usuario não tem permissão de acesso", "Aviso");
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //Minimizar o programa
            this.WindowState = FormWindowState.Minimized;
        }

        private void B_configura_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dt.Rows[0]["nivel"].ToString()) == 2)
            {
                new F_configuracoes(dt).Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario não tem permissão para acessar","Aviso");
            }
        }

        private void B_consulta_Click(object sender, EventArgs e)
        {

            if (cm.abrirconexao() == true)
            {
                new F_consulta_cli(dt).Show();
                this.Visible = false;
            }
            else MessageBox.Show("Não é possivel acessar a pagina consulta de clientes pois não há conexão com servidor","Aviso");
        }

        private void B_financiaro_Click(object sender, EventArgs e)
        {
            new F_financeiro(dt).Show();
            this.Visible = false;
        }

        private void L_rec_1_Click(object sender, EventArgs e)
        {

        }

        private void carrega_modelos_rec()
        {
            if (arquivo.exi_txt("modelo_rec.txt"))
            {
                for (int i = 0; i < 21; i = i + 3)
                {
                        dt_ane.Rows.Add(arquivo.lertxt("modelo_rec.txt", i), Convert.ToInt32(arquivo.lertxt("modelo_rec.txt", (i + 1))), arquivo.lertxt("modelo_rec.txt", (i + 2)));
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    dt_ane.Rows.Add("Vazio", 0, "Vazio");
                }
                MessageBox.Show("Arquivo não encontrado", "Aviso");
            }
            pic_lab_atu();

        }

        private void pic_lab_atu()
        {
            IM_rec_1.Image = IL_rec.Images[Convert.ToInt32(dt_ane.Rows[6]["Tipo_modelo"].ToString())];
            IM_rec_2.Image = IL_rec.Images[Convert.ToInt32(dt_ane.Rows[5]["Tipo_modelo"].ToString())];
            IM_rec_3.Image = IL_rec.Images[Convert.ToInt32(dt_ane.Rows[4]["Tipo_modelo"].ToString())];
            IM_rec_4.Image = IL_rec.Images[Convert.ToInt32(dt_ane.Rows[3]["Tipo_modelo"].ToString())];
            IM_rec_5.Image = IL_rec.Images[Convert.ToInt32(dt_ane.Rows[2]["Tipo_modelo"].ToString())];
            IM_rec_6.Image = IL_rec.Images[Convert.ToInt32(dt_ane.Rows[1]["Tipo_modelo"].ToString())];
            IM_rec_7.Image = IL_rec.Images[Convert.ToInt32(dt_ane.Rows[0]["Tipo_modelo"].ToString())];
            L_rec_1.Text = dt_ane.Rows[6]["Nome_modelo"].ToString();
            L_rec_2.Text = dt_ane.Rows[5]["Nome_modelo"].ToString();
            L_rec_3.Text = dt_ane.Rows[4]["Nome_modelo"].ToString();
            L_rec_4.Text = dt_ane.Rows[3]["Nome_modelo"].ToString();
            L_rec_5.Text = dt_ane.Rows[2]["Nome_modelo"].ToString();
            L_rec_6.Text = dt_ane.Rows[1]["Nome_modelo"].ToString();
            L_rec_7.Text = dt_ane.Rows[0]["Nome_modelo"].ToString();
        }

        private void atu_txt()
        {
            arquivo.criartxt("modelo_rec.txt");
            arquivo.instanciar("modelo_rec.txt");
            for (int i = 0; i < 7; i++)
            {
                arquivo.escrevertxt(dt_ane.Rows[i]["Nome_modelo"].ToString());
                arquivo.escrevertxt(dt_ane.Rows[i]["Tipo_modelo"].ToString());
                arquivo.escrevertxt(dt_ane.Rows[i]["Caminho_modelo"].ToString());
            }
            arquivo.fechartxt();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new F_Modelos(dt).Show();
            this.Visible = false;
        }

        private void IM_rec_1_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[6]["Caminho_modelo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[6]["Caminho_modelo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_rec_2_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[5]["Caminho_modelo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[5]["Caminho_modelo"].ToString());
                dt_ane.Rows.Add(dt_ane.Rows[5]["Nome_modelo"].ToString(), Convert.ToInt32(dt_ane.Rows[5]["Tipo_modelo"].ToString()), dt_ane.Rows[5]["Caminho_modelo"].ToString());
                dt_ane.Rows[5].Delete();
                pic_lab_atu();
                atu_txt();
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_rec_3_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[4]["Caminho_modelo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[4]["Caminho_modelo"].ToString());
                dt_ane.Rows.Add(dt_ane.Rows[4]["Nome_modelo"].ToString(), Convert.ToInt32(dt_ane.Rows[4]["Tipo_modelo"].ToString()), dt_ane.Rows[4]["Caminho_modelo"].ToString());
                dt_ane.Rows[4].Delete();
                pic_lab_atu();
                atu_txt();
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_rec_4_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[3]["Caminho_modelo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[3]["Caminho_modelo"].ToString());
                dt_ane.Rows.Add(dt_ane.Rows[3]["Nome_modelo"].ToString(), Convert.ToInt32(dt_ane.Rows[3]["Tipo_modelo"].ToString()), dt_ane.Rows[3]["Caminho_modelo"].ToString());
                dt_ane.Rows[3].Delete();
                pic_lab_atu();
                atu_txt();
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_rec_5_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[2]["Caminho_modelo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[4]["Caminho_modelo"].ToString());
                dt_ane.Rows.Add(dt_ane.Rows[2]["Nome_modelo"].ToString(), Convert.ToInt32(dt_ane.Rows[2]["Tipo_modelo"].ToString()), dt_ane.Rows[2]["Caminho_modelo"].ToString());
                dt_ane.Rows[2].Delete();
                pic_lab_atu();
                atu_txt();
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_rec_6_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[1]["Caminho_modelo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[1]["Caminho_modelo"].ToString());
                dt_ane.Rows.Add(dt_ane.Rows[1]["Nome_modelo"].ToString(), Convert.ToInt32(dt_ane.Rows[1]["Tipo_modelo"].ToString()), dt_ane.Rows[1]["Caminho_modelo"].ToString());
                dt_ane.Rows[1].Delete();
                pic_lab_atu();
                atu_txt();
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_rec_7_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[0]["Caminho_modelo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[4]["Caminho_modelo"].ToString());
                dt_ane.Rows.Add(dt_ane.Rows[0]["Nome_modelo"].ToString(), Convert.ToInt32(dt_ane.Rows[0]["Tipo_modelo"].ToString()), dt_ane.Rows[0]["Caminho_modelo"].ToString());
                dt_ane.Rows[0].Delete();
                pic_lab_atu();
                atu_txt();
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("https://www.tjrs.jus.br/ppe/signin");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("https://www2.trf4.jus.br/trf4/");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("http://www.tjrs.jus.br/busca/?tb=proc");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1507905738&rver=6.7.6643.0&wp=MBI_SSL_SHARED&wreply=https:%2F%2Fmail.live.com%2Fdefault.aspx%3Frru%3Dinbox&lc=1046&id=64855&mkt=pt-br&cbcxt=mai");
        }

    }
}
