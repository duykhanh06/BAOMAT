namespace cuoiki.Views
{
    partial class MDI
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            khoXeToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpXeToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpXeToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { danhMụcToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khoXeToolStripMenuItem, phiếuNhậpXeToolStripMenuItem, phiếuNhậpXeToolStripMenuItem1 });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // khoXeToolStripMenuItem
            // 
            khoXeToolStripMenuItem.Name = "khoXeToolStripMenuItem";
            khoXeToolStripMenuItem.Size = new Size(224, 26);
            khoXeToolStripMenuItem.Text = "Kho xe";
            khoXeToolStripMenuItem.Click += khoXeToolStripMenuItem_Click;
            // 
            // phiếuNhậpXeToolStripMenuItem
            // 
            phiếuNhậpXeToolStripMenuItem.Name = "phiếuNhậpXeToolStripMenuItem";
            phiếuNhậpXeToolStripMenuItem.Size = new Size(224, 26);
            phiếuNhậpXeToolStripMenuItem.Text = "Nhà cung cấp";
            phiếuNhậpXeToolStripMenuItem.Click += phiếuNhậpXeToolStripMenuItem_Click;
            // 
            // phiếuNhậpXeToolStripMenuItem1
            // 
            phiếuNhậpXeToolStripMenuItem1.Name = "phiếuNhậpXeToolStripMenuItem1";
            phiếuNhậpXeToolStripMenuItem1.Size = new Size(224, 26);
            phiếuNhậpXeToolStripMenuItem1.Text = "Phiếu nhập xe";
            phiếuNhậpXeToolStripMenuItem1.Click += phiếuNhậpXeToolStripMenuItem1_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "MDI";
            Text = "MDI";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem khoXeToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpXeToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpXeToolStripMenuItem1;
    }
}