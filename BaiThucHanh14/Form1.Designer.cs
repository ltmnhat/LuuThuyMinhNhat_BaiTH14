namespace BaiThucHanh14
{
    partial class Form1
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
            this.ketnoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.txtTenCSDL = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ketnoi
            // 
            this.ketnoi.AutoSize = true;
            this.ketnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketnoi.Location = new System.Drawing.Point(33, 26);
            this.ketnoi.Name = "ketnoi";
            this.ketnoi.Size = new System.Drawing.Size(272, 25);
            this.ketnoi.TabIndex = 0;
            this.ketnoi.Text = "Ket Noi Dang Nhap He Thong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ten may:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten CSDL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // txtTenMay
            // 
            this.txtTenMay.Location = new System.Drawing.Point(107, 78);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(305, 20);
            this.txtTenMay.TabIndex = 5;
            this.txtTenMay.TextChanged += new System.EventHandler(this.txtTenMay_TextChanged);
            // 
            // txtTenCSDL
            // 
            this.txtTenCSDL.Location = new System.Drawing.Point(107, 112);
            this.txtTenCSDL.Name = "txtTenCSDL";
            this.txtTenCSDL.Size = new System.Drawing.Size(305, 20);
            this.txtTenCSDL.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(107, 148);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(305, 20);
            this.txtUser.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(107, 187);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(305, 20);
            this.txtPass.TabIndex = 8;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(232, 248);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoi.TabIndex = 9;
            this.btnKetNoi.Text = "Ket Noi";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(338, 248);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 289);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtTenCSDL);
            this.Controls.Add(this.txtTenMay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ketnoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ketnoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.TextBox txtTenCSDL;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnThoat;

    }
}

