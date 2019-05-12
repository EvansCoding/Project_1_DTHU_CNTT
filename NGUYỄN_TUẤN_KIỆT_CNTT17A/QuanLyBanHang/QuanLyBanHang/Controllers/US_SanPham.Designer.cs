namespace QuanLyBanHang.Controllers
{
    partial class US_SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_SanPham));
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THUONGHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONGTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntAddSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvSanPham.ColumnHeadersHeight = 53;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MASP,
            this.TENSP,
            this.THUONGHIEU,
            this.THONGTIN,
            this.LOAISP,
            this.SOLUONG,
            this.GIANHAP,
            this.GIABAN,
            this.TIME,
            this.MANCC,
            this.MANK,
            this.check});
            this.dtgvSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvSanPham.EnableHeadersVisualStyles = false;
            this.dtgvSanPham.Location = new System.Drawing.Point(0, -1);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvSanPham.RowHeadersVisible = false;
            this.dtgvSanPham.Size = new System.Drawing.Size(977, 448);
            this.dtgvSanPham.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // MASP
            // 
            this.MASP.HeaderText = "Mã Sản Phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.HeaderText = "Tên Sản Phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 115;
            // 
            // THUONGHIEU
            // 
            this.THUONGHIEU.HeaderText = "Thương Hiệu";
            this.THUONGHIEU.Name = "THUONGHIEU";
            this.THUONGHIEU.ReadOnly = true;
            this.THUONGHIEU.Width = 60;
            // 
            // THONGTIN
            // 
            this.THONGTIN.HeaderText = "THÔNG TIN";
            this.THONGTIN.Name = "THONGTIN";
            this.THONGTIN.ReadOnly = true;
            this.THONGTIN.Width = 120;
            // 
            // LOAISP
            // 
            this.LOAISP.HeaderText = "Loại Sản Phẩm";
            this.LOAISP.Name = "LOAISP";
            this.LOAISP.ReadOnly = true;
            this.LOAISP.Width = 50;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 50;
            // 
            // GIANHAP
            // 
            dataGridViewCellStyle2.Format = "#,### VNĐ";
            this.GIANHAP.DefaultCellStyle = dataGridViewCellStyle2;
            this.GIANHAP.HeaderText = "Giá Nhập";
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.ReadOnly = true;
            // 
            // GIABAN
            // 
            dataGridViewCellStyle3.Format = "#,### VNĐ";
            this.GIABAN.DefaultCellStyle = dataGridViewCellStyle3;
            this.GIABAN.HeaderText = "Giá Bán";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            // 
            // TIME
            // 
            this.TIME.HeaderText = "Thời Gian Nhập";
            this.TIME.Name = "TIME";
            this.TIME.ReadOnly = true;
            // 
            // MANCC
            // 
            this.MANCC.HeaderText = "Mã Nhà CC";
            this.MANCC.Name = "MANCC";
            this.MANCC.Width = 55;
            // 
            // MANK
            // 
            this.MANK.HeaderText = "Mã Nhà Kho";
            this.MANK.Name = "MANK";
            this.MANK.ReadOnly = true;
            this.MANK.Width = 55;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bntAddSP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 574);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(762, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 29);
            this.textBox1.TabIndex = 65;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.AutoSize = true;
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(647, 46);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 21);
            this.lbTimer.TabIndex = 36;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(363, 87);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(166, 32);
            this.btnRemove.TabIndex = 63;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(762, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(319, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 43;
            // 
            // bntAddSP
            // 
            this.bntAddSP.FlatAppearance.BorderSize = 2;
            this.bntAddSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAddSP.ForeColor = System.Drawing.Color.White;
            this.bntAddSP.Location = new System.Drawing.Point(148, 87);
            this.bntAddSP.Name = "bntAddSP";
            this.bntAddSP.Size = new System.Drawing.Size(166, 32);
            this.bntAddSP.TabIndex = 61;
            this.bntAddSP.Text = "Thêm";
            this.bntAddSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntAddSP.UseVisualStyleBackColor = true;
            this.bntAddSP.Click += new System.EventHandler(this.bntAddSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sản Phẩm";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(104, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 35);
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 83);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dtgvSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 447);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(588, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "Tìm Kiếm Theo Tên:";
            // 
            // US_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "US_SanPham";
            this.Size = new System.Drawing.Size(983, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bntAddSP;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn THUONGHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONGTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.Label label4;
    }
}
