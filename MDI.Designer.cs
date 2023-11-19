namespace bai1
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            danhMucToolStripMenuItem = new ToolStripMenuItem();
            khoToolStripMenuItem = new ToolStripMenuItem();
            phiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, danhMucToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // danhMucToolStripMenuItem
            // 
            danhMucToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khoToolStripMenuItem, phiToolStripMenuItem });
            danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            danhMucToolStripMenuItem.Size = new Size(90, 24);
            danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(224, 26);
            khoToolStripMenuItem.Text = "Kho";
            khoToolStripMenuItem.Click += khoToolStripMenuItem_Click;
            // 
            // phiToolStripMenuItem
            // 
            phiToolStripMenuItem.Name = "phiToolStripMenuItem";
            phiToolStripMenuItem.Size = new Size(224, 26);
            phiToolStripMenuItem.Text = "Phiếu nhập kho";
            phiToolStripMenuItem.Click += phiToolStripMenuItem_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MDI";
            Text = "MDI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem danhMucToolStripMenuItem;
        private ToolStripMenuItem khoToolStripMenuItem;
        private ToolStripMenuItem phiToolStripMenuItem;
    }
}