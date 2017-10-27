using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cadv
{
    public partial class F_configuracoes : Form
    {
        DataTable dt = new DataTable();
        string caminho;
        public F_configuracoes(DataTable login)
        {
            InitializeComponent();
            dt = login;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //volta para o forme principal
            new F_principal(dt).Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int c=0;
            //teste se o campo ip esta vazio
            if (TB_ip.Text != "") c++;
            else MessageBox.Show("Campo IP vazio", "Aviso");
            //teste se o campo senha esta vazio
            if (TB_senha.Text != "") c++;
            else MessageBox.Show("Campo senha invalida", "Aviso");
            if (TB_csenha.Text != "") c++;
            else MessageBox.Show("Campo confirmação de senha vazio", "Aviso");
            //teste se o campo confirmação de senha esta vazio
            if (TB_nome_serv.Text != "") c++;
            else MessageBox.Show("Campo nome do servidor vazio", "Aviso");
            //teste se senha e confirmação de senha são iguais
            if (TB_senha.Text == TB_csenha.Text) c++;
            else MessageBox.Show("As senhas não conferem", "Aviso");
            if (TB_ban_dados.Text != "") c++;
            else MessageBox.Show("Campo Banco de dados vazio","Aviso");
            if (TB_cam_arqu.Text != "") c++;
            else MessageBox.Show("Caminho dos arquivos não foi selecionado", "Aviso");
            if (c == 7) {
                txt arquivo = new txt();
                arquivo.criartxt("conf.txt");
                arquivo.instanciar("conf.txt");
                arquivo.escrevertxt(TB_ip.Text);
                arquivo.escrevertxt(TB_nome_serv.Text);
                arquivo.escrevertxt(TB_ban_dados.Text);
                arquivo.escrevertxt(TB_senha.Text);
                arquivo.escrevertxt(TB_cam_arqu.Text);
                arquivo.fechartxt();
                MessageBox.Show(arquivo.lertxt("conf.txt", 1));
            }
        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
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
                    caminho = directorio;
                    TB_cam_arqu.Text = caminho;
                }
                else
                {
                    // Caso o utilizador tenha cancelado
                    MessageBox.Show("Se não for selecionado o local de salvamento\nNão será possivel salvar as configurações");
                    // ...
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_minimizar_Click(object sender, EventArgs e)
        {
            //Minimizar o programa
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
