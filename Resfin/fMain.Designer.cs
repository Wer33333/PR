namespace Resfin
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pL = new System.Windows.Forms.Panel();
            this.llogo = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.Label();
            this.lpv = new System.Windows.Forms.Label();
            this.dbBook1DataSet = new Resfin.dbBook1DataSet();
            this.CbPUP = new System.Windows.Forms.ComboBox();
            this.pickUpPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pickUpPointTableAdapter = new Resfin.dbBook1DataSetTableAdapters.PickUpPointTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Resfin.dbBook1DataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new Resfin.dbBook1DataSetTableAdapters.TableAdapterManager();
            this.orderProductTableAdapter = new Resfin.dbBook1DataSetTableAdapters.OrderProductTableAdapter();
            this.productAllDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productAllDataTableAdapter = new Resfin.dbBook1DataSetTableAdapters.ProductAllDataTableAdapter();
            this.productAllDataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pT = new System.Windows.Forms.Panel();
            this.bShowT = new System.Windows.Forms.Button();
            this.lDiscZ = new System.Windows.Forms.Label();
            this.lSumZ = new System.Windows.Forms.Label();
            this.lDz = new System.Windows.Forms.Label();
            this.lSz = new System.Windows.Forms.Label();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMAddT = new System.Windows.Forms.ToolStripMenuItem();
            this.pL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBook1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickUpPointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAllDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAllDataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).BeginInit();
            this.pT.SuspendLayout();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pL
            // 
            this.pL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pL.Controls.Add(this.llogo);
            this.pL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pL.Location = new System.Drawing.Point(0, 0);
            this.pL.Name = "pL";
            this.pL.Size = new System.Drawing.Size(978, 100);
            this.pL.TabIndex = 0;
            // 
            // llogo
            // 
            this.llogo.AutoSize = true;
            this.llogo.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llogo.Location = new System.Drawing.Point(162, 19);
            this.llogo.Name = "llogo";
            this.llogo.Size = new System.Drawing.Size(393, 45);
            this.llogo.TabIndex = 1;
            this.llogo.Text = "\"ООО Книжный магазин\"";
            // 
            // lst
            // 
            this.lst.AutoSize = true;
            this.lst.Location = new System.Drawing.Point(12, 188);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(127, 21);
            this.lst.TabIndex = 1;
            this.lst.Text = "Список товаров:";
            // 
            // lpv
            // 
            this.lpv.AutoSize = true;
            this.lpv.Location = new System.Drawing.Point(617, 183);
            this.lpv.Name = "lpv";
            this.lpv.Size = new System.Drawing.Size(114, 21);
            this.lpv.TabIndex = 2;
            this.lpv.Text = "Пункт выдачи:";
            // 
            // dbBook1DataSet
            // 
            this.dbBook1DataSet.DataSetName = "dbBook1DataSet";
            this.dbBook1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbPUP
            // 
            this.CbPUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CbPUP.DataSource = this.pickUpPointBindingSource;
            this.CbPUP.DisplayMember = "NamePickUpPoint";
            this.CbPUP.FormattingEnabled = true;
            this.CbPUP.Location = new System.Drawing.Point(737, 180);
            this.CbPUP.Name = "CbPUP";
            this.CbPUP.Size = new System.Drawing.Size(230, 29);
            this.CbPUP.TabIndex = 5;
            // 
            // pickUpPointBindingSource
            // 
            this.pickUpPointBindingSource.DataMember = "PickUpPoint";
            this.pickUpPointBindingSource.DataSource = this.dbBook1DataSet;
            // 
            // pickUpPointTableAdapter
            // 
            this.pickUpPointTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.dbBook1DataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = this.orderProductTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.PickUpPointTableAdapter = this.pickUpPointTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Resfin.dbBook1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // orderProductTableAdapter
            // 
            this.orderProductTableAdapter.ClearBeforeFill = true;
            // 
            // productAllDataBindingSource
            // 
            this.productAllDataBindingSource.DataMember = "ProductAllData";
            this.productAllDataBindingSource.DataSource = this.dbBook1DataSet;
            // 
            // productAllDataTableAdapter
            // 
            this.productAllDataTableAdapter.ClearBeforeFill = true;
            // 
            // productAllDataDataGridView
            // 
            this.productAllDataDataGridView.AllowUserToAddRows = false;
            this.productAllDataDataGridView.AllowUserToDeleteRows = false;
            this.productAllDataDataGridView.AutoGenerateColumns = false;
            this.productAllDataDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productAllDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productAllDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.productAllDataDataGridView.ContextMenuStrip = this.CMS;
            this.productAllDataDataGridView.DataSource = this.productAllDataBindingSource;
            this.productAllDataDataGridView.Location = new System.Drawing.Point(16, 233);
            this.productAllDataDataGridView.MultiSelect = false;
            this.productAllDataDataGridView.Name = "productAllDataDataGridView";
            this.productAllDataDataGridView.ReadOnly = true;
            this.productAllDataDataGridView.RowHeadersVisible = false;
            this.productAllDataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productAllDataDataGridView.Size = new System.Drawing.Size(951, 220);
            this.productAllDataDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Firma";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фирма";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDProduct";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDProduct";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Фото";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameProduct";
            this.dataGridViewTextBoxColumn3.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDManufacturer";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDManufacturer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Скидка";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn8.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // orderProductBindingSource
            // 
            this.orderProductBindingSource.DataMember = "OrderProduct";
            this.orderProductBindingSource.DataSource = this.dbBook1DataSet;
            // 
            // pT
            // 
            this.pT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pT.Controls.Add(this.bShowT);
            this.pT.Controls.Add(this.lDiscZ);
            this.pT.Controls.Add(this.lSumZ);
            this.pT.Controls.Add(this.lDz);
            this.pT.Controls.Add(this.lSz);
            this.pT.Location = new System.Drawing.Point(27, 459);
            this.pT.Name = "pT";
            this.pT.Size = new System.Drawing.Size(501, 64);
            this.pT.TabIndex = 6;
            // 
            // bShowT
            // 
            this.bShowT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bShowT.Dock = System.Windows.Forms.DockStyle.Right;
            this.bShowT.Location = new System.Drawing.Point(301, 0);
            this.bShowT.Name = "bShowT";
            this.bShowT.Size = new System.Drawing.Size(198, 62);
            this.bShowT.TabIndex = 4;
            this.bShowT.Text = "Показать товар";
            this.bShowT.UseVisualStyleBackColor = false;
            this.bShowT.Click += new System.EventHandler(this.bShowT_Click);
            // 
            // lDiscZ
            // 
            this.lDiscZ.AutoSize = true;
            this.lDiscZ.Location = new System.Drawing.Point(120, 39);
            this.lDiscZ.Name = "lDiscZ";
            this.lDiscZ.Size = new System.Drawing.Size(19, 21);
            this.lDiscZ.TabIndex = 3;
            this.lDiscZ.Text = "0";
            // 
            // lSumZ
            // 
            this.lSumZ.AutoSize = true;
            this.lSumZ.Location = new System.Drawing.Point(120, 9);
            this.lSumZ.Name = "lSumZ";
            this.lSumZ.Size = new System.Drawing.Size(19, 21);
            this.lSumZ.TabIndex = 2;
            this.lSumZ.Text = "0";
            // 
            // lDz
            // 
            this.lDz.AutoSize = true;
            this.lDz.Location = new System.Drawing.Point(3, 39);
            this.lDz.Name = "lDz";
            this.lDz.Size = new System.Drawing.Size(115, 21);
            this.lDz.TabIndex = 1;
            this.lDz.Text = "Скидка заказа:";
            // 
            // lSz
            // 
            this.lSz.AutoSize = true;
            this.lSz.Location = new System.Drawing.Point(3, 9);
            this.lSz.Name = "lSz";
            this.lSz.Size = new System.Drawing.Size(111, 21);
            this.lSz.TabIndex = 0;
            this.lSz.Text = "Сумма заказа:";
            // 
            // CMS
            // 
            this.CMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAddT});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(161, 26);
            // 
            // TSMAddT
            // 
            this.TSMAddT.Name = "TSMAddT";
            this.TSMAddT.Size = new System.Drawing.Size(160, 22);
            this.TSMAddT.Text = "Добавить товар";
            this.TSMAddT.Click += new System.EventHandler(this.TSMAddT_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 535);
            this.Controls.Add(this.pT);
            this.Controls.Add(this.productAllDataDataGridView);
            this.Controls.Add(this.CbPUP);
            this.Controls.Add(this.lpv);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.pL);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pL.ResumeLayout(false);
            this.pL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBook1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickUpPointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAllDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAllDataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).EndInit();
            this.pT.ResumeLayout(false);
            this.pT.PerformLayout();
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pL;
        private System.Windows.Forms.Label llogo;
        private System.Windows.Forms.Label lst;
        private System.Windows.Forms.Label lpv;
        private dbBook1DataSet dbBook1DataSet;
        private System.Windows.Forms.ComboBox CbPUP;
        private System.Windows.Forms.BindingSource pickUpPointBindingSource;
        private dbBook1DataSetTableAdapters.PickUpPointTableAdapter pickUpPointTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private dbBook1DataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private dbBook1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource productAllDataBindingSource;
        private dbBook1DataSetTableAdapters.ProductAllDataTableAdapter productAllDataTableAdapter;
        private System.Windows.Forms.DataGridView productAllDataDataGridView;
        private dbBook1DataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private System.Windows.Forms.BindingSource orderProductBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel pT;
        private System.Windows.Forms.Button bShowT;
        private System.Windows.Forms.Label lDiscZ;
        private System.Windows.Forms.Label lSumZ;
        private System.Windows.Forms.Label lDz;
        private System.Windows.Forms.Label lSz;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem TSMAddT;
    }
}

