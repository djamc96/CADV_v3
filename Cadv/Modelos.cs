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
    public partial class F_Modelos : Form
    {
        txt arq = new txt();
        DataTable dt_mod = new DataTable();
        DataTable dt_salvar = new DataTable();
        DataTable dt_use = new DataTable();
        string cam_arquivo = "",cam_arq="";
        int num_lin_txt = 0;
        string directorio;

        public F_Modelos(DataTable u)
        {
            InitializeComponent();
            dt_use = u;
        }

        private void F_Modelos_Load(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt_use.Rows[0]["usuario"].ToString();
            dt_mod.Columns.Add("Nome_mod",typeof(string));
            dt_mod.Columns.Add("Tipo_mod", typeof(int));
            dt_mod.Columns.Add("Caminho_mod", typeof(string));
            dt_salvar.Columns.Add("Nome_mod", typeof(string));
            dt_salvar.Columns.Add("Tipo_mod", typeof(int));
            dt_salvar.Columns.Add("Caminho_mod", typeof(string));
            cam_arquivo = arq.lertxt("conf.txt",4) + @"Servidor\Modelos\modelo.txt";
            directorio = arq.lertxt("conf.txt", 4) + @"Servidor\Modelos";
            if (arq.exi_txt(cam_arquivo))
            {
                num_lin_txt = Convert.ToInt32(arq.lertxt(cam_arquivo, 0));
                dt_salvar.Clear();
                for (int n_arq = 1; n_arq <= (num_lin_txt * 3); n_arq = n_arq + 3)
                {
                    dt_salvar.Rows.Add(arq.lertxt(cam_arquivo, (n_arq)), Convert.ToInt32(arq.lertxt(cam_arquivo, (n_arq + 1))), arq.lertxt(cam_arquivo, (n_arq + 2)));
                }
                atualizar();
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado\nNenhum modelo disponivel", "Aviso");
            }
            car_del();
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void B_arquivo_Click(object sender, EventArgs e)
        {
            OFD_mod.InitialDirectory = directorio;
            if (OFD_mod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cam_arq = OFD_mod.FileName;
            }
        }

        private void B_add_Click(object sender, EventArgs e)
        {
            if (num_lin_txt < 50)
            {
                if (cam_arq != "")
                {
                    if (TB_n_mod.Text != "")
                    {
                        if (RB_word.Checked == true)
                        {
                            dt_salvar.Rows.Add(TB_n_mod.Text, 1, cam_arq);
                            num_lin_txt++;
                        }
                        else
                        {
                            if (RB_exc.Checked == true)
                            {
                                dt_salvar.Rows.Add(TB_n_mod.Text, 2, cam_arq);
                                num_lin_txt++;
                            }
                            else
                            {
                                if (RB_ppo.Checked == true)
                                {
                                    dt_salvar.Rows.Add(TB_n_mod.Text, 3, cam_arq);
                                    num_lin_txt++;
                                }
                                else MessageBox.Show("Tipo de arquivo não selecionado", "Aviso");
                            }
                        }
                        num_lin_txt = dt_mod.Rows.Count;
                        atua_txt();
                        atualizar();
                        cam_arq = "";
                    }
                    else MessageBox.Show("Digite o nome do arquivo", "Aviso");
                }
                else MessageBox.Show("Selecion um arquivo","Aviso");
            }
            else MessageBox.Show("Maximo de arquivos foi alcançado", "Aviso");
            car_del();
            
        }

        private void atualizar() 
        {
            num_lin_txt = Convert.ToInt32(arq.lertxt(cam_arquivo, 0));
            dt_mod.Clear();
            for (int n_arq = 1; n_arq <= (num_lin_txt * 3); n_arq = n_arq + 3)
            {
                dt_mod.Rows.Add(arq.lertxt(cam_arquivo, (n_arq)), Convert.ToInt32(arq.lertxt(cam_arquivo, (n_arq + 1))), arq.lertxt(cam_arquivo, (n_arq + 2)));
            }

            if (dt_mod.Rows.Count > 0 && dt_mod.Rows.Count <= 10)
            {
                for (int i = (dt_mod.Rows.Count); i < 10; i++)
                {
                    dt_mod.Rows.Add("Vazio", 0, "Vazio");
                }
            }
            else
            {
                if (dt_mod.Rows.Count <= 20)
                {
                    for (int i = (dt_mod.Rows.Count - 1); i < 20; i++)
                    {
                        dt_mod.Rows.Add("Vazio", 0, "Vazio");
                    }
                }
                else
                {
                    if (dt_mod.Rows.Count <= 30)
                    {
                        for (int i = (dt_mod.Rows.Count - 1); i < 30; i++)
                        {
                            dt_mod.Rows.Add("Vazio", 0, "Vazio");
                        }
                    }
                    else
                    {
                        if (dt_mod.Rows.Count <= 40)
                        {
                            for (int i = (dt_mod.Rows.Count - 1); i < 40; i++)
                            {
                                dt_mod.Rows.Add("Vazio", 0, "Vazio");
                            }
                        }
                        else
                        {
                            for (int i = (dt_mod.Rows.Count - 1); i < 10; i++)
                            {
                                dt_mod.Rows.Add("Vazio", 0, "Vazio");
                            }
                        }
                    }
                }
            }

            IM_mod_1.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[0]["Tipo_mod"].ToString())];
            IM_mod_2.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[1]["Tipo_mod"].ToString())];
            IM_mod_3.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[2]["Tipo_mod"].ToString())];
            IM_mod_4.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[3]["Tipo_mod"].ToString())];
            IM_mod_5.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[4]["Tipo_mod"].ToString())];
            IM_mod_6.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[5]["Tipo_mod"].ToString())];
            IM_mod_7.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[6]["Tipo_mod"].ToString())];
            IM_mod_8.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[7]["Tipo_mod"].ToString())];
            IM_mod_9.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[8]["Tipo_mod"].ToString())];
            IM_mod_10.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[9]["Tipo_mod"].ToString())];
            L_mod_1.Text = dt_mod.Rows[0]["Nome_mod"].ToString();
            L_mod_2.Text = dt_mod.Rows[1]["Nome_mod"].ToString();
            L_mod_3.Text = dt_mod.Rows[2]["Nome_mod"].ToString();
            L_mod_4.Text = dt_mod.Rows[3]["Nome_mod"].ToString();
            L_mod_5.Text = dt_mod.Rows[4]["Nome_mod"].ToString();
            L_mod_6.Text = dt_mod.Rows[5]["Nome_mod"].ToString();
            L_mod_7.Text = dt_mod.Rows[6]["Nome_mod"].ToString();
            L_mod_8.Text = dt_mod.Rows[7]["Nome_mod"].ToString();
            L_mod_9.Text = dt_mod.Rows[8]["Nome_mod"].ToString();
            L_mod_10.Text = dt_mod.Rows[9]["Nome_mod"].ToString();
            if (dt_mod.Rows.Count > 10) 
            {
                IM_mod_11.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[10]["Tipo_mod"].ToString())];
                IM_mod_12.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[11]["Tipo_mod"].ToString())];
                IM_mod_13.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[12]["Tipo_mod"].ToString())];
                IM_mod_14.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[13]["Tipo_mod"].ToString())];
                IM_mod_15.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[14]["Tipo_mod"].ToString())];
                IM_mod_16.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[15]["Tipo_mod"].ToString())];
                IM_mod_17.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[16]["Tipo_mod"].ToString())];
                IM_mod_18.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[17]["Tipo_mod"].ToString())];
                IM_mod_19.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[18]["Tipo_mod"].ToString())];
                IM_mod_20.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[19]["Tipo_mod"].ToString())];
                L_mod_11.Text = dt_mod.Rows[10]["Nome_mod"].ToString();
                L_mod_12.Text = dt_mod.Rows[11]["Nome_mod"].ToString();
                L_mod_13.Text = dt_mod.Rows[12]["Nome_mod"].ToString();
                L_mod_14.Text = dt_mod.Rows[13]["Nome_mod"].ToString();
                L_mod_15.Text = dt_mod.Rows[14]["Nome_mod"].ToString();
                L_mod_16.Text = dt_mod.Rows[15]["Nome_mod"].ToString();
                L_mod_17.Text = dt_mod.Rows[16]["Nome_mod"].ToString();
                L_mod_18.Text = dt_mod.Rows[17]["Nome_mod"].ToString();
                L_mod_19.Text = dt_mod.Rows[18]["Nome_mod"].ToString();
                L_mod_20.Text = dt_mod.Rows[19]["Nome_mod"].ToString();
            }
            if (dt_salvar.Rows.Count > 20)
            {
                IM_mod_21.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[20]["Tipo_mod"].ToString())];
                IM_mod_22.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[21]["Tipo_mod"].ToString())];
                IM_mod_23.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[22]["Tipo_mod"].ToString())];
                IM_mod_24.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[23]["Tipo_mod"].ToString())];
                IM_mod_25.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[24]["Tipo_mod"].ToString())];
                IM_mod_26.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[25]["Tipo_mod"].ToString())];
                IM_mod_17.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[26]["Tipo_mod"].ToString())];
                IM_mod_28.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[27]["Tipo_mod"].ToString())];
                IM_mod_29.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[28]["Tipo_mod"].ToString())];
                IM_mod_30.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[29]["Tipo_mod"].ToString())];
                L_mod_21.Text = dt_mod.Rows[20]["Nome_mod"].ToString();
                L_mod_22.Text = dt_mod.Rows[21]["Nome_mod"].ToString();
                L_mod_23.Text = dt_mod.Rows[22]["Nome_mod"].ToString();
                L_mod_24.Text = dt_mod.Rows[23]["Nome_mod"].ToString();
                L_mod_25.Text = dt_mod.Rows[24]["Nome_mod"].ToString();
                L_mod_26.Text = dt_mod.Rows[25]["Nome_mod"].ToString();
                L_mod_27.Text = dt_mod.Rows[26]["Nome_mod"].ToString();
                L_mod_28.Text = dt_mod.Rows[27]["Nome_mod"].ToString();
                L_mod_29.Text = dt_mod.Rows[28]["Nome_mod"].ToString();
                L_mod_30.Text = dt_mod.Rows[29]["Nome_mod"].ToString();
            }
            if (dt_salvar.Rows.Count > 30)
            {
                IM_mod_31.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[30]["Tipo_mod"].ToString())];
                IM_mod_32.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[31]["Tipo_mod"].ToString())];
                IM_mod_33.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[32]["Tipo_mod"].ToString())];
                IM_mod_34.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[33]["Tipo_mod"].ToString())];
                IM_mod_35.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[34]["Tipo_mod"].ToString())];
                IM_mod_36.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[35]["Tipo_mod"].ToString())];
                IM_mod_37.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[36]["Tipo_mod"].ToString())];
                IM_mod_38.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[37]["Tipo_mod"].ToString())];
                IM_mod_39.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[38]["Tipo_mod"].ToString())];
                IM_mod_40.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[39]["Tipo_mod"].ToString())];
                L_mod_31.Text = dt_mod.Rows[30]["Nome_mod"].ToString();
                L_mod_32.Text = dt_mod.Rows[31]["Nome_mod"].ToString();
                L_mod_33.Text = dt_mod.Rows[32]["Nome_mod"].ToString();
                L_mod_34.Text = dt_mod.Rows[33]["Nome_mod"].ToString();
                L_mod_35.Text = dt_mod.Rows[34]["Nome_mod"].ToString();
                L_mod_36.Text = dt_mod.Rows[35]["Nome_mod"].ToString();
                L_mod_37.Text = dt_mod.Rows[36]["Nome_mod"].ToString();
                L_mod_38.Text = dt_mod.Rows[37]["Nome_mod"].ToString();
                L_mod_39.Text = dt_mod.Rows[38]["Nome_mod"].ToString();
                L_mod_40.Text = dt_mod.Rows[39]["Nome_mod"].ToString();
            }
            if (dt_salvar.Rows.Count > 40)
            {
                IM_mod_41.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[40]["Tipo_mod"].ToString())];
                IM_mod_42.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[41]["Tipo_mod"].ToString())];
                IM_mod_43.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[42]["Tipo_mod"].ToString())];
                IM_mod_44.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[43]["Tipo_mod"].ToString())];
                IM_mod_45.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[44]["Tipo_mod"].ToString())];
                IM_mod_46.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[45]["Tipo_mod"].ToString())];
                IM_mod_47.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[46]["Tipo_mod"].ToString())];
                IM_mod_48.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[47]["Tipo_mod"].ToString())];
                IM_mod_49.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[48]["Tipo_mod"].ToString())];
                IM_mod_50.Image = IL_modelo.Images[Convert.ToInt32(dt_mod.Rows[49]["Tipo_mod"].ToString())];
                L_mod_41.Text = dt_mod.Rows[40]["Nome_mod"].ToString();
                L_mod_42.Text = dt_mod.Rows[41]["Nome_mod"].ToString();
                L_mod_43.Text = dt_mod.Rows[42]["Nome_mod"].ToString();
                L_mod_44.Text = dt_mod.Rows[43]["Nome_mod"].ToString();
                L_mod_45.Text = dt_mod.Rows[44]["Nome_mod"].ToString();
                L_mod_46.Text = dt_mod.Rows[45]["Nome_mod"].ToString();
                L_mod_47.Text = dt_mod.Rows[46]["Nome_mod"].ToString();
                L_mod_48.Text = dt_mod.Rows[47]["Nome_mod"].ToString();
                L_mod_49.Text = dt_mod.Rows[48]["Nome_mod"].ToString();
                L_mod_50.Text = dt_mod.Rows[49]["Nome_mod"].ToString();
            }            
        }

        private void atua_txt() 
        {
            arq.criartxt(cam_arquivo);
            arq.instanciar(cam_arquivo);
            arq.escrevertxt(dt_salvar.Rows.Count.ToString());
            for (int i = 0; i < dt_salvar.Rows.Count; i++)
            {
                arq.escrevertxt(dt_salvar.Rows[i]["Nome_mod"].ToString());
                arq.escrevertxt(dt_salvar.Rows[i]["Tipo_mod"].ToString());
                arq.escrevertxt(dt_salvar.Rows[i]["Caminho_mod"].ToString());
            }
            arq.fechartxt();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new F_principal(dt_use).Show();
            this.Visible = false;
        }

        private void IM_mod_1_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[0]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[0]["Caminho_mod"].ToString());
                car_mod_rec(0);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void car_mod_rec(int indice) 
        {
            DataTable dt_rec = new DataTable();
            dt_rec.Columns.Add("Nome_modelo", typeof(string));
            dt_rec.Columns.Add("Tipo_modelo", typeof(string));
            dt_rec.Columns.Add("Caminho_modelo", typeof(string));
            if (arq.exi_txt("modelo_rec.txt"))
            {
                for (int i = 0; i < 21; i = i + 3)
                {
                    dt_rec.Rows.Add(arq.lertxt("modelo_rec.txt", i), Convert.ToInt32(arq.lertxt("modelo_rec.txt", (i + 1))), arq.lertxt("modelo_rec.txt", (i + 2)));
                }
            }
            if (dt_rec.Rows.Count == 7)
            {
                dt_rec.Rows[0].Delete();
                dt_rec.Rows.Add(dt_mod.Rows[indice][0].ToString(), dt_mod.Rows[indice][1].ToString(), dt_mod.Rows[indice][2].ToString());
            }
            else 
            {
                dt_rec.Rows.Add(dt_mod.Rows[indice][0].ToString(), dt_mod.Rows[indice][1].ToString(), dt_mod.Rows[indice][2].ToString());
            }
            arq.criartxt("modelo_rec.txt");
            arq.instanciar("modelo_rec.txt");
            for (int i = 0; i < (7 - dt_rec.Rows.Count); i++)
            {
                arq.escrevertxt("Vazio");
                arq.escrevertxt("0");
                arq.escrevertxt("Vazio");
            }
            for (int i = 0; i < dt_rec.Rows.Count; i++)
            {
                arq.escrevertxt(dt_rec.Rows[i]["Nome_modelo"].ToString());
                arq.escrevertxt(dt_rec.Rows[i]["Tipo_modelo"].ToString());
                arq.escrevertxt(dt_rec.Rows[i]["Caminho_modelo"].ToString());
            }        
            arq.fechartxt();
        }

        private void IM_mod_2_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[1]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[1]["Caminho_mod"].ToString());
                car_mod_rec(1);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_3_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[2]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[2]["Caminho_mod"].ToString());
                car_mod_rec(2);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_4_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[3]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[3]["Caminho_mod"].ToString());
                car_mod_rec(3);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_5_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[4]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[4]["Caminho_mod"].ToString());
                car_mod_rec(4);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_6_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[5]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[5]["Caminho_mod"].ToString());
                car_mod_rec(5);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_7_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[6]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[6]["Caminho_mod"].ToString());
                car_mod_rec(6);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_8_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[7]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[7]["Caminho_mod"].ToString());
                car_mod_rec(7);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_9_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[8]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[8]["Caminho_mod"].ToString());
                car_mod_rec(8);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_10_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[9]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[9]["Caminho_mod"].ToString());
                car_mod_rec(9);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_11_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[10]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[10]["Caminho_mod"].ToString());
                car_mod_rec(10);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_12_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[11]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[11]["Caminho_mod"].ToString());
                car_mod_rec(11);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_13_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[12]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[12]["Caminho_mod"].ToString());
                car_mod_rec(12);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_14_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[13]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[13]["Caminho_mod"].ToString());
                car_mod_rec(13);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_15_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[14]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[14]["Caminho_mod"].ToString());
                car_mod_rec(14);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_16_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[15]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[15]["Caminho_mod"].ToString());
                car_mod_rec(15);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_17_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[16]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[16]["Caminho_mod"].ToString());
                car_mod_rec(16);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_18_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[17]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[17]["Caminho_mod"].ToString());
                car_mod_rec(17);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_19_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[18]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[18]["Caminho_mod"].ToString());
                car_mod_rec(18);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_20_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[19]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[19]["Caminho_mod"].ToString());
                car_mod_rec(19);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_21_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[20]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[20]["Caminho_mod"].ToString());
                car_mod_rec(20);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_22_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[21]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[21]["Caminho_mod"].ToString());
                car_mod_rec(21);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_23_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[22]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[22]["Caminho_mod"].ToString());
                car_mod_rec(22);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_24_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[23]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[23]["Caminho_mod"].ToString());
                car_mod_rec(23);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_25_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[24]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[24]["Caminho_mod"].ToString());
                car_mod_rec(24);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_26_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[25]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[25]["Caminho_mod"].ToString());
                car_mod_rec(25);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_27_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[26]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[26]["Caminho_mod"].ToString());
                car_mod_rec(26);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_28_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[27]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[27]["Caminho_mod"].ToString());
                car_mod_rec(27);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_29_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[28]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[28]["Caminho_mod"].ToString());
                car_mod_rec(28);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_30_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[29]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[29]["Caminho_mod"].ToString());
                car_mod_rec(29);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_31_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[30]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[30]["Caminho_mod"].ToString());
                car_mod_rec(30);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_32_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[31]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[31]["Caminho_mod"].ToString());
                car_mod_rec(31);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_33_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[32]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[32]["Caminho_mod"].ToString());
                car_mod_rec(32);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_34_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[33]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[33]["Caminho_mod"].ToString());
                car_mod_rec(33);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_35_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[34]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[34]["Caminho_mod"].ToString());
                car_mod_rec(34);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_36_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[35]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[35]["Caminho_mod"].ToString());
                car_mod_rec(35);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_37_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[36]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[36]["Caminho_mod"].ToString());
                car_mod_rec(36);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_38_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[37]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[37]["Caminho_mod"].ToString());
                car_mod_rec(37);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_39_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[38]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[38]["Caminho_mod"].ToString());
                car_mod_rec(38);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_40_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[39]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[39]["Caminho_mod"].ToString());
                car_mod_rec(39);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_41_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[40]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[40]["Caminho_mod"].ToString());
                car_mod_rec(40);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_42_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[41]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[41]["Caminho_mod"].ToString());
                car_mod_rec(41);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_43_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[42]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[42]["Caminho_mod"].ToString());
                car_mod_rec(42);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_44_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[43]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[43]["Caminho_mod"].ToString());
                car_mod_rec(43);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_45_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[44]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[44]["Caminho_mod"].ToString());
                car_mod_rec(44);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_46_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[45]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[45]["Caminho_mod"].ToString());
                car_mod_rec(45);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_47_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[46]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[46]["Caminho_mod"].ToString());
                car_mod_rec(46);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_48_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[47]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[47]["Caminho_mod"].ToString());
                car_mod_rec(47);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_49_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[48]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[48]["Caminho_mod"].ToString());
                car_mod_rec(48);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void IM_mod_50_Click(object sender, EventArgs e)
        {
            if (dt_mod.Rows[49]["Caminho_mod"].ToString() != "Vazio")
            {
                System.Diagnostics.Process.Start(dt_mod.Rows[49]["Caminho_mod"].ToString());
                car_mod_rec(49);
            }
            else
            {
                MessageBox.Show("Arquivo vazio", "Aviso");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt_use.Rows[0]["usuario"].ToString();
        }

        private void car_del() 
        {
            CB_del.Items.Clear();
            for (int i = 0; i < dt_salvar.Rows.Count; i++)
            {
                CB_del.Items.Add("Deletar modelo " + (i + 1));
            }
            CB_del.Text = "Selecione o modelo para deletar";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar mesmo", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CB_del.SelectedIndex != -1)
                {
                    dt_salvar.Rows[CB_del.SelectedIndex].Delete();
                    MessageBox.Show("Modelo deletado com sucesso");
                    atua_txt();
                    atualizar();
                }
                else MessageBox.Show("Selecione um modelo antes", "Aviso");
            }
        }
    }
}
