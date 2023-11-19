namespace cuoiki.Views
{
    partial class PhieuNhapXe
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
            combomncc = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            sp = new TextBox();
            ng = new TextBox();
            dataGridChitiet = new DataGridView();
            Buttun = new Button();
            button2 = new Button();
            mpn = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridChitiet).BeginInit();
            SuspendLayout();
            // 
            // combomncc
            // 
            combomncc.FormattingEnabled = true;
            combomncc.Location = new Point(444, 164);
            combomncc.Name = "combomncc";
            combomncc.Size = new Size(146, 28);
            combomncc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 34);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "PHIẾU NHẬP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 103);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Số phiếu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 103);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày";
            // 
            // sp
            // 
            sp.Location = new Point(150, 97);
            sp.Name = "sp";
            sp.Size = new Size(125, 27);
            sp.TabIndex = 12;
            // 
            // ng
            // 
            ng.Location = new Point(444, 104);
            ng.Name = "ng";
            ng.Size = new Size(146, 27);
            ng.TabIndex = 13;
            // 
            // dataGridChitiet
            // 
            dataGridChitiet.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridChitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChitiet.Location = new Point(22, 314);
            dataGridChitiet.Name = "dataGridChitiet";
            dataGridChitiet.RowHeadersWidth = 51;
            dataGridChitiet.RowTemplate.Height = 29;
            dataGridChitiet.Size = new Size(800, 188);
            dataGridChitiet.TabIndex = 19;
            dataGridChitiet.CellContentClick += dataGridView1_CellContentClick;
            dataGridChitiet.CellEndEdit += dataGridChitiet_CellEndEdit;
            dataGridChitiet.Click += dataGridChitiet_Click;
            // 
            // Buttun
            // 
            Buttun.Location = new Point(565, 265);
            Buttun.Name = "Buttun";
            Buttun.Size = new Size(94, 29);
            Buttun.TabIndex = 20;
            Buttun.Text = "Save";
            Buttun.UseVisualStyleBackColor = true;
            Buttun.Click += Save_Click;
            // 
            // button2
            // 
            button2.Location = new Point(707, 265);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Close_Click;
            // 
            // mpn
            // 
            mpn.Location = new Point(150, 165);
            mpn.Name = "mpn";
            mpn.Size = new Size(125, 27);
            mpn.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã phiếu nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 168);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã nhà cung cấp";
            // 
            // PhieuNhapXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 514);
            Controls.Add(button2);
            Controls.Add(Buttun);
            Controls.Add(dataGridChitiet);
            Controls.Add(ng);
            Controls.Add(sp);
            Controls.Add(mpn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combomncc);
            Name = "PhieuNhapXe";
            Text = "PhieuNhapXe";
            Load += PhieuNhapXe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridChitiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combomncc;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label9;
        private TextBox sp;
        private TextBox ng;
        private TextBox textBox7;
        private DataGridView dataGridChitiet;
        private Button Buttun;
        private Button button2;
        private TextBox mpn;
        private Label label3;
        private Label label4;
    }
}