namespace bai1
{
    partial class QLK
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            makho = new TextBox();
            tenkho = new TextBox();
            diachi = new TextBox();
            button1 = new Button();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btntimkiem = new Button();
            timkiem = new TextBox();
            dtgv_kho = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgv_kho).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Lucida Sans", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(382, 68);
            label1.TabIndex = 0;
            label1.Text = "Quản lí kho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 135);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 174);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên kho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 212);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // makho
            // 
            makho.Location = new Point(169, 134);
            makho.Name = "makho";
            makho.Size = new Size(216, 27);
            makho.TabIndex = 4;
            // 
            // tenkho
            // 
            tenkho.Location = new Point(169, 174);
            tenkho.Name = "tenkho";
            tenkho.Size = new Size(216, 27);
            tenkho.TabIndex = 5;
            // 
            // diachi
            // 
            diachi.Location = new Point(169, 212);
            diachi.Name = "diachi";
            diachi.Size = new Size(216, 27);
            diachi.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(59, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(159, 252);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 9;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click_1;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(259, 252);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 10;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click_1;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(359, 252);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 11;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(624, 174);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 12;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(493, 175);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(125, 27);
            timkiem.TabIndex = 13;
            // 
            // dtgv_kho
            // 
            dtgv_kho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_kho.Location = new Point(25, 319);
            dtgv_kho.Name = "dtgv_kho";
            dtgv_kho.RowHeadersWidth = 51;
            dtgv_kho.RowTemplate.Height = 29;
            dtgv_kho.Size = new Size(747, 119);
            dtgv_kho.TabIndex = 14;
            dtgv_kho.CellClick += dtgv_kho_CellClick;
            dtgv_kho.CellContentClick += dtgv_kho_CellContentClick;
            // 
            // QLK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgv_kho);
            Controls.Add(timkiem);
            Controls.Add(btntimkiem);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(button1);
            Controls.Add(diachi);
            Controls.Add(tenkho);
            Controls.Add(makho);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QLK";
            Text = "QLK";
            Load += QLK_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_kho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox makho;
        private TextBox tenkho;
        private TextBox diachi;
        private Button button1;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Button btntimkiem;
        private TextBox timkiem;
        private DataGridView dtgv_kho;
    }
}