namespace QuanLyBanHang.Views.Thống_Kê_Bán_Hàng
{
    partial class fShowDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowDonHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTenNVshowDH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThanhTienhowDH = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTGianXuatshowDH = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTenKHshowDH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaDHshowDH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbTenNVshowDH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbThanhTienhowDH);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbTGianXuatshowDH);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbTenKHshowDH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbMaDHshowDH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 445);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(583, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbTenNVshowDH
            // 
            this.lbTenNVshowDH.AutoSize = true;
            this.lbTenNVshowDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNVshowDH.ForeColor = System.Drawing.Color.White;
            this.lbTenNVshowDH.Location = new System.Drawing.Point(221, 128);
            this.lbTenNVshowDH.Name = "lbTenNVshowDH";
            this.lbTenNVshowDH.Size = new System.Drawing.Size(32, 19);
            this.lbTenNVshowDH.TabIndex = 14;
            this.lbTenNVshowDH.Text = "Tên";
            this.lbTenNVshowDH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhân Viên:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dtgvThongKe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 231);
            this.panel2.TabIndex = 11;
            // 
            // lbThanhTienhowDH
            // 
            this.lbThanhTienhowDH.AutoSize = true;
            this.lbThanhTienhowDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTienhowDH.ForeColor = System.Drawing.Color.White;
            this.lbThanhTienhowDH.Location = new System.Drawing.Point(221, 185);
            this.lbThanhTienhowDH.Name = "lbThanhTienhowDH";
            this.lbThanhTienhowDH.Size = new System.Drawing.Size(34, 19);
            this.lbThanhTienhowDH.TabIndex = 10;
            this.lbThanhTienhowDH.Text = "Tiền";
            this.lbThanhTienhowDH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(96, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Thành Tiền:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTGianXuatshowDH
            // 
            this.lbTGianXuatshowDH.AutoSize = true;
            this.lbTGianXuatshowDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGianXuatshowDH.ForeColor = System.Drawing.Color.White;
            this.lbTGianXuatshowDH.Location = new System.Drawing.Point(221, 158);
            this.lbTGianXuatshowDH.Name = "lbTGianXuatshowDH";
            this.lbTGianXuatshowDH.Size = new System.Drawing.Size(38, 19);
            this.lbTGianXuatshowDH.TabIndex = 8;
            this.lbTGianXuatshowDH.Text = "Time";
            this.lbTGianXuatshowDH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(96, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Thời Gian Xuất:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenKHshowDH
            // 
            this.lbTenKHshowDH.AutoSize = true;
            this.lbTenKHshowDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKHshowDH.ForeColor = System.Drawing.Color.White;
            this.lbTenKHshowDH.Location = new System.Drawing.Point(221, 95);
            this.lbTenKHshowDH.Name = "lbTenKHshowDH";
            this.lbTenKHshowDH.Size = new System.Drawing.Size(32, 19);
            this.lbTenKHshowDH.TabIndex = 6;
            this.lbTenKHshowDH.Text = "Tên";
            this.lbTenKHshowDH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(96, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Khách Hàng:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaDHshowDH
            // 
            this.lbMaDHshowDH.AutoSize = true;
            this.lbMaDHshowDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDHshowDH.ForeColor = System.Drawing.Color.White;
            this.lbMaDHshowDH.Location = new System.Drawing.Point(221, 62);
            this.lbMaDHshowDH.Name = "lbMaDHshowDH";
            this.lbMaDHshowDH.Size = new System.Drawing.Size(31, 19);
            this.lbMaDHshowDH.TabIndex = 2;
            this.lbMaDHshowDH.Text = "DH";
            this.lbMaDHshowDH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đơn Hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Đơn Hàng";
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvThongKe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvThongKe.ColumnHeadersHeight = 32;
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MASP,
            this.TENSP,
            this.SOLUONG,
            this.THANHTIEN});
            this.dtgvThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvThongKe.EnableHeadersVisualStyles = false;
            this.dtgvThongKe.Location = new System.Drawing.Point(0, 0);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.RowHeadersVisible = false;
            this.dtgvThongKe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvThongKe.Size = new System.Drawing.Size(492, 231);
            this.dtgvThongKe.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 30;
            // 
            // MASP
            // 
            this.MASP.HeaderText = "Mã SP";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.HeaderText = "Tên SP";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 150;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 50;
            // 
            // THANHTIEN
            // 
            dataGridViewCellStyle3.Format = "#,### VNĐ";
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle3;
            this.THANHTIEN.HeaderText = "Giá";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 200;
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(160)))));
            this.ptbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbClose.BackgroundImage")));
            this.ptbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbClose.Location = new System.Drawing.Point(461, 3);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(36, 29);
            this.ptbClose.TabIndex = 16;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.PtbClose_Click);
            // 
            // fShowDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fShowDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showDonHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTenKHshowDH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaDHshowDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbThanhTienhowDH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTGianXuatshowDH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTenNVshowDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.PictureBox ptbClose;
    }
}