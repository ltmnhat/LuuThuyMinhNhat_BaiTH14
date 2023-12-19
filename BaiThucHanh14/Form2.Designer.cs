namespace BaiThucHanh14
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.ccbDonVi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co So";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Don Vi Co So";
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(148, 30);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(406, 21);
            this.cbbCoSo.TabIndex = 2;
            // 
            // ccbDonVi
            // 
            this.ccbDonVi.FormattingEnabled = true;
            this.ccbDonVi.Location = new System.Drawing.Point(148, 58);
            this.ccbDonVi.Name = "ccbDonVi";
            this.ccbDonVi.Size = new System.Drawing.Size(406, 21);
            this.ccbDonVi.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSGV);
            this.groupBox1.Location = new System.Drawing.Point(37, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sach giao vien";
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Location = new System.Drawing.Point(6, 19);
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.Size = new System.Drawing.Size(511, 142);
            this.dgvDSGV.TabIndex = 0;
            this.dgvDSGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(479, 295);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(237, 295);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 6;
            this.btnHienThi.Text = "Hien Thi";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(354, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 428);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ccbDonVi);
            this.Controls.Add(this.cbbCoSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.ComboBox ccbDonVi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
    }
}