﻿namespace Cadv
{
    partial class F_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_usuario));
            this.TB_email = new System.Windows.Forms.TextBox();
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_n_1 = new System.Windows.Forms.RadioButton();
            this.RB_n_0 = new System.Windows.Forms.RadioButton();
            this.MTB_senha = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MTB_c_senha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.B_email = new System.Windows.Forms.PictureBox();
            this.B_senha = new System.Windows.Forms.PictureBox();
            this.B_del = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.P_senha = new System.Windows.Forms.Panel();
            this.TB_senha_cn = new System.Windows.Forms.TextBox();
            this.TB_senha_nov = new System.Windows.Forms.TextBox();
            this.TB_senha_atu = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.P_email = new System.Windows.Forms.Panel();
            this.TB_t_cemail = new System.Windows.Forms.TextBox();
            this.tb_t_email = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.B_add = new System.Windows.Forms.PictureBox();
            this.P_add = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_user = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SS_not = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.P_senha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.P_email.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_add)).BeginInit();
            this.P_add.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_email
            // 
            this.TB_email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_email.Location = new System.Drawing.Point(199, 49);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(341, 26);
            this.TB_email.TabIndex = 2;
            this.TB_email.TextChanged += new System.EventHandler(this.TB_email_TextChanged);
            // 
            // TB_usuario
            // 
            this.TB_usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_usuario.Location = new System.Drawing.Point(21, 49);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(152, 26);
            this.TB_usuario.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(561, 96);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Limpar Campos");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(561, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 69);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Adicionar Usuario");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_n_1);
            this.groupBox1.Controls.Add(this.RB_n_0);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(368, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 50);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel";
            // 
            // RB_n_1
            // 
            this.RB_n_1.AutoSize = true;
            this.RB_n_1.Location = new System.Drawing.Point(113, 26);
            this.RB_n_1.Name = "RB_n_1";
            this.RB_n_1.Size = new System.Drawing.Size(34, 24);
            this.RB_n_1.TabIndex = 6;
            this.RB_n_1.TabStop = true;
            this.RB_n_1.Text = "1";
            this.RB_n_1.UseVisualStyleBackColor = true;
            // 
            // RB_n_0
            // 
            this.RB_n_0.AutoSize = true;
            this.RB_n_0.Location = new System.Drawing.Point(16, 25);
            this.RB_n_0.Name = "RB_n_0";
            this.RB_n_0.Size = new System.Drawing.Size(34, 24);
            this.RB_n_0.TabIndex = 5;
            this.RB_n_0.TabStop = true;
            this.RB_n_0.Text = "0";
            this.RB_n_0.UseVisualStyleBackColor = true;
            // 
            // MTB_senha
            // 
            this.MTB_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTB_senha.Location = new System.Drawing.Point(21, 120);
            this.MTB_senha.Name = "MTB_senha";
            this.MTB_senha.PasswordChar = '*';
            this.MTB_senha.Size = new System.Drawing.Size(152, 26);
            this.MTB_senha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Senha";
            // 
            // MTB_c_senha
            // 
            this.MTB_c_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTB_c_senha.Location = new System.Drawing.Point(199, 120);
            this.MTB_c_senha.Name = "MTB_c_senha";
            this.MTB_c_senha.PasswordChar = '*';
            this.MTB_c_senha.Size = new System.Drawing.Size(139, 26);
            this.MTB_c_senha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Conf. senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usuario";
            // 
            // B_email
            // 
            this.B_email.Image = ((System.Drawing.Image)(resources.GetObject("B_email.Image")));
            this.B_email.Location = new System.Drawing.Point(453, 11);
            this.B_email.Name = "B_email";
            this.B_email.Size = new System.Drawing.Size(48, 49);
            this.B_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_email.TabIndex = 28;
            this.B_email.TabStop = false;
            this.toolTip1.SetToolTip(this.B_email, "Alterar E-mail");
            this.B_email.Click += new System.EventHandler(this.B_email_Click);
            // 
            // B_senha
            // 
            this.B_senha.Image = ((System.Drawing.Image)(resources.GetObject("B_senha.Image")));
            this.B_senha.Location = new System.Drawing.Point(521, 11);
            this.B_senha.Name = "B_senha";
            this.B_senha.Size = new System.Drawing.Size(48, 49);
            this.B_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_senha.TabIndex = 27;
            this.B_senha.TabStop = false;
            this.toolTip1.SetToolTip(this.B_senha, "Alterar Senha");
            this.B_senha.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // B_del
            // 
            this.B_del.Image = ((System.Drawing.Image)(resources.GetObject("B_del.Image")));
            this.B_del.Location = new System.Drawing.Point(585, 11);
            this.B_del.Name = "B_del";
            this.B_del.Size = new System.Drawing.Size(48, 49);
            this.B_del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_del.TabIndex = 26;
            this.B_del.TabStop = false;
            this.toolTip1.SetToolTip(this.B_del, "Deletar usuario");
            this.B_del.Click += new System.EventHandler(this.B_del_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(601, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Voltar para menu principal");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // P_senha
            // 
            this.P_senha.BackColor = System.Drawing.Color.Transparent;
            this.P_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.P_senha.Controls.Add(this.TB_senha_cn);
            this.P_senha.Controls.Add(this.TB_senha_nov);
            this.P_senha.Controls.Add(this.TB_senha_atu);
            this.P_senha.Controls.Add(this.pictureBox8);
            this.P_senha.Controls.Add(this.label6);
            this.P_senha.Controls.Add(this.label4);
            this.P_senha.Controls.Add(this.label5);
            this.P_senha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.P_senha.Location = new System.Drawing.Point(12, 398);
            this.P_senha.Name = "P_senha";
            this.P_senha.Size = new System.Drawing.Size(652, 172);
            this.P_senha.TabIndex = 29;
            this.P_senha.Visible = false;
            this.P_senha.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TB_senha_cn
            // 
            this.TB_senha_cn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_senha_cn.Location = new System.Drawing.Point(368, 89);
            this.TB_senha_cn.Name = "TB_senha_cn";
            this.TB_senha_cn.Size = new System.Drawing.Size(152, 26);
            this.TB_senha_cn.TabIndex = 35;
            // 
            // TB_senha_nov
            // 
            this.TB_senha_nov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_senha_nov.Location = new System.Drawing.Point(190, 89);
            this.TB_senha_nov.Name = "TB_senha_nov";
            this.TB_senha_nov.Size = new System.Drawing.Size(152, 26);
            this.TB_senha_nov.TabIndex = 34;
            // 
            // TB_senha_atu
            // 
            this.TB_senha_atu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_senha_atu.Location = new System.Drawing.Point(21, 89);
            this.TB_senha_atu.Name = "TB_senha_atu";
            this.TB_senha_atu.Size = new System.Drawing.Size(152, 26);
            this.TB_senha_atu.TabIndex = 33;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(549, 48);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(73, 67);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Salvar Alterações");
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Conf. Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Senha atual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nova senha";
            // 
            // P_email
            // 
            this.P_email.BackColor = System.Drawing.Color.Transparent;
            this.P_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.P_email.Controls.Add(this.TB_t_cemail);
            this.P_email.Controls.Add(this.tb_t_email);
            this.P_email.Controls.Add(this.pictureBox9);
            this.P_email.Controls.Add(this.label8);
            this.P_email.Controls.Add(this.label10);
            this.P_email.Location = new System.Drawing.Point(671, 140);
            this.P_email.Name = "P_email";
            this.P_email.Size = new System.Drawing.Size(652, 172);
            this.P_email.TabIndex = 31;
            this.P_email.Visible = false;
            // 
            // TB_t_cemail
            // 
            this.TB_t_cemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_t_cemail.Location = new System.Drawing.Point(24, 107);
            this.TB_t_cemail.Name = "TB_t_cemail";
            this.TB_t_cemail.Size = new System.Drawing.Size(373, 26);
            this.TB_t_cemail.TabIndex = 32;
            // 
            // tb_t_email
            // 
            this.tb_t_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t_email.Location = new System.Drawing.Point(24, 48);
            this.tb_t_email.Name = "tb_t_email";
            this.tb_t_email.Size = new System.Drawing.Size(373, 26);
            this.tb_t_email.TabIndex = 31;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(424, 48);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(73, 67);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Salvar Alterações");
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Conf. E-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Novo E-mail";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(528, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Minimizar");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // B_add
            // 
            this.B_add.Image = ((System.Drawing.Image)(resources.GetObject("B_add.Image")));
            this.B_add.Location = new System.Drawing.Point(384, 11);
            this.B_add.Name = "B_add";
            this.B_add.Size = new System.Drawing.Size(48, 49);
            this.B_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_add.TabIndex = 25;
            this.B_add.TabStop = false;
            this.toolTip1.SetToolTip(this.B_add, "Adicionar Usuario");
            this.B_add.Click += new System.EventHandler(this.B_add_Click);
            // 
            // P_add
            // 
            this.P_add.Controls.Add(this.MTB_c_senha);
            this.P_add.Controls.Add(this.label2);
            this.P_add.Controls.Add(this.TB_email);
            this.P_add.Controls.Add(this.label1);
            this.P_add.Controls.Add(this.label7);
            this.P_add.Controls.Add(this.label3);
            this.P_add.Controls.Add(this.MTB_senha);
            this.P_add.Controls.Add(this.pictureBox4);
            this.P_add.Controls.Add(this.TB_usuario);
            this.P_add.Controls.Add(this.pictureBox1);
            this.P_add.Controls.Add(this.groupBox1);
            this.P_add.Location = new System.Drawing.Point(12, 140);
            this.P_add.Name = "P_add";
            this.P_add.Size = new System.Drawing.Size(652, 172);
            this.P_add.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TB_user);
            this.panel2.Controls.Add(this.B_add);
            this.panel2.Controls.Add(this.B_email);
            this.panel2.Controls.Add(this.B_del);
            this.panel2.Controls.Add(this.B_senha);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 69);
            this.panel2.TabIndex = 33;
            // 
            // TB_user
            // 
            this.TB_user.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_user.Location = new System.Drawing.Point(21, 24);
            this.TB_user.Name = "TB_user";
            this.TB_user.Size = new System.Drawing.Size(321, 26);
            this.TB_user.TabIndex = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SS_not});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(671, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SS_not
            // 
            this.SS_not.Name = "SS_not";
            this.SS_not.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 354);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.P_add);
            this.Controls.Add(this.P_senha);
            this.Controls.Add(this.P_email);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.P_senha.ResumeLayout(false);
            this.P_senha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.P_email.ResumeLayout(false);
            this.P_email.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_add)).EndInit();
            this.P_add.ResumeLayout(false);
            this.P_add.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_n_1;
        private System.Windows.Forms.RadioButton RB_n_0;
        private System.Windows.Forms.MaskedTextBox MTB_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTB_c_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel P_senha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox B_email;
        private System.Windows.Forms.PictureBox B_senha;
        private System.Windows.Forms.PictureBox B_del;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel P_email;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.TextBox TB_usuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TB_t_cemail;
        private System.Windows.Forms.TextBox tb_t_email;
        private System.Windows.Forms.Panel P_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox B_add;
        private System.Windows.Forms.TextBox TB_senha_cn;
        private System.Windows.Forms.TextBox TB_senha_nov;
        private System.Windows.Forms.TextBox TB_senha_atu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SS_not;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TB_user;
    }
}