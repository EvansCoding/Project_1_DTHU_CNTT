namespace QuanLyBanHang.Controllers
{
    partial class US_ThongKeBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_ThongKeBanHang));
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.dTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbTimer = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cbbQuy = new System.Windows.Forms.ComboBox();
            this.cbbSelectThongKe = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvThongKe);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 448);
            this.panel2.TabIndex = 0;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvThongKe.ColumnHeadersHeight = 32;
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MADH,
            this.TENKH,
            this.TENNV,
            this.TIME,
            this.THANHTIEN});
            this.dtgvThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvThongKe.EnableHeadersVisualStyles = false;
            this.dtgvThongKe.Location = new System.Drawing.Point(0, 3);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.RowHeadersVisible = false;
            this.dtgvThongKe.Size = new System.Drawing.Size(977, 445);
            this.dtgvThongKe.TabIndex = 1;
            this.dtgvThongKe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DtgvThongKe_MouseDoubleClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MADH
            // 
            this.MADH.HeaderText = "Mã Đơn Hàng";
            this.MADH.Name = "MADH";
            this.MADH.ReadOnly = true;
            this.MADH.Width = 200;
            // 
            // TENKH
            // 
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 200;
            // 
            // TENNV
            // 
            this.TENNV.HeaderText = "Tên Nhân Viên";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            this.TENNV.Width = 150;
            // 
            // TIME
            // 
            this.TIME.HeaderText = "Thời Gian Xuất";
            this.TIME.Name = "TIME";
            this.TIME.ReadOnly = true;
            this.TIME.Width = 200;
            // 
            // THANHTIEN
            // 
            dataGridViewCellStyle3.Format = "#,### VNĐ";
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle3;
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 200;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 5);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống Kê Bán Hàng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(105, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.White;
            this.lbTongTien.Location = new System.Drawing.Point(149, 76);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(21, 23);
            this.lbTongTien.TabIndex = 5;
            this.lbTongTien.Text = "0";
            // 
            // dTimePicker
            // 
            this.dTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.dTimePicker.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dTimePicker.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dTimePicker.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimePicker.Location = new System.Drawing.Point(813, 35);
            this.dTimePicker.Name = "dTimePicker";
            this.dTimePicker.Size = new System.Drawing.Size(120, 29);
            this.dTimePicker.TabIndex = 7;
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.AutoSize = true;
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(645, 41);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 21);
            this.lbTimer.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(14, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 83);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.cbbQuy);
            this.panel1.Controls.Add(this.cbbSelectThongKe);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.dTimePicker);
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 574);
            this.panel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(813, 77);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(120, 28);
            this.btnThongKe.TabIndex = 17;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // cbbQuy
            // 
            this.cbbQuy.FormattingEnabled = true;
            this.cbbQuy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cbbQuy.Location = new System.Drawing.Point(716, 76);
            this.cbbQuy.Name = "cbbQuy";
            this.cbbQuy.Size = new System.Drawing.Size(91, 29);
            this.cbbQuy.TabIndex = 16;
            // 
            // cbbSelectThongKe
            // 
            this.cbbSelectThongKe.FormattingEnabled = true;
            this.cbbSelectThongKe.Items.AddRange(new object[] {
            "Tổng",
            "Ngày",
            "Tháng",
            "Năm",
            "Quý"});
            this.cbbSelectThongKe.Location = new System.Drawing.Point(619, 76);
            this.cbbSelectThongKe.Name = "cbbSelectThongKe";
            this.cbbSelectThongKe.Size = new System.Drawing.Size(91, 29);
            this.cbbSelectThongKe.TabIndex = 15;
            this.cbbSelectThongKe.SelectedIndexChanged += new System.EventHandler(this.CbbSelectThongKe_SelectedIndexChanged);
            // 
            // US_ThongKeBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "US_ThongKeBanHang";
            this.Size = new System.Drawing.Size(983, 580);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvThongKe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DateTimePicker dTimePicker;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.ComboBox cbbQuy;
        private System.Windows.Forms.ComboBox cbbSelectThongKe;
        private System.Windows.Forms.Button btnThongKe;
    }
}
