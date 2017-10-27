namespace Cadv
{
    partial class F_configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_configuracoes));
            this.label7 = new System.Windows.Forms.Label();
            this.TB_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_voltar = new System.Windows.Forms.PictureBox();
            this.B_salvar = new System.Windows.Forms.PictureBox();
            this.B_minimizar = new System.Windows.Forms.PictureBox();
            this.B_diretorio = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TB_csenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_nome_serv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_ip = new System.Windows.Forms.TextBox();
            this.TB_ban_dados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_cam_arqu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.B_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_salvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_diretorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "IP";
            // 
            // TB_senha
            // 
            this.TB_senha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_senha.Location = new System.Drawing.Point(14, 111);
            this.TB_senha.Name = "TB_senha";
            this.TB_senha.Size = new System.Drawing.Size(129, 26);
            this.TB_senha.TabIndex = 1;
            this.TB_senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Senha";
            // 
            // B_voltar
            // 
            this.B_voltar.Image = ((System.Drawing.Image)(resources.GetObject("B_voltar.Image")));
            this.B_voltar.Location = new System.Drawing.Point(603, 18);
            this.B_voltar.Name = "B_voltar";
            this.B_voltar.Size = new System.Drawing.Size(48, 49);
            this.B_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_voltar.TabIndex = 51;
            this.B_voltar.TabStop = false;
            this.toolTip1.SetToolTip(this.B_voltar, "Voltar");
            this.B_voltar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // B_salvar
            // 
            this.B_salvar.Image = ((System.Drawing.Image)(resources.GetObject("B_salvar.Image")));
            this.B_salvar.Location = new System.Drawing.Point(603, 88);
            this.B_salvar.Name = "B_salvar";
            this.B_salvar.Size = new System.Drawing.Size(48, 49);
            this.B_salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_salvar.TabIndex = 52;
            this.B_salvar.TabStop = false;
            this.toolTip1.SetToolTip(this.B_salvar, "Salvar");
            this.B_salvar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // B_minimizar
            // 
            this.B_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("B_minimizar.Image")));
            this.B_minimizar.Location = new System.Drawing.Point(536, 17);
            this.B_minimizar.Name = "B_minimizar";
            this.B_minimizar.Size = new System.Drawing.Size(48, 49);
            this.B_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_minimizar.TabIndex = 53;
            this.B_minimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.B_minimizar, "Minimizar");
            this.B_minimizar.Click += new System.EventHandler(this.B_minimizar_Click);
            // 
            // B_diretorio
            // 
            this.B_diretorio.Image = ((System.Drawing.Image)(resources.GetObject("B_diretorio.Image")));
            this.B_diretorio.Location = new System.Drawing.Point(536, 88);
            this.B_diretorio.Name = "B_diretorio";
            this.B_diretorio.Size = new System.Drawing.Size(48, 49);
            this.B_diretorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_diretorio.TabIndex = 54;
            this.B_diretorio.TabStop = false;
            this.toolTip1.SetToolTip(this.B_diretorio, "Selecionar local para salvar as configurações");
            this.B_diretorio.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // TB_csenha
            // 
            this.TB_csenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_csenha.Location = new System.Drawing.Point(176, 111);
            this.TB_csenha.Name = "TB_csenha";
            this.TB_csenha.Size = new System.Drawing.Size(129, 26);
            this.TB_csenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "C Senha";
            // 
            // TB_nome_serv
            // 
            this.TB_nome_serv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nome_serv.Location = new System.Drawing.Point(176, 40);
            this.TB_nome_serv.Name = "TB_nome_serv";
            this.TB_nome_serv.Size = new System.Drawing.Size(129, 26);
            this.TB_nome_serv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Usuario";
            // 
            // TB_ip
            // 
            this.TB_ip.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ip.Location = new System.Drawing.Point(14, 40);
            this.TB_ip.Name = "TB_ip";
            this.TB_ip.Size = new System.Drawing.Size(129, 26);
            this.TB_ip.TabIndex = 0;
            // 
            // TB_ban_dados
            // 
            this.TB_ban_dados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ban_dados.Location = new System.Drawing.Point(329, 40);
            this.TB_ban_dados.Name = "TB_ban_dados";
            this.TB_ban_dados.Size = new System.Drawing.Size(181, 26);
            this.TB_ban_dados.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Banco de dados";
            // 
            // TB_cam_arqu
            // 
            this.TB_cam_arqu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cam_arqu.Location = new System.Drawing.Point(329, 111);
            this.TB_cam_arqu.Name = "TB_cam_arqu";
            this.TB_cam_arqu.Size = new System.Drawing.Size(181, 26);
            this.TB_cam_arqu.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Servidor";
            // 
            // F_configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 171);
            this.Controls.Add(this.TB_ban_dados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_cam_arqu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_ip);
            this.Controls.Add(this.TB_nome_serv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_csenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_diretorio);
            this.Controls.Add(this.B_minimizar);
            this.Controls.Add(this.B_salvar);
            this.Controls.Add(this.B_voltar);
            this.Controls.Add(this.TB_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracoes";
            ((System.ComponentModel.ISupportInitialize)(this.B_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_salvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_diretorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox B_voltar;
        private System.Windows.Forms.PictureBox B_salvar;
        private System.Windows.Forms.PictureBox B_minimizar;
        private System.Windows.Forms.PictureBox B_diretorio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TB_csenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_nome_serv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_ip;
        private System.Windows.Forms.TextBox TB_ban_dados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_cam_arqu;
        private System.Windows.Forms.Label label5;
    }
}