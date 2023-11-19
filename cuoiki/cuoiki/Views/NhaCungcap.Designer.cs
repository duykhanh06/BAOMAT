namespace cuoiki.Views
{
    partial class NhaCungcap
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
            lb_nhacungcap = new Label();
            lb_mncc = new Label();
            lb_tennhacungcap = new Label();
            lb_diachi = new Label();
            txt_mncc = new TextBox();
            txt_tenncc = new TextBox();
            txt_diachi = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            txt_timkiem = new TextBox();
            btn_timkiem = new Button();
            dtgv_nhacungcap = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgv_nhacungcap).BeginInit();
            SuspendLayout();
            // 
            // lb_nhacungcap
            // 
            lb_nhacungcap.AutoSize = true;
            lb_nhacungcap.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nhacungcap.Location = new Point(257, 30);
            lb_nhacungcap.Name = "lb_nhacungcap";
            lb_nhacungcap.Size = new Size(237, 46);
            lb_nhacungcap.TabIndex = 0;
            lb_nhacungcap.Text = "Nhà cung cấp";
            // 
            // lb_mncc
            // 
            lb_mncc.AutoSize = true;
            lb_mncc.Location = new Point(51, 107);
            lb_mncc.Name = "lb_mncc";
            lb_mncc.Size = new Size(122, 20);
            lb_mncc.TabIndex = 1;
            lb_mncc.Text = "Mã nhà cung cấp";
            // 
            // lb_tennhacungcap
            // 
            lb_tennhacungcap.AutoSize = true;
            lb_tennhacungcap.Location = new Point(51, 139);
            lb_tennhacungcap.Name = "lb_tennhacungcap";
            lb_tennhacungcap.Size = new Size(124, 20);
            lb_tennhacungcap.TabIndex = 2;
            lb_tennhacungcap.Text = "Tên nhà cung cấp";
            // 
            // lb_diachi
            // 
            lb_diachi.AutoSize = true;
            lb_diachi.Location = new Point(72, 170);
            lb_diachi.Name = "lb_diachi";
            lb_diachi.Size = new Size(55, 20);
            lb_diachi.TabIndex = 3;
            lb_diachi.Text = "Địa chỉ";
            // 
            // txt_mncc
            // 
            txt_mncc.Location = new Point(192, 104);
            txt_mncc.Name = "txt_mncc";
            txt_mncc.Size = new Size(125, 27);
            txt_mncc.TabIndex = 4;
            // 
            // txt_tenncc
            // 
            txt_tenncc.Location = new Point(192, 137);
            txt_tenncc.Name = "txt_tenncc";
            txt_tenncc.Size = new Size(125, 27);
            txt_tenncc.TabIndex = 5;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(192, 170);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(125, 27);
            txt_diachi.TabIndex = 6;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(192, 222);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(292, 222);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 8;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(392, 222);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 9;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(512, 224);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(125, 27);
            txt_timkiem.TabIndex = 10;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(643, 224);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 11;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // dtgv_nhacungcap
            // 
            dtgv_nhacungcap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_nhacungcap.Location = new Point(29, 257);
            dtgv_nhacungcap.Name = "dtgv_nhacungcap";
            dtgv_nhacungcap.RowHeadersWidth = 51;
            dtgv_nhacungcap.RowTemplate.Height = 29;
            dtgv_nhacungcap.Size = new Size(717, 188);
            dtgv_nhacungcap.TabIndex = 12;
            dtgv_nhacungcap.CellClick += dtgv_nhacungcap_CellClick;
            dtgv_nhacungcap.CellContentClick += dtgv_nhacungcap_CellContentClick;
            // 
            // NhaCungcap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgv_nhacungcap);
            Controls.Add(btn_timkiem);
            Controls.Add(txt_timkiem);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(txt_diachi);
            Controls.Add(txt_tenncc);
            Controls.Add(txt_mncc);
            Controls.Add(lb_diachi);
            Controls.Add(lb_tennhacungcap);
            Controls.Add(lb_mncc);
            Controls.Add(lb_nhacungcap);
            Name = "NhaCungcap";
            Text = "NhaCungcap";
            Load += NhaCungcap_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_nhacungcap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nhacungcap;
        private Label lb_mncc;
        private Label lb_tennhacungcap;
        private Label lb_diachi;
        private TextBox txt_mncc;
        private TextBox txt_tenncc;
        private TextBox txt_diachi;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private TextBox txt_timkiem;
        private Button btn_timkiem;
        private DataGridView dtgv_nhacungcap;
    }
}