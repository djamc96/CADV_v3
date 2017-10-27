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
    public partial class F_financeiro : Form
    {
        DataTable dt = new DataTable();

        public F_financeiro(DataTable login)
        {
            InitializeComponent();
            dt = login;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new F_principal(dt).Show();
            this.Visible = false;
        }

        private void F_financeiro_Load(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
            conexao_mysql cm = new conexao_mysql();
            DataTable finan = new DataTable();
            string query = "Select nome,id,val_causa,val_hon,val_rec from cliente order by nome";
            DG_fina.DataSource = cm.buscaseletiva(query);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SS_not.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString() + " , " + dt.Rows[0]["usuario"].ToString();
        }
    }
}
