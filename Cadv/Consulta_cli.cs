using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadv
{
    public partial class F_consulta_cli : Form
    {
        DataTable dt_user = new DataTable();
        DataTable dt_cli = new DataTable();
        DataTable dt_ane = new DataTable();
        txt arquivo = new txt();

        public F_consulta_cli(DataTable login)
        {
            InitializeComponent();
            dt_user = login;
        }

        private void Consulta_cli_Load(object sender, EventArgs e)
        {
            conexao_mysql cm = new conexao_mysql();
            CB_cli.DataSource = cm.buscartodos("cliente", "nome");
            CB_cli.DisplayMember = "nome";
            CB_cli.ValueMember = "";
            CB_id.DataSource = cm.buscartodos("cliente", "id");
            CB_id.DisplayMember = "id";
            CB_id.ValueMember = "";
            SS_inf.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt_user.Rows[0]["usuario"].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SS_inf.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt_user.Rows[0]["usuario"].ToString();
        }

        private void B_pesquisa_Click(object sender, EventArgs e)
        {
            string q1 = "";
            string q2 = "";
            conexao_mysql cm = new conexao_mysql();
            if (RB_nome.Checked == true)
            {
                q1 = "SELECT COUNT(*) from cliente WHERE nome = '" + CB_cli.Text + "'";
                q2 = "SELECT * from cliente WHERE nome = '" + CB_cli.Text + "';";
            }
            else
            {
                if (RB_id.Checked == true)
                {
                    q1 = "SELECT COUNT(*) from cliente WHERE id = '" + CB_id.Text + "'";
                    q2 = "SELECT * from cliente WHERE id = '" + CB_id.Text + "';";
                }
                else
                {
                    MessageBox.Show("Selecione o tipo de busca primeiro", "Aviso");
                }
            }
            if (RB_id.Checked == true || RB_nome.Checked == true)
            {
                switch (cm.contador(q1))
                {
                    case 0:
                        MessageBox.Show("Cliente não encontrado", "Aviso");
                        break;
                    case 1:
                        dt_cli = cm.buscaseletiva(q2);
                        carregar_dados();
                        carregar_anexo();
                        this.tab_clientes.SelectedIndex = 1;
                        break;
                    default:
                        CB_cli.DataSource = CB_id.DataSource = cm.buscaseletiva(q2);
                        CB_cli.DisplayMember = "nome";
                        CB_cli.ValueMember = "";
                        CB_id.DisplayMember = "id";
                        CB_id.ValueMember = "";
                        break;
                }
            }
        }

        private void B_salvar_Click(object sender, EventArgs e)
        {
            if (TB_id.Text != "")
            {
                
                new F_edicao(dt_user,dt_cli).Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Nenhum client foi selecionado para fazer a edição","Aviso");
            }
        }

        private void carregar_dados()
        {
            TB_nome.Text = dt_cli.Rows[0]["nome"].ToString();
            TB_id.Text = dt_cli.Rows[0]["id"].ToString();
            TB_cpf.Text = dt_cli.Rows[0]["cpf"].ToString();
            TB_rg.Text = dt_cli.Rows[0]["rg"].ToString();
            TB_npai.Text = dt_cli.Rows[0]["nome_pai"].ToString();
            TB_nmae.Text = dt_cli.Rows[0]["nome_mae"].ToString();
            TB_pis.Text = dt_cli.Rows[0]["pis"].ToString();
            TB_ctps.Text = dt_cli.Rows[0]["ctps"].ToString();
            DT_nasc.Value = Convert.ToDateTime(dt_cli.Rows[0]["data_nas"].ToString());
            TB_civil.Text = dt_cli.Rows[0]["est_civil"].ToString();
            TB_endereco.Text = dt_cli.Rows[0]["endereco"].ToString();
            MTB_num.Text = dt_cli.Rows[0]["num"].ToString();
            TB_comp.Text = dt_cli.Rows[0]["comp"].ToString();
            TB_Bairro.Text = dt_cli.Rows[0]["bairro"].ToString();
            TB_localidade.Text = dt_cli.Rows[0]["localidade"].ToString();
            TB_distrito.Text = dt_cli.Rows[0]["distrito"].ToString();
            TB_cidade.Text = dt_cli.Rows[0]["cidade"].ToString();
            TB_cep.Text = dt_cli.Rows[0]["cep"].ToString();
            TB_tel_1.Text = dt_cli.Rows[0]["tel_1"].ToString();
            TB_tel_2.Text = dt_cli.Rows[0]["tel_2"].ToString();
            TB_email.Text = dt_cli.Rows[0]["email"].ToString();
            TB_v_causa.Text = dt_cli.Rows[0]["val_causa"].ToString();
            TB_v_hon.Text = dt_cli.Rows[0]["val_hon"].ToString();
            TB_rec.Text = dt_cli.Rows[0]["val_rec"].ToString();
            TB_proc.Text = dt_cli.Rows[0]["est_pro"].ToString();
            TB_adv.Text = dt_cli.Rows[0]["tip_adv"].ToString();
            TB_num_pro.Text = dt_cli.Rows[0]["num_pro"].ToString();
            TB_pasta.Text = dt_cli.Rows[0]["pasta_cli"].ToString();
            TB_pasta.Text = arquivo.lertxt("conf.txt",4) + TB_pasta.Text.Replace("-", @"\");
            TB_user.Text = dt_cli.Rows[0]["usu_cri"].ToString();
            TB_dat.Text = dt_cli.Rows[0]["dat_cri"].ToString();
        }

        private void B_p1_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 2;
        }

        private void B_p2_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 3;
        }

        private void B_p3_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 4;
        }

        private void B_p4_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 5;
        }

        private void B_p5_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 6;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new F_principal(dt_user).Show();
            this.Visible = false;
        }

        private void B_cancelar_Click(object sender, EventArgs e)
        {
            conexao_mysql cm = new conexao_mysql();
            if (MessageBox.Show("Tem certeza que deseja deletar o cliente", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cm.deletar("DELETE from cliente WHERE id = '" + TB_id.Text + "';");
                new F_principal(dt_user).Show();
                this.Visible = false;
            }
        }

        private void carregar_anexo()
        {
            txt arquivo = new txt();
            dt_ane.Columns.Add("Nome_arquivo", typeof(string));
            dt_ane.Columns.Add("Ind_Tipo", typeof(int));
            dt_ane.Columns.Add("Caminho_arquivo", typeof(string));
            string cam_txt = TB_pasta.Text;
            cam_txt += @"\" + TB_nome.Text + ".txt";
            int n_arq;
            if (arquivo.exi_txt(cam_txt))
            {
                int n_linhas = Convert.ToInt32(arquivo.lertxt(cam_txt, 0));
                for (n_arq = 1; n_arq <= 28; n_arq = n_arq + 3)
                {
                    if (n_arq <= (n_linhas * 3))
                    {
                        dt_ane.Rows.Add(arquivo.lertxt(cam_txt, (n_arq)) ,Convert.ToInt32(arquivo.lertxt(cam_txt, (n_arq + 1))) , arquivo.lertxt(cam_txt, (n_arq + 2)));
                    }
                    else
                    {
                        dt_ane.Rows.Add("Vazio", 0, "Vazio");
                    }
                }
            }
            else
            {
                for (n_arq = 1; n_arq <= 10; n_arq++)
                {
                    dt_ane.Rows.Add("Vazio", 0, "Vazio");
                }
                MessageBox.Show("Arquivo não encontrado", "Aviso");
            }
            IM_anexo_1.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[0]["Ind_Tipo"].ToString())];
            IM_anexo_2.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[1]["Ind_Tipo"].ToString())];
            IM_anexo_3.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[2]["Ind_Tipo"].ToString())];
            IM_anexo_4.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[3]["Ind_Tipo"].ToString())];
            IM_anexo_5.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[4]["Ind_Tipo"].ToString())];
            IM_anexo_6.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[5]["Ind_Tipo"].ToString())];
            IM_anexo_7.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[6]["Ind_Tipo"].ToString())];
            IM_anexo_8.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[7]["Ind_Tipo"].ToString())];
            IM_anexo_9.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[8]["Ind_Tipo"].ToString())];
            IM_anexo_10.Image = IL_anexo.Images[Convert.ToInt32(dt_ane.Rows[9]["Ind_Tipo"].ToString())];
            Lab_1.Text = dt_ane.Rows[0]["Nome_arquivo"].ToString();
            Lab_2.Text = dt_ane.Rows[1]["Nome_arquivo"].ToString();
            Lab_3.Text = dt_ane.Rows[2]["Nome_arquivo"].ToString();
            Lab_4.Text = dt_ane.Rows[3]["Nome_arquivo"].ToString();
            Lab_5.Text = dt_ane.Rows[4]["Nome_arquivo"].ToString();
            Lab_6.Text = dt_ane.Rows[5]["Nome_arquivo"].ToString();
            Lab_7.Text = dt_ane.Rows[6]["Nome_arquivo"].ToString();
            Lab_8.Text = dt_ane.Rows[7]["Nome_arquivo"].ToString();
            Lab_9.Text = dt_ane.Rows[8]["Nome_arquivo"].ToString();
            Lab_10.Text = dt_ane.Rows[9]["Nome_arquivo"].ToString();
        }

        private void IM_anexo_1_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[0]["Caminho_arquivo"].ToString() != "Vazio")
            {
                Process.Start(dt_ane.Rows[0]["Caminho_arquivo"].ToString());
            }
            else 
            {
                MessageBox.Show("Arquivo vazio","Aviso");
            }
        }

        private void IM_abrir_pasta_Click(object sender, EventArgs e)
        {
            if (TB_pasta.Text != "")
            {
                System.Diagnostics.Process.Start(TB_pasta.Text,"explorer.exe");
            }
            else MessageBox.Show("Cliente não contem pasta","Aviso");
        }

        private void IM_anexo_2_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[1]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[1]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_3_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[2]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[2]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_4_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[3]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[3]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_5_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[4]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[4]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_6_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[5]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[5]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_7_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[6]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[6]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_8_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[7]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[7]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_9_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[8]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[8]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_anexo_10_Click(object sender, EventArgs e)
        {
            if (dt_ane.Rows[9]["Caminho_arquivo"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_ane.Rows[9]["Caminho_arquivo"].ToString());
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }
    }
}

