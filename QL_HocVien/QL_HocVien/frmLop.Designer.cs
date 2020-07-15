namespace QL_HocVien
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            System.Windows.Forms.Label maLHLabel;
            System.Windows.Forms.Label tenLHLabel;
            System.Windows.Forms.Label siSoLabel;
            this.duLieu = new QL_HocVien.DuLieu();
            this.lOPHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPHOCTableAdapter = new QL_HocVien.DuLieuTableAdapters.LOPHOCTableAdapter();
            this.tableAdapterManager = new QL_HocVien.DuLieuTableAdapters.TableAdapterManager();
            this.lOPHOCBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lOPHOCBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lOPHOCDataGridView = new System.Windows.Forms.DataGridView();
            this.maLHTextBox = new System.Windows.Forms.TextBox();
            this.tenLHTextBox = new System.Windows.Forms.TextBox();
            this.siSoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maLHLabel = new System.Windows.Forms.Label();
            tenLHLabel = new System.Windows.Forms.Label();
            siSoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPHOCBindingNavigator)).BeginInit();
            this.lOPHOCBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPHOCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // duLieu
            // 
            this.duLieu.DataSetName = "DuLieu";
            this.duLieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPHOCBindingSource
            // 
            this.lOPHOCBindingSource.DataMember = "LOPHOC";
            this.lOPHOCBindingSource.DataSource = this.duLieu;
            // 
            // lOPHOCTableAdapter
            // 
            this.lOPHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAHOCTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GiangVienTableAdapter = null;
            this.tableAdapterManager.HOCVIENTableAdapter = null;
            this.tableAdapterManager.KHOAHOCTableAdapter = null;
            this.tableAdapterManager.KYTHITableAdapter = null;
            this.tableAdapterManager.LOPHOCTableAdapter = this.lOPHOCTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_HocVien.DuLieuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPHOCBindingNavigator
            // 
            this.lOPHOCBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOPHOCBindingNavigator.BindingSource = this.lOPHOCBindingSource;
            this.lOPHOCBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOPHOCBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOPHOCBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOPHOCBindingNavigatorSaveItem});
            this.lOPHOCBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lOPHOCBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOPHOCBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOPHOCBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOPHOCBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOPHOCBindingNavigator.Name = "lOPHOCBindingNavigator";
            this.lOPHOCBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOPHOCBindingNavigator.Size = new System.Drawing.Size(380, 25);
            this.lOPHOCBindingNavigator.TabIndex = 0;
            this.lOPHOCBindingNavigator.Text = "bindingNavigator1";
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
            // lOPHOCBindingNavigatorSaveItem
            // 
            this.lOPHOCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOPHOCBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOPHOCBindingNavigatorSaveItem.Image")));
            this.lOPHOCBindingNavigatorSaveItem.Name = "lOPHOCBindingNavigatorSaveItem";
            this.lOPHOCBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lOPHOCBindingNavigatorSaveItem.Text = "Save Data";
            this.lOPHOCBindingNavigatorSaveItem.Click += new System.EventHandler(this.lOPHOCBindingNavigatorSaveItem_Click);
            // 
            // lOPHOCDataGridView
            // 
            this.lOPHOCDataGridView.AllowUserToAddRows = false;
            this.lOPHOCDataGridView.AllowUserToDeleteRows = false;
            this.lOPHOCDataGridView.AutoGenerateColumns = false;
            this.lOPHOCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOPHOCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lOPHOCDataGridView.DataSource = this.lOPHOCBindingSource;
            this.lOPHOCDataGridView.Location = new System.Drawing.Point(12, 117);
            this.lOPHOCDataGridView.Name = "lOPHOCDataGridView";
            this.lOPHOCDataGridView.ReadOnly = true;
            this.lOPHOCDataGridView.Size = new System.Drawing.Size(348, 293);
            this.lOPHOCDataGridView.TabIndex = 1;
            // 
            // maLHLabel
            // 
            maLHLabel.AutoSize = true;
            maLHLabel.Location = new System.Drawing.Point(5, 31);
            maLHLabel.Name = "maLHLabel";
            maLHLabel.Size = new System.Drawing.Size(42, 13);
            maLHLabel.TabIndex = 2;
            maLHLabel.Text = "Ma LH:";
            // 
            // maLHTextBox
            // 
            this.maLHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPHOCBindingSource, "MaLH", true));
            this.maLHTextBox.Location = new System.Drawing.Point(57, 28);
            this.maLHTextBox.Name = "maLHTextBox";
            this.maLHTextBox.Size = new System.Drawing.Size(303, 20);
            this.maLHTextBox.TabIndex = 3;
            // 
            // tenLHLabel
            // 
            tenLHLabel.AutoSize = true;
            tenLHLabel.Location = new System.Drawing.Point(5, 57);
            tenLHLabel.Name = "tenLHLabel";
            tenLHLabel.Size = new System.Drawing.Size(46, 13);
            tenLHLabel.TabIndex = 4;
            tenLHLabel.Text = "Ten LH:";
            // 
            // tenLHTextBox
            // 
            this.tenLHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPHOCBindingSource, "TenLH", true));
            this.tenLHTextBox.Location = new System.Drawing.Point(57, 54);
            this.tenLHTextBox.Name = "tenLHTextBox";
            this.tenLHTextBox.Size = new System.Drawing.Size(303, 20);
            this.tenLHTextBox.TabIndex = 5;
            // 
            // siSoLabel
            // 
            siSoLabel.AutoSize = true;
            siSoLabel.Location = new System.Drawing.Point(5, 83);
            siSoLabel.Name = "siSoLabel";
            siSoLabel.Size = new System.Drawing.Size(35, 13);
            siSoLabel.TabIndex = 6;
            siSoLabel.Text = "Si So:";
            // 
            // siSoTextBox
            // 
            this.siSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPHOCBindingSource, "SiSo", true));
            this.siSoTextBox.Location = new System.Drawing.Point(57, 80);
            this.siSoTextBox.Name = "siSoTextBox";
            this.siSoTextBox.Size = new System.Drawing.Size(303, 20);
            this.siSoTextBox.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Lớp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Lớp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SiSo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sĩ Số";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 422);
            this.Controls.Add(maLHLabel);
            this.Controls.Add(this.maLHTextBox);
            this.Controls.Add(tenLHLabel);
            this.Controls.Add(this.tenLHTextBox);
            this.Controls.Add(siSoLabel);
            this.Controls.Add(this.siSoTextBox);
            this.Controls.Add(this.lOPHOCDataGridView);
            this.Controls.Add(this.lOPHOCBindingNavigator);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPHOCBindingNavigator)).EndInit();
            this.lOPHOCBindingNavigator.ResumeLayout(false);
            this.lOPHOCBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPHOCDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DuLieu duLieu;
        private System.Windows.Forms.BindingSource lOPHOCBindingSource;
        private DuLieuTableAdapters.LOPHOCTableAdapter lOPHOCTableAdapter;
        private DuLieuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOPHOCBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lOPHOCBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lOPHOCDataGridView;
        private System.Windows.Forms.TextBox maLHTextBox;
        private System.Windows.Forms.TextBox tenLHTextBox;
        private System.Windows.Forms.TextBox siSoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}