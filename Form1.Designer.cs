namespace CCPTTKHT
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HinhVuong = new System.Windows.Forms.Button();
            this.btn_HinhTamGia = new System.Windows.Forms.Button();
            this.btn_HinhTron = new System.Windows.Forms.Button();
            this.btn_HinhChuNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính diện tích các hình";
            // 
            // btn_HinhVuong
            // 
            this.btn_HinhVuong.Location = new System.Drawing.Point(193, 76);
            this.btn_HinhVuong.Name = "btn_HinhVuong";
            this.btn_HinhVuong.Size = new System.Drawing.Size(99, 29);
            this.btn_HinhVuong.TabIndex = 2;
            this.btn_HinhVuong.Text = "Hình Vuông";
            this.btn_HinhVuong.UseVisualStyleBackColor = true;
            this.btn_HinhVuong.Click += new System.EventHandler(this.btn_HinhVuong_Click);
            // 
            // btn_HinhTamGia
            // 
            this.btn_HinhTamGia.Location = new System.Drawing.Point(317, 76);
            this.btn_HinhTamGia.Name = "btn_HinhTamGia";
            this.btn_HinhTamGia.Size = new System.Drawing.Size(119, 29);
            this.btn_HinhTamGia.TabIndex = 3;
            this.btn_HinhTamGia.Text = "Hình Tam Giác";
            this.btn_HinhTamGia.UseVisualStyleBackColor = true;
            this.btn_HinhTamGia.Click += new System.EventHandler(this.btn_HinhTamGia_Click);
            // 
            // btn_HinhTron
            // 
            this.btn_HinhTron.Location = new System.Drawing.Point(462, 76);
            this.btn_HinhTron.Name = "btn_HinhTron";
            this.btn_HinhTron.Size = new System.Drawing.Size(92, 29);
            this.btn_HinhTron.TabIndex = 4;
            this.btn_HinhTron.Text = "Hình Tròn";
            this.btn_HinhTron.UseVisualStyleBackColor = true;
            this.btn_HinhTron.Click += new System.EventHandler(this.btn_HinhTron_Click);
            // 
            // btn_HinhChuNhat
            // 
            this.btn_HinhChuNhat.Location = new System.Drawing.Point(42, 76);
            this.btn_HinhChuNhat.Name = "btn_HinhChuNhat";
            this.btn_HinhChuNhat.Size = new System.Drawing.Size(119, 29);
            this.btn_HinhChuNhat.TabIndex = 5;
            this.btn_HinhChuNhat.Text = "Hình Chữ Nhật";
            this.btn_HinhChuNhat.UseVisualStyleBackColor = true;
            this.btn_HinhChuNhat.Click += new System.EventHandler(this.btn_HinhChuNhat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 182);
            this.Controls.Add(this.btn_HinhChuNhat);
            this.Controls.Add(this.btn_HinhTron);
            this.Controls.Add(this.btn_HinhTamGia);
            this.Controls.Add(this.btn_HinhVuong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HinhVuong;
        private System.Windows.Forms.Button btn_HinhTamGia;
        private System.Windows.Forms.Button btn_HinhTron;
        private System.Windows.Forms.Button btn_HinhChuNhat;
    }
}

