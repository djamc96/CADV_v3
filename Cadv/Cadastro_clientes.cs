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
    public partial class F_Cadastro_clientes : Form
    {
        conexao_mysql cm = new conexao_mysql();

        DataTable dt = new DataTable();

        DataTable anexo = new DataTable();

        txt arq = new txt();
        
        public string query;

        string arquivo = "";
        
        private string email;

        string directorio = "";

        int num_lin_txt = 0;

        public F_Cadastro_clientes(DataTable login)
        {
            InitializeComponent();
            dt = login;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //string directorio;
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                dirDialog.SelectedPath = arq.lertxt("conf.txt", 4) + @"Servidor\Clientes";
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar o a inserção", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                new F_principal(dt).Show();
                this.Visible = false;
            }       
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja limpar todos campos", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TB_nome.Clear();
                MTB_cpf.Clear();
                MTB_rg.Clear();
                TB_npai.Clear();
                TB_nmae.Clear();
                MTB_pis.Clear();
                MTB_ctps.Clear();
                CB_civil.SelectedIndex = -1;
                CB_civil.Text = "Estado Civil";
                DT_nasc.Value = DateTime.Now.Date;
                TB_endereco.Clear();
                MTB_num.Clear();
                TB_comp.Clear();
                TB_Bairro.Clear();
                TB_localidade.Clear();
                TB_distrito.Clear();
                TB_cidade.Clear();
                MTB_cep.Clear();
                CB_ddd_t1.SelectedIndex = -1;
                CB_ddd_t1.Text = "";
                CB_ddd_t2.SelectedIndex = -1;
                CB_ddd_t2.Text = "";
                MTB_t1.Clear();
                MTB_t2.Clear();
                CB_ser_email.SelectedIndex = -1;
                CB_ser_email.Text = "Selecionar servidor";
                TB_email.Clear();
                MTB_vcausa.Clear();
                MTB_hon.Clear();
                CB_porc.SelectedIndex = -1;
                CB_porc.Text = "% a receber";
                CB_proc.SelectedIndex = -1;
                CB_proc.Text = "Estado do processo";
                CB_adv.SelectedIndex = -1;
                CB_adv.Text = "Tipo de advogado";
                MTB_proc.Clear();
                TB_pasta.Clear();
                MessageBox.Show("Todos campos foram limpados com sucesso", "Aviso");
            }
            else 
            {
                MessageBox.Show("Os campos não foram limpados", "Aviso");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new F_principal(dt).Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void B_s1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (TB_nome.Text != "") c++;
            else MessageBox.Show("Campo nome vazio", "Aviso");
            if (MTB_id.Text != "") c++;
            else MessageBox.Show("Campo id vazio", "Aviso");
            if (MTB_cpf.Text != "") c++;
            else MessageBox.Show("Campo cpf vazio","Aviso"); 
            if (MTB_rg.Text != "") c++;
            else MessageBox.Show("Campo rg vazio", "Aviso");
            if (DT_nasc.Value.Date != DateTime.Now.Date) c++;
            else MessageBox.Show("Campo data de nascimnto não selecionado", "Aviso");
            if (CB_civil.TabIndex != -1) c++;
            else MessageBox.Show("Campo estado civil não selecionado","Aviso");
            if (cm.contador("Select count(*) from cliente where id = " + Convert.ToInt32(MTB_id.Text)) == 0) c++;
            else MessageBox.Show("Numero de id já existente", "Aviso");
            if (c == 7) 
            {
                if (TB_npai.Text == "") RTB_branco.Text += "Campo nome da pai vazio\n";
                if (TB_nmae.Text == "") RTB_branco.Text += "Campo nome da mãe vazio\n";
                if (MTB_pis.Text == "") RTB_branco.Text += "Campo PIS/PASEP vazio\n";
                if (MTB_ctps.Text == "") RTB_branco.Text += "Campo CTPS vazio\n";
                this.tab_clientes.SelectedIndex = 1;                
            }
            
        }

        private void B_s2_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (RB_cidade.Checked == true) 
            {
                if (TB_endereco.Text != "") c++;
                else MessageBox.Show("Campo endereço vazio", "Aviso");
                if (MTB_num.Text != "") c++;
                else MessageBox.Show("Campo numero vazio","Aviso");
                if (TB_comp.Text == "") RTB_branco.Text += "Campo complemento vazio\n";
                if (TB_Bairro.Text == "") RTB_branco.Text += "Campo bairro vazio\n";
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
            
            if (c == 4)
            {
                if (RB_cidade.Checked == true) 
                {
                    if (TB_comp.Text == "") RTB_branco.Text += "Campo complemento vazio\n";
                    if (TB_Bairro.Text == "") RTB_branco.Text += "Campo bairro vazio\n";
                }
                this.tab_clientes.SelectedIndex = 2;
            }
        }

        private void B_s3_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (CB_ddd_t1.SelectedIndex != -1) c++;
            else MessageBox.Show("DDD do 1° telefone não foi selecionado","Aviso");
            if (MTB_t1.Text != "") c++;
            else MessageBox.Show("Campo do 1° telefone vazio","Aviso");
            if (c == 2)
            {
                if (CB_ddd_t2.SelectedIndex == -1) RTB_branco.Text += "DDD do 2° telefone não selecionado\n";
                if (MTB_t2.Text == "") RTB_branco.Text += "Campo do 2° telefone vazio\n";
                if (TB_email.Text == "") RTB_branco.Text += "campo email vazio\n";
                if (CB_ser_email.SelectedIndex == -1) RTB_branco.Text += "Servidor de email não selecionado\n";
                email = string.Format("{0}@{1}",TB_email.Text,CB_ser_email.Text);
                this.tab_clientes.SelectedIndex = 3;
            }
        }

        private void B_s4_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (CB_proc.SelectedIndex != -1) c++;
            else MessageBox.Show("Estado do processo não selecionado","Aviso");
            if (CB_adv.SelectedIndex != -1) c++;
            else MessageBox.Show("Tipo de advogado não selecionado","Aviso");
            if (c == 2)
            {
                if (MTB_vcausa.Text == "") RTB_branco.Text += "Campo valor da causa vazio\n";
                if (MTB_hon.Text == "") RTB_branco.Text += "Campo valor dos honorarios vazio\n";
                if (MTB_proc.Text == "") RTB_branco.Text += "Campo numero do processo vazio\n";
                this.tab_clientes.SelectedIndex = 4;
            }
        }
        
        private void B_s5_Click(object sender, EventArgs e)
        {
            if (TB_pasta.Text != "")
            {
                if (TB_nome.Text != "")
                {
                    txt arquivo = new txt();
                    arquivo.criartxt(directorio + @"\" + TB_nome.Text + ".txt");
                    arquivo.instanciar(directorio + @"\" + TB_nome.Text + ".txt");
                    arquivo.escrevertxt(num_lin_txt.ToString());
                    for (int i = 0; i < num_lin_txt; i++)
                    {
                        arquivo.escrevertxt(anexo.Rows[i]["Nome_arquivo"].ToString());
                        arquivo.escrevertxt(anexo.Rows[i]["Ind_Tipo"].ToString());
                        arquivo.escrevertxt(anexo.Rows[i]["Caminho_arquivo"].ToString());
                    }
                    arquivo.fechartxt();
                    this.tab_clientes.SelectedIndex = 5;
                }
            }
            else MessageBox.Show("Não foi criado nenhum arquivo pois não foi selecionada nenhuma pasta","Aviso");
        }

        private void RB_cidade_CheckedChanged(object sender, EventArgs e)
        {
            P_cidade.Enabled = true;
            P_camp.Enabled = false;
        }

        private void RB_interior_CheckedChanged(object sender, EventArgs e)
        {
            P_camp.Enabled = true;
            P_cidade.Enabled = false;
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

        private void B_corrigir_Click(object sender, EventArgs e)
        {
            this.tab_clientes.SelectedIndex = 0;
        }

        private void B_salvar_Click(object sender, EventArgs e)
        {
            txt arc = new txt();
            int c = 0;
            if (TB_nome.Text != "") c++;
            else MessageBox.Show("Campo nome vazio", "Aviso");
            if (MTB_id.Text != "") c++;
            else MessageBox.Show("Campo id vazio", "Aviso");
            if (MTB_cpf.Text != "") c++;
            else MessageBox.Show("Campo cpf vazio", "Aviso");
            if (MTB_rg.Text != "") c++;
            else MessageBox.Show("Campo rg vazio", "Aviso");
            if (DT_nasc.Value.Date != DateTime.Now.Date) c++;
            else MessageBox.Show("Campo data de nascimnto não selecionado", "Aviso");
            if (CB_civil.TabIndex != -1) c++;
            else MessageBox.Show("Campo estado civil não selecionado", "Aviso");
            if (CB_ddd_t1.SelectedIndex != -1) c++;
            else MessageBox.Show("DDD do 1° telefone não foi selecionado", "Aviso");
            if (MTB_t1.Text != "") c++;
            else MessageBox.Show("Campo do 1° telefone vazio", "Aviso");
            if (CB_proc.SelectedIndex != -1) c++;
            else MessageBox.Show("Estado do processo não selecionado", "Aviso");
            if (CB_adv.SelectedIndex != -1) c++;
            else MessageBox.Show("Tipo de advogado não selecionado", "Aviso");
            if (TB_cidade.Text != "") c++;
            else MessageBox.Show("Campo cidade vazio", "Aviso");
            if (MTB_cep.Text != "") c++;
            else MessageBox.Show("Campo cep vazio", "Aviso");
            if (RB_cidade.Checked == true)
            {
                if (TB_endereco.Text != "") c++;
                else MessageBox.Show("Campo endereço vazio", "Aviso");
                if (MTB_num.Text != "") c++;
                else MessageBox.Show("Campo numero vazio", "Aviso");
                query = string.Format("insert into ");

            }
            if (RB_interior.Checked == true)
            {
                if (TB_localidade.Text != "") c++;
                else MessageBox.Show("Campo localidade vazio", "Aviso");
                if (TB_distrito.Text != "") c++;
                else MessageBox.Show("Campo distrito vazio", "Aviso");
            }
            if (cm.contador("Select count(*) from cliente where id = " + Convert.ToInt32(MTB_id.Text)) == 0) c++;
            else MessageBox.Show("Numero de id já existente","Aviso");
            TB_pasta.Text = TB_pasta.Text.Replace(arc.lertxt("conf.txt", 4), "");
            if (c == 15) 
            {
                query = "insert into pinheiro_e_cruz.cliente(id,nome,cpf,rg,nome_pai,nome_mae,pis,ctps,data_nas,est_civil,endereco,num,comp,bairro,localidade,";
                query += "distrito,cidade,cep,tel_1,tel_2,email,val_causa,val_hon,val_rec,est_pro,tip_adv,num_pro,pasta_cli,usu_cri,dat_cri)";
                query += "values(";
                query += "'" + Convert.ToInt16(MTB_id.Text) + "',";
                query += "'" + TB_nome.Text + "',";
                query += "'" + MTB_cpf.Text.Replace(",",".") + "',";
                query += "'" + MTB_rg.Text + "',";
                query += "'" + TB_npai.Text + "',";
                query += "'" + TB_nmae.Text + "',";
                query += "'" + MTB_pis.Text + "',";
                query += "'" + MTB_ctps.Text + "',";
                query += "'" + Convert.ToString(DT_nasc.Value.Date) + "',";
                query += "'" + CB_civil.Text+ "',";
                query += "'" + TB_endereco.Text+ "',";
                query += "'" + Convert.ToInt16(MTB_num.Text)+ "',";
                query += "'" + TB_comp.Text+ "',";
                query += "'" + TB_Bairro.Text+ "',";
                query += "'" + TB_localidade.Text+ "',";
                query += "'" + TB_distrito.Text+ "',";
                query += "'" + TB_cidade.Text+ "',";
                query += "'" + MTB_cep.Text+ "',";
                query += "'(" +CB_ddd_t1.Text + ")" + MTB_t1.Text+ "',";
                query += "'(" + CB_ddd_t2.Text + ")" + MTB_t2.Text + "',";
                query += "'" + email+ "',";
                query += "'" + MTB_vcausa.Text+ "',";
                query += "'" + MTB_hon.Text+ "',";
                query += "'" + MTB_rec.Text+ "',";
                query += "'" + CB_proc.Text+ "',";
                query += "'" + CB_adv.Text+ "',";
                query += "'" + MTB_proc.Text.Replace(",",".") + "',";
                query += "'" + TB_pasta.Text.Replace(@"\","-") + "',";
                query += "'" + dt.Rows[0]["usuario"].ToString() + "',"; 
                query += "'" + DateTime.Now.ToShortDateString()+ " " + DateTime.Now.ToShortTimeString() +"');";
                if (RTB_branco.Text != "")
                {
                    if (MessageBox.Show("Tem certeza que deseja cadastrar o usuario sem todos dados", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cm.inserir(query);
                        new F_principal(dt).Show();
                        this.Visible = false;
                    }
                    else 
                    {
                        MessageBox.Show("Clique em corrigir e preencha todos os campos vazio","Aviso");
                    }

                }
                else 
                {
                    cm.inserir(query);
                    new F_principal(dt).Show();
                    this.Visible = false;
                }

            }
        }

        private void F_Cadastro_clientes_Load(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
            anexo.Columns.Add("Nome_arquivo",typeof(string));
            anexo.Columns.Add("Tipo_arquivo", typeof(string));
            anexo.Columns.Add("Ind_Tipo", typeof(string));
            anexo.Columns.Add("Caminho_arquivo", typeof(string));
            dg_anexo.DataSource = anexo;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
        }

        private void tab_a_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (directorio != "")
            {
                OFD.InitialDirectory = directorio;
                if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    arquivo = OFD.FileName;
                }
            }
            else MessageBox.Show("Directorio não selecionado","Aviso");
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (arquivo != "")
            {
                if (num_lin_txt < 10)
                {
                    if (TB_nane.Text != "")
                    {
                        if (RB_doc.Checked == true)
                        {
                            anexo.Rows.Add(TB_nane.Text, "Documentos", "1", arquivo);
                            num_lin_txt++;
                        }
                        else
                        {
                            if (RB_aud.Checked == true)
                            {
                                anexo.Rows.Add(TB_nane.Text, "Audio", "2", arquivo);
                                num_lin_txt++;
                            }
                            else
                            {
                                if (RB_ima.Checked == true)
                                {
                                    anexo.Rows.Add(TB_nane.Text, "Imagem", "3", arquivo);
                                    num_lin_txt++;
                                }
                                else
                                {
                                    if (RB_vid.Checked == true)
                                    {
                                        anexo.Rows.Add(TB_nane.Text, "Video", "4", arquivo);
                                        num_lin_txt++;
                                    }
                                    else MessageBox.Show("Tipo de arquivo não selecionado", "Aviso");
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Digite o nome do arquivo", "Aviso");
                }
                else MessageBox.Show("Maximo de arquivos foi alcançado","Aviso");
            }
            else MessageBox.Show("Selecione o arquivo","Aviso");
        }



    }
}
