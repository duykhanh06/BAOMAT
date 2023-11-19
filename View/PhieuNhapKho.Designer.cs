namespace bai1.View
{
    partial class PhieuNhapKho
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
            pnkho = new Panel();
            phieunhap = new Label();
            sophieu = new Label();
            sp = new TextBox();
            sohd = new Label();
            shd = new TextBox();
            makho = new Label();
            combomakho = new ComboBox();
            ngay = new Label();
            ng = new TextBox();
            ngayhd = new Label();
            nghd = new TextBox();
            dvph = new Label();
            donviph = new TextBox();
            dgDetails = new DataGridView();
            MaHangHoa = new DataGridViewTextBoxColumn();
            TenHangHoa = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            Dongia = new DataGridViewTextBoxColumn();
            Thanhtien = new DataGridViewTextBoxColumn();
            save = new Button();
            close = new Button();
            nguoigiao = new Label();
            ngg = new TextBox();
            pnkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetails).BeginInit();
            SuspendLayout();
            // 
            // pnkho
            // 
            pnkho.Controls.Add(phieunhap);
            pnkho.Location = new Point(0, 0);
            pnkho.Name = "pnkho";
            pnkho.Size = new Size(802, 69);
            pnkho.TabIndex = 0;
            pnkho.Paint += panel1_Paint;
            // 
            // phieunhap
            // 
            phieunhap.AutoSize = true;
            phieunhap.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phieunhap.Location = new Point(312, 19);
            phieunhap.Name = "phieunhap";
            phieunhap.Size = new Size(252, 36);
            phieunhap.TabIndex = 0;
            phieunhap.Text = "PHIẾU NHẬP KHO\r\n";
            // 
            // sophieu
            // 
            sophieu.AutoSize = true;
            sophieu.Location = new Point(34, 108);
            sophieu.Name = "sophieu";
            sophieu.Size = new Size(67, 20);
            sophieu.TabIndex = 1;
            sophieu.Text = "Số phiếu";
            sophieu.Click += label1_Click;
            // 
            // sp
            // 
            sp.Location = new Point(125, 108);
            sp.Name = "sp";
            sp.Size = new Size(125, 27);
            sp.TabIndex = 2;
            // 
            // sohd
            // 
            sohd.AutoSize = true;
            sohd.Location = new Point(34, 166);
            sohd.Name = "sohd";
            sohd.Size = new Size(85, 20);
            sohd.TabIndex = 3;
            sohd.Text = "Số hóa đơn";
            // 
            // shd
            // 
            shd.Location = new Point(125, 163);
            shd.Name = "shd";
            shd.Size = new Size(125, 27);
            shd.TabIndex = 4;
            // 
            // makho
            // 
            makho.AutoSize = true;
            makho.Location = new Point(34, 225);
            makho.Name = "makho";
            makho.Size = new Size(58, 20);
            makho.TabIndex = 5;
            makho.Text = "Mã kho";
            // 
            // combomakho
            // 
            combomakho.FormattingEnabled = true;
            combomakho.Location = new Point(125, 222);
            combomakho.Name = "combomakho";
            combomakho.Size = new Size(151, 28);
            combomakho.TabIndex = 6;
            // 
            // ngay
            // 
            ngay.AutoSize = true;
            ngay.Location = new Point(290, 111);
            ngay.Name = "ngay";
            ngay.Size = new Size(44, 20);
            ngay.TabIndex = 7;
            ngay.Text = "Ngày";
            // 
            // ng
            // 
            ng.Location = new Point(375, 111);
            ng.Name = "ng";
            ng.Size = new Size(125, 27);
            ng.TabIndex = 8;
            // 
            // ngayhd
            // 
            ngayhd.AutoSize = true;
            ngayhd.Location = new Point(290, 166);
            ngayhd.Name = "ngayhd";
            ngayhd.Size = new Size(70, 20);
            ngayhd.TabIndex = 9;
            ngayhd.Text = "Ngày HĐ";
            // 
            // nghd
            // 
            nghd.Location = new Point(375, 163);
            nghd.Name = "nghd";
            nghd.Size = new Size(125, 27);
            nghd.TabIndex = 10;
            // 
            // dvph
            // 
            dvph.AutoSize = true;
            dvph.Location = new Point(523, 166);
            dvph.Name = "dvph";
            dvph.Size = new Size(122, 20);
            dvph.TabIndex = 11;
            dvph.Text = "Đơn vị phát hành";
            // 
            // donviph
            // 
            donviph.Location = new Point(651, 163);
            donviph.Name = "donviph";
            donviph.Size = new Size(125, 27);
            donviph.TabIndex = 12;
            // 
            // dgDetails
            // 
            dgDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetails.Columns.AddRange(new DataGridViewColumn[] { MaHangHoa, TenHangHoa, DonViTinh, Soluong, Dongia, Thanhtien });
            dgDetails.Location = new Point(0, 256);
            dgDetails.Name = "dgDetails";
            dgDetails.RowHeadersWidth = 51;
            dgDetails.RowTemplate.Height = 29;
            dgDetails.Size = new Size(802, 188);
            dgDetails.TabIndex = 13;
            dgDetails.CellBeginEdit += dgDetails_CellBeginEdit;
            dgDetails.CellContentClick += dgDetails_CellContentClick;
            dgDetails.CellEndEdit += dgDetails_CellEndEdit;
            // 
            // MaHangHoa
            // 
            MaHangHoa.HeaderText = "Mã hàng hóa";
            MaHangHoa.MinimumWidth = 6;
            MaHangHoa.Name = "MaHangHoa";
            MaHangHoa.Width = 125;
            // 
            // TenHangHoa
            // 
            TenHangHoa.HeaderText = "Tên hàng";
            TenHangHoa.MinimumWidth = 6;
            TenHangHoa.Name = "TenHangHoa";
            TenHangHoa.Width = 125;
            // 
            // DonViTinh
            // 
            DonViTinh.HeaderText = "Đơn vị tính";
            DonViTinh.MinimumWidth = 6;
            DonViTinh.Name = "DonViTinh";
            DonViTinh.Width = 125;
            // 
            // Soluong
            // 
            Soluong.HeaderText = "Số lượng";
            Soluong.MinimumWidth = 6;
            Soluong.Name = "Soluong";
            Soluong.Width = 125;
            // 
            // Dongia
            // 
            Dongia.HeaderText = "Đơn giá";
            Dongia.MinimumWidth = 6;
            Dongia.Name = "Dongia";
            Dongia.Width = 125;
            // 
            // Thanhtien
            // 
            Thanhtien.HeaderText = "Thành tiền";
            Thanhtien.MinimumWidth = 6;
            Thanhtien.Name = "Thanhtien";
            Thanhtien.Width = 125;
            // 
            // save
            // 
            save.Location = new Point(523, 221);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 14;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // close
            // 
            close.Location = new Point(664, 222);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 15;
            close.Text = "Close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // nguoigiao
            // 
            nguoigiao.AutoSize = true;
            nguoigiao.Location = new Point(523, 111);
            nguoigiao.Name = "nguoigiao";
            nguoigiao.Size = new Size(85, 20);
            nguoigiao.TabIndex = 16;
            nguoigiao.Text = "Người giao";
            // 
            // ngg
            // 
            ngg.Location = new Point(651, 111);
            ngg.Name = "ngg";
            ngg.Size = new Size(125, 27);
            ngg.TabIndex = 17;
            // 
            // PhieuNhapKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ngg);
            Controls.Add(nguoigiao);
            Controls.Add(close);
            Controls.Add(save);
            Controls.Add(dgDetails);
            Controls.Add(donviph);
            Controls.Add(dvph);
            Controls.Add(nghd);
            Controls.Add(ngayhd);
            Controls.Add(ng);
            Controls.Add(ngay);
            Controls.Add(combomakho);
            Controls.Add(makho);
            Controls.Add(shd);
            Controls.Add(sohd);
            Controls.Add(sp);
            Controls.Add(sophieu);
            Controls.Add(pnkho);
            Name = "PhieuNhapKho";
            Text = "PhieuNhapKho";
            Load += PhieuNhapKho_Load;
            pnkho.ResumeLayout(false);
            pnkho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnkho;
        private Label phieunhap;
        private Label sophieu;
        private TextBox sp;
        private Label sohd;
        private TextBox shd;
        private Label makho;
        private ComboBox combomakho;
        private Label ngay;
        private TextBox ng;
        private Label ngayhd;
        private TextBox nghd;
        private Label dvph;
        private TextBox donviph;
        private DataGridView dgDetails;
        private DataGridViewTextBoxColumn MaHangHoa;
        private DataGridViewTextBoxColumn TenHangHoa;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn Soluong;
        private DataGridViewTextBoxColumn Dongia;
        private DataGridViewTextBoxColumn Thanhtien;
        private Button save;
        private Button close;
        private Label nguoigiao;
        private TextBox ngg;
    }
}