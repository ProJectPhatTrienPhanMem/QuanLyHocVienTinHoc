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
            this.duLieu = new QL_HocVien.DuLieu();
            this.hOCVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCVIENTableAdapter = new QL_HocVien.DuLieuTableAdapters.HOCVIENTableAdapter();
            this.tableAdapterManager = new QL_HocVien.DuLieuTableAdapters.TableAdapterManager();
            this.hOCVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thêmHọcSinhToolStripMenuItem});
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
            // hOCVIENDataGridView
            // 
            this.hOCVIENDataGridView.AutoGenerateColumns = false;
            this.hOCVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hOCVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hOCVIENDataGridView.DataSource = this.hOCVIENBindingSource;
            this.hOCVIENDataGridView.Location = new System.Drawing.Point(0, 99);
            this.hOCVIENDataGridView.Name = "hOCVIENDataGridView";
            this.hOCVIENDataGridView.Size = new System.Drawing.Size(646, 259);
            this.hOCVIENDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHV";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenHV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "NgaySinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DienThoai";
            this.dataGridViewTextBoxColumn5.HeaderText = "DienThoai";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn6.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 355);
            this.Controls.Add(this.hOCVIENDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCVIENDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView hOCVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}