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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duLieu = new QL_HocVien.DuLieu();
            this.hOCVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCVIENTableAdapter = new QL_HocVien.DuLieuTableAdapters.HOCVIENTableAdapter();
            this.tableAdapterManager = new QL_HocVien.DuLieuTableAdapters.TableAdapterManager();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thêmHọcSinhToolStripMenuItem,
            this.mônHọcToolStripMenuItem,
            this.khóaHọcToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
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
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mônHọcToolStripMenuItem.Text = "Môn Học";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // khóaHọcToolStripMenuItem
            // 
            this.khóaHọcToolStripMenuItem.Name = "khóaHọcToolStripMenuItem";
            this.khóaHọcToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.khóaHọcToolStripMenuItem.Text = "Khóa Học";
            this.khóaHọcToolStripMenuItem.Click += new System.EventHandler(this.khóaHọcToolStripMenuItem_Click);
            // 
            // duLieu
            // 
            this.duLieu.DataSetName = "DuLieu";
            this.duLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCVIENBindingSource
            // 
            this.hOCVIENBindingSource.DataMember = "HOCVIEN";
            this.hOCVIENBindingSource.DataSource = this.duLieu;
            // 
            // hOCVIENTableAdapter
            // 
            this.hOCVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAHOCTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.HOCVIENTableAdapter = this.hOCVIENTableAdapter;
            this.tableAdapterManager.KHOAHOCTableAdapter = null;
            this.tableAdapterManager.KYTHITableAdapter = null;
            this.tableAdapterManager.LOPHOCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_HocVien.DuLieuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.giảngViênToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnLíToolStripMenuItem.Text = "Quản Lý";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên";
            // 
            // giảngViênToolStripMenuItem
            // 
            this.giảngViênToolStripMenuItem.Name = "giảngViênToolStripMenuItem";
            this.giảngViênToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.giảngViênToolStripMenuItem.Text = "Giảng Viên";
            this.giảngViênToolStripMenuItem.Click += new System.EventHandler(this.giảngViênToolStripMenuItem_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 355);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngToolStripMenuItem;
        private DuLieu duLieu;
        private System.Windows.Forms.BindingSource hOCVIENBindingSource;
        private DuLieuTableAdapters.HOCVIENTableAdapter hOCVIENTableAdapter;
        private DuLieuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảngViênToolStripMenuItem;
    }
}