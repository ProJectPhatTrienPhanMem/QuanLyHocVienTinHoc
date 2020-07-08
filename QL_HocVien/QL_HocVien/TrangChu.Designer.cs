namespace QL_HocVien
{
    partial class TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thêmHọcSinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNgườiDùngToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thêmNgườiDùngToolStripMenuItem
            // 
            this.thêmNgườiDùngToolStripMenuItem.Name = "thêmNgườiDùngToolStripMenuItem";
            this.thêmNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.thêmNgườiDùngToolStripMenuItem.Text = "Thêm Người Dùng";
            this.thêmNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDùngToolStripMenuItem_Click);
            // 
            // thêmHọcSinhToolStripMenuItem
            // 
            this.thêmHọcSinhToolStripMenuItem.Name = "thêmHọcSinhToolStripMenuItem";
            this.thêmHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.thêmHọcSinhToolStripMenuItem.Text = "Thêm Học Sinh";
            this.thêmHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.thêmHọcSinhToolStripMenuItem_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngToolStripMenuItem;
    }
}