using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BaiThucHanh14
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection("Data Source=" + txtTenMay.Text + ";Initial Catalog=" + txtTenCSDL.Text + "; Integrated Security=True");
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Ket noi CSDL thanh cong!!");
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
            } catch(SqlException ex)
            {
                MessageBox.Show("Ket noi that bai!!");
            }
         
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void txtTenMay_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
