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
    public partial class Form2 : Form
    {
        KetNoi kn = new KetNoi();
        SqlDataAdapter da;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        SqlConnection conn;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
            conn = kn.conn;

            string strSelect = "select * from GV";
            da = new SqlDataAdapter(strSelect, conn);
            ds = new DataSet();
            da.Fill(ds, "GV");
            key[0] = ds.Tables["GV"].Columns[0];
            ds.Tables["GV"].PrimaryKey = key;
            //    string strSelect1 = "select * from COSO";
            //    da = new SqlDataAdapter(strSelect1, conn);
            //    ds = new DataSet();
            //    da.Fill(ds, "COSO");
            //    key[0] = ds.Tables["COSO"].Columns[0];
            //    ds.Tables["COSO"].PrimaryKey = key;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadCCB_DonVi()
        {
        }
        void Databingding(DataTable pDT)
        {
            
            da.Fill(ds, "GV");
            ccbDonVi.DataSource = ds.Tables[0];
            ccbDonVi.DisplayMember = "madonvi";
            ccbDonVi.ValueMember = "madonvi";
            //da.Fill(ds, "COSO");
            //cbbCoSo.DataSource = ds.Tables[0];
            //cbbCoSo.DisplayMember = "tencoso";
            //cbbCoSo.ValueMember = "macoso";
        }
        void loadGrid()
        {
            dgvDSGV.DataSource = ds.Tables[0];
            Databingding(ds.Tables[0]);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
