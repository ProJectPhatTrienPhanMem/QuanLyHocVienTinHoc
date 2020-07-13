namespace QL_HocVien
{
    partial class KhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoaHoc));
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label ngayBDLabel;
            System.Windows.Forms.Label ngayKTLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.duLieu = new QL_HocVien.DuLieu();
            this.kHOAHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOAHOCTableAdapter = new QL_HocVien.DuLieuTableAdapters.KHOAHOCTableAdapter();
            this.tableAdapterManager = new QL_HocVien.DuLieuTableAdapters.TableAdapterManager();
            this.kHOAHOCBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kHOAHOCBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kHOAHOCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHTextBox = new System.Windows.Forms.TextBox();
            this.tenKHTextBox = new System.Windows.Forms.TextBox();
            this.ngayBDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ngayKTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            maKHLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            ngayBDLabel = new System.Windows.Forms.Label();
            ngayKTLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCBindingNavigator)).BeginInit();
            this.kHOAHOCBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // duLieu
            // 
            this.duLieu.DataSetName = "DuLieu";
            this.duLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOAHOCBindingSource
            // 
            this.kHOAHOCBindingSource.DataMember = "KHOAHOC";
            this.kHOAHOCBindingSource.DataSource = this.duLieu;
            // 
            // kHOAHOCTableAdapter
            // 
            this.kHOAHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAHOCTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.HOCVIENTableAdapter = null;
            this.tableAdapterManager.KHOAHOCTableAdapter = this.kHOAHOCTableAdapter;
            this.tableAdapterManager.KYTHITableAdapter = null;
            this.tableAdapterManager.LOPHOCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_HocVien.DuLieuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHOAHOCBindingNavigator
            // 
            this.kHOAHOCBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kHOAHOCBindingNavigator.BindingSource = this.kHOAHOCBindingSource;
            this.kHOAHOCBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kHOAHOCBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kHOAHOCBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kHOAHOCBindingNavigatorSaveItem});
            this.kHOAHOCBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kHOAHOCBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kHOAHOCBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kHOAHOCBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kHOAHOCBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kHOAHOCBindingNavigator.Name = "kHOAHOCBindingNavigator";
            this.kHOAHOCBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kHOAHOCBindingNavigator.Size = new System.Drawing.Size(597, 25);
            this.kHOAHOCBindingNavigator.TabIndex = 0;
            this.kHOAHOCBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // kHOAHOCBindingNavigatorSaveItem
            // 
            this.kHOAHOCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kHOAHOCBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kHOAHOCBindingNavigatorSaveItem.Image")));
            this.kHOAHOCBindingNavigatorSaveItem.Name = "kHOAHOCBindingNavigatorSaveItem";
            this.kHOAHOCBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kHOAHOCBindingNavigatorSaveItem.Text = "Save Data";
            this.kHOAHOCBindingNavigatorSaveItem.Click += new System.EventHandler(this.kHOAHOCBindingNavigatorSaveItem_Click);
            // 
            // kHOAHOCDataGridView
            // 
            this.kHOAHOCDataGridView.AutoGenerateColumns = false;
            this.kHOAHOCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHOAHOCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kHOAHOCDataGridView.DataSource = this.kHOAHOCBindingSource;
            this.kHOAHOCDataGridView.Location = new System.Drawing.Point(12, 161);
            this.kHOAHOCDataGridView.Name = "kHOAHOCDataGridView";
            this.kHOAHOCDataGridView.Size = new System.Drawing.Size(565, 228);
            this.kHOAHOCDataGridView.TabIndex = 1;
            this.kHOAHOCDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kHOAHOCDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayBD";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgayBD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayKT";
            this.dataGridViewTextBoxColumn4.HeaderText = "NgayKT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TinhTrang";
            this.dataGridViewTextBoxColumn5.HeaderText = "TinhTrang";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Location = new System.Drawing.Point(17, 31);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(43, 13);
            maKHLabel.TabIndex = 2;
            maKHLabel.Text = "Ma KH:";
            // 
            // maKHTextBox
            // 
            this.maKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOAHOCBindingSource, "MaKH", true));
            this.maKHTextBox.Location = new System.Drawing.Point(85, 28);
            this.maKHTextBox.Name = "maKHTextBox";
            this.maKHTextBox.Size = new System.Drawing.Size(200, 20);
            this.maKHTextBox.TabIndex = 3;
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Location = new System.Drawing.Point(17, 57);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(47, 13);
            tenKHLabel.TabIndex = 4;
            tenKHLabel.Text = "Ten KH:";
            // 
            // tenKHTextBox
            // 
            this.tenKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOAHOCBindingSource, "TenKH", true));
            this.tenKHTextBox.Location = new System.Drawing.Point(85, 54);
            this.tenKHTextBox.Name = "tenKHTextBox";
            this.tenKHTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenKHTextBox.TabIndex = 5;
            // 
            // ngayBDLabel
            // 
            ngayBDLabel.AutoSize = true;
            ngayBDLabel.Location = new System.Drawing.Point(17, 84);
            ngayBDLabel.Name = "ngayBDLabel";
            ngayBDLabel.Size = new System.Drawing.Size(53, 13);
            ngayBDLabel.TabIndex = 6;
            ngayBDLabel.Text = "Ngay BD:";
            // 
            // ngayBDDateTimePicker
            // 
            this.ngayBDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kHOAHOCBindingSource, "NgayBD", true));
            this.ngayBDDateTimePicker.Location = new System.Drawing.Point(85, 80);
            this.ngayBDDateTimePicker.Name = "ngayBDDateTimePicker";
            this.ngayBDDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayBDDateTimePicker.TabIndex = 7;
            // 
            // ngayKTLabel
            // 
            ngayKTLabel.AutoSize = true;
            ngayKTLabel.Location = new System.Drawing.Point(17, 110);
            ngayKTLabel.Name = "ngayKTLabel";
            ngayKTLabel.Size = new System.Drawing.Size(52, 13);
            ngayKTLabel.TabIndex = 8;
            ngayKTLabel.Text = "Ngay KT:";
            // 
            // ngayKTDateTimePicker
            // 
            this.ngayKTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kHOAHOCBindingSource, "NgayKT", true));
            this.ngayKTDateTimePicker.Location = new System.Drawing.Point(85, 106);
            this.ngayKTDateTimePicker.Name = "ngayKTDateTimePicker";
            this.ngayKTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayKTDateTimePicker.TabIndex = 9;
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(17, 135);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(62, 13);
            tinhTrangLabel.TabIndex = 10;
            tinhTrangLabel.Text = "Tinh Trang:";
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOAHOCBindingSource, "TinhTrang", true));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(85, 132);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(200, 20);
            this.tinhTrangTextBox.TabIndex = 11;
            // 
            // KhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 401);
            this.Controls.Add(maKHLabel);
            this.Controls.Add(this.maKHTextBox);
            this.Controls.Add(tenKHLabel);
            this.Controls.Add(this.tenKHTextBox);
            this.Controls.Add(ngayBDLabel);
            this.Controls.Add(this.ngayBDDateTimePicker);
            this.Controls.Add(ngayKTLabel);
            this.Controls.Add(this.ngayKTDateTimePicker);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(this.tinhTrangTextBox);
            this.Controls.Add(this.kHOAHOCDataGridView);
            this.Controls.Add(this.kHOAHOCBindingNavigator);
            this.Name = "KhoaHoc";
            this.Text = "KhoaHoc";
            this.Load += new System.EventHandler(this.KhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCBindingNavigator)).EndInit();
            this.kHOAHOCBindingNavigator.ResumeLayout(false);
            this.kHOAHOCBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DuLieu duLieu;
        private System.Windows.Forms.BindingSource kHOAHOCBindingSource;
        private DuLieuTableAdapters.KHOAHOCTableAdapter kHOAHOCTableAdapter;
        private DuLieuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kHOAHOCBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kHOAHOCBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kHOAHOCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox maKHTextBox;
        private System.Windows.Forms.TextBox tenKHTextBox;
        private System.Windows.Forms.DateTimePicker ngayBDDateTimePicker;
        private System.Windows.Forms.DateTimePicker ngayKTDateTimePicker;
        private System.Windows.Forms.TextBox tinhTrangTextBox;
    }
}