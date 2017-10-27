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
    public partial class F_edicao : Form
    {
        DataTable dt_cli = new DataTable();

        DataTable dt_use = new DataTable();

        DataTable dt_ane = new DataTable();

        conexao_mysql cm = new conexao_mysql();

        txt arquivo = new txt();

        int num_lin_txt;

        private string query="",directorio,arq;

        public F_edicao(DataTable login,DataTable cliente)
        {
            InitializeComponent();
            dt_use = login;
            dt_cli = cliente;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void B_limpar_1_Click(object sender, EventArgs e)
        {
            TB_nome.Clear();
            MTB_id.Clear();
            MTB_cpf.Clear();
            TB_nmae.Clear();
            TB_npai.Clear();
            MTB_pis.Clear();
            MTB_ctps.Clear();
            MTB_rg.Clear();
            CB_civil.SelectedIndex = -1;
            CB_civil.Text = "Estado Civil";
            DT_nasc.Value = DateTime.Now.Date;
        }

        private void B_limpar_2_Click(object sender, EventArgs e)
        {
            TB_endereco.Clear();
            MTB_num.Clear();
            TB_comp.Clear();
            TB_Bairro.Clear();
            TB_localidade.Clear();
            TB_distrito.Clear();
            TB_cidade.Clear();
            MTB_cep.Clear();
        }

        private void B_limpar_3_Click(object sender, EventArgs e)
        {
            MTB_t1.Clear();
            MTB_t2.Clear();
            CB_ddd_t1.SelectedIndex = -1;
            CB_ddd_t2.SelectedIndex = -1;
            TB_email.Clear();
            CB_ser_email.SelectedIndex = -1;
            CB_ser_email.Text = "Selecionar servidor";
        }

        private void B_limpar_4_Click(object sender, EventArgs e)
        {
            CB_porc.SelectedIndex = -1;
            CB_porc.Text = "% a receber";
            CB_adv.SelectedIndex = -1;
            CB_adv.Text = "Tipo de Advogado";
            CB_proc.SelectedIndex = -1;
            CB_proc.Text = "Estado do processo";
            MTB_proc.Clear();
            MTB_vcausa.Clear();
            MTB_hon.Clear();
            MTB_rec.Clear();
        }

        private void B_s1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (TB_nome.Text != "") c++;
            else MessageBox.Show("Campo nome vazio", "Aviso");
            if (MTB_cpf.Text != "") c++;
            else MessageBox.Show("Campo cpf vazio","Aviso"); 
            if (MTB_rg.Text != "") c++;
            else MessageBox.Show("Campo rg vazio", "Aviso");
            if (DT_nasc.Value.Date != DateTime.Now.Date) c++;
            else MessageBox.Show("Campo data de nascimnto não selecionado", "Aviso");
            if (CB_civil.TabIndex != -1) c++;
            else MessageBox.Show("Campo estado civil não selecionado","Aviso");
            if(c == 5){
                query = "UPDATE cliente SET ";
                query += "nome = '" + TB_nome.Text + "',";
                query += "cpf = '" + MTB_cpf.Text + "',";
                query += "rg = '" + MTB_rg.Text + "',";
                query += "nome_pai = '" + TB_npai.Text + "',";
                query += "nome_mae = '" + TB_nmae.Text + "',";
                query += "pis = '" + MTB_pis.Text + "',";
                query += "ctps = '" + MTB_ctps.Text + "',";
                query += "data_nas = '" + Convert.ToString(DT_nasc.Value.Date) + "',";
                query += "est_civil = '" + CB_civil.Text + "',";
                query += "usu_cri = '" + dt_use.Rows[0]["usuario"].ToString() +"',";
                query += "dat_cri = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "' ";
                query += "WHERE id = '" + MTB_id.Text + "';";
                cm.atuaizar(query);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (RB_cidade.Checked == true) 
            {
                if (TB_endereco.Text != "") c++;
                else MessageBox.Show("Campo endereço vazio", "Aviso");
                if (MTB_num.Text != "") c++;
                else MessageBox.Show("Campo numero vazio","Aviso");
            }
            if (RB_interior.Checked == true) 
            {
                if (TB_localidade.Text != "") c++;
                else MessageBox.Show("Campo localidade vazio","Aviso");
                if (TB_distrito.Text != "") c++;
                else MessageBox.Show("Campo distrito vazio","Aviso");
            }
            if (TB_cidade.Text != "") c++;
            else MessageBox.Show("Campo cidade vazio", "Aviso");
            if (MTB_cep.Text != "") c++;
            else MessageBox.Show("Campo cep vazio", "Aviso");
            if(c == 4){
                query = "UPDATE cliente SET ";
                query += "endereco = '" + TB_endereco.Text + "',";
                query += "num = '" + MTB_num.Text + "',";
                query += "comp = '" + TB_comp.Text + "',";
                query += "bairro = '" + TB_Bairro.Text + "',";
                query += "localidade = '" + TB_localidade.Text + "',";
                query += "distrito = '" + TB_distrito.Text + "',";
                query += "cidade = '" + TB_cidade.Text + "',";
                query += "cep = '" + MTB_cep.Text + "',";
                query += "usu_cri = '" + dt_use.Rows[0]["usuario"].ToString() + "',";
                query += "dat_cri = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "' ";
                query += "WHERE id = '" + MTB_id.Text + "';";
                cm.atuaizar(query);
            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            int c = 0;
            if (CB_ddd_t1.SelectedIndex != -1) c++;
            else MessageBox.Show("DDD do 1° telefone não foi selecionado", "Aviso");
            if (MTB_t1.Text != "") c++;
            else MessageBox.Show("Campo do 1° telefone vazio", "Aviso");
            if (c == 2)
            {
                query = "UPDATE cliente SET ";
                query += "tel_1 ='(" + CB_ddd_t1.Text + ")" + MTB_t1.Text + "',";
                query += "tel_2 ='(" + CB_ddd_t2.Text + ")" + MTB_t2.Text + "',";
                query += "email ='" + TB_email.Text + "@" + CB_ser_email.Text + "',";
                query += "usu_cri = '" + dt_use.Rows[0]["usuario"].ToString() + "',";
                query += "dat_cri = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "' ";
                query += "WHERE id = '" + MTB_id.Text + "';";
                cm.atuaizar(query);
            }
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            int c = 0;
            if (CB_proc.SelectedIndex != -1) c++;
            else MessageBox.Show("Estado do processo não selecionado","Aviso");
            if (CB_adv.SelectedIndex != -1) c++;
            else MessageBox.Show("Tipo de advogado não selecionado","Aviso");
            if(c == 2){
                query = "UPDATE cliente SET ";
                query += "val_causa = '" + MTB_vcausa.Text + "',";
                query += "val_hon = '" + MTB_hon.Text + "',";
                query += "val_rec = '" + MTB_rec.Text + "',";
                query += "est_pro = '" + CB_proc.Text + "',";
                query += "tip_adv = '" + CB_adv.Text + "',";
                query += "num_pro = '" + MTB_proc.Text + "',";
                query += "usu_cri = '" + dt_use.Rows[0]["usuario"].ToString() + "',";
                query += "dat_cri = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "' ";
                query += "WHERE id = '" + MTB_id.Text + "';";
                cm.atuaizar(query);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 2;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 3;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 5;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new F_consulta_cli(dt_use).Show();
            this.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //string directorio;
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    string directorio = dirDialog.SelectedPath;
                    TB_pasta.Text = directorio;
                }
                else
                {
                    // Caso o utilizador tenha cancelado
                    MessageBox.Show("Deseja mesmo deixar o cliente sem pasta");
                }
            }
        }

        private void CB_ser_email_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (TB_nome.Text != "")
                {
                    txt arquivo = new txt();
                    TB_pasta.Text = TB_pasta.Text.Replace(arquivo.lertxt("conf.txt",4),"");
                    arquivo.criartxt(directorio + @"\" + TB_nome.Text + ".txt");
                    arquivo.instanciar(directorio + @"\" + TB_nome.Text + ".txt");
                    arquivo.escrevertxt(num_lin_txt.ToString());
                    for (int i = 0; i < num_lin_txt; i++)
                    {
                        arquivo.escrevertxt(dt_ane.Rows[i]["Nome_arquivo"].ToString());
                        arquivo.escrevertxt(dt_ane.Rows[i]["Ind_Tipo"].ToString());
                        arquivo.escrevertxt(dt_ane.Rows[i]["Caminho_arquivo"].ToString());
                    }
                    arquivo.fechartxt();
                }
            else 
            {
                MessageBox.Show("Não foi criado nenhum arquivo pois não foi selecionada nenhuma pasta","Aviso");
            }
             query = "UPDATE pinheiro_e_cruz.cliente SET "; 
             query += "pasta_cli = '" + TB_pasta.Text.Replace(@"\", "-") + "',";
             query += "usu_cri = '" + dt_use.Rows[0]["usuario"].ToString() + "',";
             query += "dat_cri = '" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "' ";
             query += "WHERE id = '" + MTB_id.Text + "';";
             cm.atuaizar(query);
        }

        private void F_edicao_Load(object sender, EventArgs e)
        {
            dt_ane.Columns.Add("Nome_arquivo", typeof(string));
            dt_ane.Columns.Add("Tipo_arquivo", typeof(string));
            dt_ane.Columns.Add("Ind_Tipo", typeof(int));
            dt_ane.Columns.Add("Caminho_arquivo", typeof(string));
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt_use.Rows[0]["usuario"].ToString();
            TB_nome.Text = dt_cli.Rows[0]["nome"].ToString();
            MTB_id.Text = dt_cli.Rows[0]["id"].ToString();
            MTB_cpf.Text = dt_cli.Rows[0]["cpf"].ToString();
            MTB_rg.Text = dt_cli.Rows[0]["rg"].ToString();
            TB_npai.Text = dt_cli.Rows[0]["nome_pai"].ToString();
            TB_nmae.Text = dt_cli.Rows[0]["nome_mae"].ToString();
            MTB_pis.Text = dt_cli.Rows[0]["pis"].ToString();
            MTB_ctps.Text = dt_cli.Rows[0]["ctps"].ToString();
            DT_nasc.Value = Convert.ToDateTime(dt_cli.Rows[0]["data_nas"].ToString());
            CB_civil.Text = dt_cli.Rows[0]["est_civil"].ToString();
            TB_endereco.Text = dt_cli.Rows[0]["endereco"].ToString();
            MTB_num.Text = dt_cli.Rows[0]["num"].ToString();
            TB_comp.Text = dt_cli.Rows[0]["comp"].ToString();
            TB_Bairro.Text = dt_cli.Rows[0]["bairro"].ToString();
            TB_localidade.Text = dt_cli.Rows[0]["localidade"].ToString();
            TB_distrito.Text = dt_cli.Rows[0]["distrito"].ToString();
            TB_cidade.Text = dt_cli.Rows[0]["cidade"].ToString();
            MTB_cep.Text = dt_cli.Rows[0]["cep"].ToString();
            MTB_vcausa.Text = dt_cli.Rows[0]["val_causa"].ToString();
            MTB_hon.Text = dt_cli.Rows[0]["val_hon"].ToString();
            MTB_rec.Text = dt_cli.Rows[0]["val_rec"].ToString();
            CB_proc.Text = dt_cli.Rows[0]["est_pro"].ToString();
            CB_adv.Text = dt_cli.Rows[0]["tip_adv"].ToString();
            MTB_proc.Text = dt_cli.Rows[0]["num_pro"].ToString();
            TB_pasta.Text = arquivo.lertxt("conf.txt",4) + dt_cli.Rows[0]["pasta_cli"].ToString();
            TB_pasta.Text = TB_pasta.Text.Replace("-", @"\");
            TB_pasta.Text = TB_pasta.Text.Replace("-", @"\");
            DG_anexo.DataSource = dt_ane;
        }

        private void B_arq_Click(object sender, EventArgs e)
        {
            if (TB_pasta.Text == arquivo.lertxt("conf.txt", 4))
            {
                directorio = arquivo.lertxt("conf.txt", 4) + @"\Servidor\Clientes";
            }
            else directorio = TB_pasta.Text;
            DG_anexo.DataSource = dt_ane;
            if (directorio != "")
            {
                OFD.InitialDirectory = directorio;
                if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    arq = OFD.FileName;
                }
            }
            else MessageBox.Show("Directorio não selecionado", "Aviso");
        }

        private void B_adc_Click(object sender, EventArgs e)
        {
            if (arq != "")
            {
                if (num_lin_txt < 10)
                {
                    if (TB_nane.Text != "")
                    {
                        if (RB_doc.Checked == true)
                        {
                            dt_ane.Rows.Add(TB_nane.Text, "Documentos", "1", arq);
                            num_lin_txt++;
                        }
                        else
                        {
                            if (RB_aud.Checked == true)
                            {
                                dt_ane.Rows.Add(TB_nane.Text, "Audio", "2", arq);
                                num_lin_txt++;
                            }
                            else
                            {
                                if (RB_ima.Checked == true)
                                {
                                    dt_ane.Rows.Add(TB_nane.Text, "Imagem", "3", arq);
                                    num_lin_txt++;
                                }
                                else
                                {
                                    if (RB_vid.Checked == true)
                                    {
                                        dt_ane.Rows.Add(TB_nane.Text, "Video", "4", arq);
                                        num_lin_txt++;
                                    }
                                    else MessageBox.Show("Tipo de arquivo não selecionado", "Aviso");
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Digite o nome do arquivo", "Aviso");
                }
                else MessageBox.Show("Maximo de arquivos foi alcançado", "Aviso");
            }
            else MessageBox.Show("Selecione o arquivo", "Aviso");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt_use.Rows[0]["usuario"].ToString();
        }

        private void B_pasta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                dirDialog.SelectedPath = string.Format(@"{0}\Servidor\Clientes",arquivo.lertxt("conf.txt",4));
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    directorio = dirDialog.SelectedPath;
                    TB_pasta.Text = directorio;
                }
                else
                {
                    // Caso o utilizador tenha cancelado
                    MessageBox.Show("Deseja mesmo deixar o cliente sem pasta");
                }
            }
        }

        private void RB_cidade_CheckedChanged(object sender, EventArgs e)
        {
            P_cidade.Enabled = true;
            P_camp.Enabled = false;
        }

        private void RB_interior_CheckedChanged(object sender, EventArgs e)
        {
            P_cidade.Enabled = false;
            P_camp.Enabled = true;
        }

        private void CB_porc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_porc.SelectedIndex)
            {
                case 0:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.05);
                    break;
                case 1:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.1);
                    break;
                case 2:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.15);
                    break;
                case 3:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.2);
                    break;
                case 4:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.25);
                    break;
                case 5:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.3);
                    break;
                case 6:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.35);
                    break;
                case 7:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.4);
                    break;
                case 8:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.45);
                    break;
                case 9:
                    MTB_hon.Text = Convert.ToString(Convert.ToDouble(MTB_vcausa.Text) * 0.5);
                    break;
            }
        }

        private void tab_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
