namespace BaiThucHanh14
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtDonvidaotao = new System.Windows.Forms.TextBox();
            this.txtCoso = new System.Windows.Forms.TextBox();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thong tin chi tiet giao vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ho ten giao vien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Don vi dao tao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Co so";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(131, 42);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(260, 20);
            this.txtHoten.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(131, 81);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(131, 120);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(260, 20);
            this.txtGhichu.TabIndex = 8;
            // 
            // txtDonvidaotao
            // 
            this.txtDonvidaotao.Location = new System.Drawing.Point(131, 163);
            this.txtDonvidaotao.Name = "txtDonvidaotao";
            this.txtDonvidaotao.Size = new System.Drawing.Size(260, 20);
            this.txtDonvidaotao.TabIndex = 9;
            // 
            // txtCoso
            // 
            this.txtCoso.Location = new System.Drawing.Point(131, 203);
            this.txtCoso.Name = "txtCoso";
            this.txtCoso.Size = new System.Drawing.Size(260, 20);
            this.txtCoso.TabIndex = 10;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Location = new System.Drawing.Point(316, 247);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(75, 23);
            this.btnQuayVe.TabIndex = 11;
            this.btnQuayVe.Text = "Quay ve";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 282);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.txtCoso);
            this.Controls.Add(this.txtDonvidaotao);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            //this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtDonvidaotao;
        private System.Windows.Forms.TextBox txtCoso;
        private System.Windows.Forms.Button btnQuayVe;
    }
}