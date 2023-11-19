namespace cuoiki
{
    partial class QLX
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_qlx = new Label();
            lb_maxe = new Label();
            lb_tenxe = new Label();
            lb_gia = new Label();
            lb_soluong = new Label();
            txt_maxe = new TextBox();
            txt_tenxe = new TextBox();
            txt_gia = new TextBox();
            txt_soluong = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            txt_timkiem = new TextBox();
            btn_timkiem = new Button();
            dtgv_qlx = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgv_qlx).BeginInit();
            SuspendLayout();
            // 
            // lb_qlx
            // 
            lb_qlx.AutoSize = true;
            lb_qlx.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lb_qlx.Location = new Point(242, 18);
            lb_qlx.Name = "lb_qlx";
            lb_qlx.Size = new Size(253, 46);
            lb_qlx.TabIndex = 0;
            lb_qlx.Text = "Quản lí xe ô tô";
            // 
            // lb_maxe
            // 
            lb_maxe.AutoSize = true;
            lb_maxe.Location = new Point(25, 101);
            lb_maxe.Name = "lb_maxe";
            lb_maxe.Size = new Size(49, 20);
            lb_maxe.TabIndex = 1;
            lb_maxe.Text = "Mã xe";
            // 
            // lb_tenxe
            // 
            lb_tenxe.AutoSize = true;
            lb_tenxe.Location = new Point(25, 151);
            lb_tenxe.Name = "lb_tenxe";
            lb_tenxe.Size = new Size(51, 20);
            lb_tenxe.TabIndex = 2;
            lb_tenxe.Text = "Tên xe";
            // 
            // lb_gia
            // 
            lb_gia.AutoSize = true;
            lb_gia.Location = new Point(288, 101);
            lb_gia.Name = "lb_gia";
            lb_gia.Size = new Size(31, 20);
            lb_gia.TabIndex = 3;
            lb_gia.Text = "Giá";
            // 
            // lb_soluong
            // 
            lb_soluong.AutoSize = true;
            lb_soluong.Location = new Point(260, 151);
            lb_soluong.Name = "lb_soluong";
            lb_soluong.Size = new Size(69, 20);
            lb_soluong.TabIndex = 4;
            lb_soluong.Text = "Số lượng";
            // 
            // txt_maxe
            // 
            txt_maxe.Location = new Point(106, 98);
            txt_maxe.Name = "txt_maxe";
            txt_maxe.ScrollBars = ScrollBars.Both;
            txt_maxe.Size = new Size(125, 27);
            txt_maxe.TabIndex = 5;
            // 
            // txt_tenxe
            // 
            txt_tenxe.Location = new Point(106, 144);
            txt_tenxe.Name = "txt_tenxe";
            txt_tenxe.Size = new Size(125, 27);
            txt_tenxe.TabIndex = 6;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(335, 98);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(125, 27);
            txt_gia.TabIndex = 7;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(335, 144);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(125, 27);
            txt_soluong.TabIndex = 8;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(119, 211);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 9;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(260, 211);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 10;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(425, 211);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 11;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(567, 213);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(125, 27);
            txt_timkiem.TabIndex = 12;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(698, 213);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 13;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // dtgv_qlx
            // 
            dtgv_qlx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_qlx.Location = new Point(29, 250);
            dtgv_qlx.Name = "dtgv_qlx";
            dtgv_qlx.RowHeadersWidth = 51;
            dtgv_qlx.RowTemplate.Height = 29;
            dtgv_qlx.Size = new Size(728, 188);
            dtgv_qlx.TabIndex = 14;
            dtgv_qlx.CellClick += dtgv_qlx_CellClick;
            dtgv_qlx.CellContentClick += dtgv_qlx_CellContentClick;
            // 
            // QLX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgv_qlx);
            Controls.Add(btn_timkiem);
            Controls.Add(txt_timkiem);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(txt_soluong);
            Controls.Add(txt_gia);
            Controls.Add(txt_tenxe);
            Controls.Add(txt_maxe);
            Controls.Add(lb_soluong);
            Controls.Add(lb_gia);
            Controls.Add(lb_tenxe);
            Controls.Add(lb_maxe);
            Controls.Add(lb_qlx);
            Name = "QLX";
            Text = "Form1";
            Load += QLX_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_qlx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_qlx;
        private Label lb_maxe;
        private Label lb_tenxe;
        private Label lb_gia;
        private Label lb_soluong;
        private TextBox txt_maxe;
        private TextBox txt_tenxe;
        private TextBox txt_gia;
        private TextBox txt_soluong;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private TextBox txt_timkiem;
        private Button btn_timkiem;
        private DataGridView dtgv_qlx;
    }
}