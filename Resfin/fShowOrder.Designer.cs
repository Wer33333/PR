namespace Resfin
{
    partial class fShowOrder
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
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label ldis;
            System.Windows.Forms.Label lPrice;
            System.Windows.Forms.Label lfir;
            System.Windows.Forms.Label lNamePr;
            System.Windows.Forms.Label lCount;
            System.Windows.Forms.Label lDescrip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowOrder));
            this.lz = new System.Windows.Forms.Label();
            this.lNumZak = new System.Windows.Forms.Label();
            this.lPup = new System.Windows.Forms.Label();
            this.lpp = new System.Windows.Forms.Label();
            this.ls = new System.Windows.Forms.Label();
            this.ld = new System.Windows.Forms.Label();
            this.lCode = new System.Windows.Forms.Label();
            this.lc = new System.Windows.Forms.Label();
            this.dbBook1DataSet = new Resfin.dbBook1DataSet();
            this.productInOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInOrderTableAdapter = new Resfin.dbBook1DataSetTableAdapters.ProductInOrderTableAdapter();
            this.tableAdapterManager = new Resfin.dbBook1DataSetTableAdapters.TableAdapterManager();
            this.orderProductTableAdapter = new Resfin.dbBook1DataSetTableAdapters.OrderProductTableAdapter();
            this.productInOrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productInOrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.PPB = new System.Windows.Forms.PictureBox();
            this.lDisc = new System.Windows.Forms.Label();
            this.lSumm = new System.Windows.Forms.Label();
            this.lF = new System.Windows.Forms.Label();
            this.lNP = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lDeC = new System.Windows.Forms.Label();
            this.productInOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupOpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupOpTableAdapter = new Resfin.dbBook1DataSetTableAdapters.GroupOpTableAdapter();
            this.lSummD = new System.Windows.Forms.Label();
            this.lDiscD = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bPDF = new System.Windows.Forms.Button();
            photoLabel = new System.Windows.Forms.Label();
            ldis = new System.Windows.Forms.Label();
            lPrice = new System.Windows.Forms.Label();
            lfir = new System.Windows.Forms.Label();
            lNamePr = new System.Windows.Forms.Label();
            lCount = new System.Windows.Forms.Label();
            lDescrip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbBook1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInOrderBindingNavigator)).BeginInit();
            this.productInOrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(669, 122);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(50, 21);
            photoLabel.TabIndex = 11;
            photoLabel.Text = "Фото:";
            // 
            // ldis
            // 
            ldis.AutoSize = true;
            ldis.Location = new System.Drawing.Point(691, 322);
            ldis.Name = "ldis";
            ldis.Size = new System.Drawing.Size(65, 21);
            ldis.TabIndex = 13;
            ldis.Text = "Скидка:";
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.Location = new System.Drawing.Point(706, 408);
            lPrice.Name = "lPrice";
            lPrice.Size = new System.Drawing.Size(50, 21);
            lPrice.TabIndex = 15;
            lPrice.Text = "Цена:";
            // 
            // lfir
            // 
            lfir.AutoSize = true;
            lfir.Location = new System.Drawing.Point(663, 285);
            lfir.Name = "lfir";
            lfir.Size = new System.Drawing.Size(93, 21);
            lfir.TabIndex = 17;
            lfir.Text = "Поставщик:";
            // 
            // lNamePr
            // 
            lNamePr.AutoSize = true;
            lNamePr.Location = new System.Drawing.Point(682, 238);
            lNamePr.Name = "lNamePr";
            lNamePr.Size = new System.Drawing.Size(74, 21);
            lNamePr.TabIndex = 19;
            lNamePr.Text = "Продукт:";
            // 
            // lCount
            // 
            lCount.AutoSize = true;
            lCount.Location = new System.Drawing.Point(660, 437);
            lCount.Name = "lCount";
            lCount.Size = new System.Drawing.Size(96, 21);
            lCount.TabIndex = 21;
            lCount.Text = "Количество:";
            // 
            // lDescrip
            // 
            lDescrip.AutoSize = true;
            lDescrip.Location = new System.Drawing.Point(672, 370);
            lDescrip.Name = "lDescrip";
            lDescrip.Size = new System.Drawing.Size(84, 21);
            lDescrip.TabIndex = 23;
            lDescrip.Text = "Описание:";
            // 
            // lz
            // 
            this.lz.AutoSize = true;
            this.lz.Location = new System.Drawing.Point(13, 32);
            this.lz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lz.Name = "lz";
            this.lz.Size = new System.Drawing.Size(72, 21);
            this.lz.TabIndex = 0;
            this.lz.Text = "Заказ №";
            // 
            // lNumZak
            // 
            this.lNumZak.AutoSize = true;
            this.lNumZak.Location = new System.Drawing.Point(93, 32);
            this.lNumZak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNumZak.Name = "lNumZak";
            this.lNumZak.Size = new System.Drawing.Size(19, 21);
            this.lNumZak.TabIndex = 1;
            this.lNumZak.Text = "0";
            // 
            // lPup
            // 
            this.lPup.AutoSize = true;
            this.lPup.Location = new System.Drawing.Point(363, 32);
            this.lPup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPup.Name = "lPup";
            this.lPup.Size = new System.Drawing.Size(52, 21);
            this.lPup.TabIndex = 5;
            this.lPup.Text = "label4";
            // 
            // lpp
            // 
            this.lpp.AutoSize = true;
            this.lpp.Location = new System.Drawing.Point(240, 32);
            this.lpp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpp.Name = "lpp";
            this.lpp.Size = new System.Drawing.Size(115, 21);
            this.lpp.TabIndex = 4;
            this.lpp.Text = "Пункт Выдачи:";
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.Location = new System.Drawing.Point(13, 69);
            this.ls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(111, 21);
            this.ls.TabIndex = 3;
            this.ls.Text = "Сумма заказа:";
            // 
            // ld
            // 
            this.ld.AutoSize = true;
            this.ld.Location = new System.Drawing.Point(240, 69);
            this.ld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ld.Name = "ld";
            this.ld.Size = new System.Drawing.Size(65, 21);
            this.ld.TabIndex = 6;
            this.ld.Text = "Скидка:";
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Location = new System.Drawing.Point(605, 32);
            this.lCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(19, 21);
            this.lCode.TabIndex = 9;
            this.lCode.Text = "0";
            // 
            // lc
            // 
            this.lc.AutoSize = true;
            this.lc.Location = new System.Drawing.Point(482, 32);
            this.lc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(121, 21);
            this.lc.TabIndex = 8;
            this.lc.Text = "Код получения:";
            // 
            // dbBook1DataSet
            // 
            this.dbBook1DataSet.DataSetName = "dbBook1DataSet";
            this.dbBook1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productInOrderBindingSource
            // 
            this.productInOrderBindingSource.DataMember = "ProductInOrder";
            this.productInOrderBindingSource.DataSource = this.dbBook1DataSet;
            // 
            // productInOrderTableAdapter
            // 
            this.productInOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = this.orderProductTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickUpPointTableAdapter = null;
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
            // productInOrderBindingNavigator
            // 
            this.productInOrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productInOrderBindingNavigator.BindingSource = this.productInOrderBindingSource;
            this.productInOrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productInOrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productInOrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productInOrderBindingNavigatorSaveItem});
            this.productInOrderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productInOrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productInOrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productInOrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productInOrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productInOrderBindingNavigator.Name = "productInOrderBindingNavigator";
            this.productInOrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productInOrderBindingNavigator.Size = new System.Drawing.Size(1055, 25);
            this.productInOrderBindingNavigator.TabIndex = 10;
            this.productInOrderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productInOrderBindingNavigatorSaveItem
            // 
            this.productInOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productInOrderBindingNavigatorSaveItem.Enabled = false;
            this.productInOrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productInOrderBindingNavigatorSaveItem.Image")));
            this.productInOrderBindingNavigatorSaveItem.Name = "productInOrderBindingNavigatorSaveItem";
            this.productInOrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productInOrderBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // PPB
            // 
            this.PPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PPB.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productInOrderBindingSource, "Photo", true));
            this.PPB.Location = new System.Drawing.Point(729, 122);
            this.PPB.Name = "PPB";
            this.PPB.Size = new System.Drawing.Size(120, 100);
            this.PPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PPB.TabIndex = 12;
            this.PPB.TabStop = false;
            // 
            // lDisc
            // 
            this.lDisc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInOrderBindingSource, "Discount", true));
            this.lDisc.Location = new System.Drawing.Point(762, 322);
            this.lDisc.Name = "lDisc";
            this.lDisc.Size = new System.Drawing.Size(266, 23);
            this.lDisc.TabIndex = 14;
            this.lDisc.Text = "label1";
            // 
            // lSumm
            // 
            this.lSumm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInOrderBindingSource, "Price", true));
            this.lSumm.Location = new System.Drawing.Point(762, 408);
            this.lSumm.Name = "lSumm";
            this.lSumm.Size = new System.Drawing.Size(100, 23);
            this.lSumm.TabIndex = 16;
            this.lSumm.Text = "label1";
            // 
            // lF
            // 
            this.lF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInOrderBindingSource, "Firma", true));
            this.lF.Location = new System.Drawing.Point(762, 285);
            this.lF.Name = "lF";
            this.lF.Size = new System.Drawing.Size(266, 23);
            this.lF.TabIndex = 18;
            this.lF.Text = "label1";
            // 
            // lNP
            // 
            this.lNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInOrderBindingSource, "NameProduct", true));
            this.lNP.Location = new System.Drawing.Point(762, 238);
            this.lNP.Name = "lNP";
            this.lNP.Size = new System.Drawing.Size(266, 23);
            this.lNP.TabIndex = 20;
            this.lNP.Text = "label1";
            // 
            // tbCount
            // 
            this.tbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInOrderBindingSource, "Count", true));
            this.tbCount.Location = new System.Drawing.Point(766, 434);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 29);
            this.tbCount.TabIndex = 22;
            // 
            // lDeC
            // 
            this.lDeC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInOrderBindingSource, "Description", true));
            this.lDeC.Location = new System.Drawing.Point(762, 368);
            this.lDeC.Name = "lDeC";
            this.lDeC.Size = new System.Drawing.Size(266, 23);
            this.lDeC.TabIndex = 24;
            this.lDeC.Text = "label1";
            // 
            // productInOrderDataGridView
            // 
            this.productInOrderDataGridView.AllowUserToAddRows = false;
            this.productInOrderDataGridView.AllowUserToDeleteRows = false;
            this.productInOrderDataGridView.AutoGenerateColumns = false;
            this.productInOrderDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productInOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productInOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.productInOrderDataGridView.DataSource = this.productInOrderBindingSource;
            this.productInOrderDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productInOrderDataGridView.Location = new System.Drawing.Point(17, 122);
            this.productInOrderDataGridView.Name = "productInOrderDataGridView";
            this.productInOrderDataGridView.ReadOnly = true;
            this.productInOrderDataGridView.RowHeadersVisible = false;
            this.productInOrderDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.productInOrderDataGridView.Size = new System.Drawing.Size(640, 341);
            this.productInOrderDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Firma";
            this.dataGridViewTextBoxColumn1.HeaderText = "Firma";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDOrderProduct";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDOrderProduct";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDOrder";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDOrder";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDProduct";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDProduct";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn5.HeaderText = "Count";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NameProduct";
            this.dataGridViewTextBoxColumn6.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDManufacturer";
            this.dataGridViewTextBoxColumn8.HeaderText = "IDManufacturer";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn10.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // orderProductBindingSource
            // 
            this.orderProductBindingSource.DataMember = "OrderProduct";
            this.orderProductBindingSource.DataSource = this.dbBook1DataSet;
            // 
            // groupOpBindingSource
            // 
            this.groupOpBindingSource.DataMember = "GroupOp";
            this.groupOpBindingSource.DataSource = this.dbBook1DataSet;
            // 
            // groupOpTableAdapter
            // 
            this.groupOpTableAdapter.ClearBeforeFill = true;
            // 
            // lSummD
            // 
            this.lSummD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupOpBindingSource, "Summa", true));
            this.lSummD.Location = new System.Drawing.Point(131, 69);
            this.lSummD.Name = "lSummD";
            this.lSummD.Size = new System.Drawing.Size(100, 23);
            this.lSummD.TabIndex = 26;
            this.lSummD.Text = "label1";
            // 
            // lDiscD
            // 
            this.lDiscD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupOpBindingSource, "Discount", true));
            this.lDiscD.Location = new System.Drawing.Point(312, 69);
            this.lDiscD.Name = "lDiscD";
            this.lDiscD.Size = new System.Drawing.Size(100, 23);
            this.lDiscD.TabIndex = 27;
            this.lDiscD.Text = "label1";
            // 
            // bOK
            // 
            this.bOK.AutoSize = true;
            this.bOK.Location = new System.Drawing.Point(885, 434);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 31);
            this.bOK.TabIndex = 28;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bDel
            // 
            this.bDel.AutoSize = true;
            this.bDel.Location = new System.Drawing.Point(680, 502);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(78, 31);
            this.bDel.TabIndex = 29;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bPDF
            // 
            this.bPDF.AutoSize = true;
            this.bPDF.Location = new System.Drawing.Point(805, 502);
            this.bPDF.Name = "bPDF";
            this.bPDF.Size = new System.Drawing.Size(75, 31);
            this.bPDF.TabIndex = 30;
            this.bPDF.Text = "PDF";
            this.bPDF.UseVisualStyleBackColor = true;
            this.bPDF.Click += new System.EventHandler(this.bPDF_Click);
            // 
            // fShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 555);
            this.Controls.Add(this.bPDF);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lDiscD);
            this.Controls.Add(this.lSummD);
            this.Controls.Add(this.productInOrderDataGridView);
            this.Controls.Add(lDescrip);
            this.Controls.Add(this.lDeC);
            this.Controls.Add(lCount);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(lNamePr);
            this.Controls.Add(this.lNP);
            this.Controls.Add(lfir);
            this.Controls.Add(this.lF);
            this.Controls.Add(lPrice);
            this.Controls.Add(this.lSumm);
            this.Controls.Add(ldis);
            this.Controls.Add(this.lDisc);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.PPB);
            this.Controls.Add(this.productInOrderBindingNavigator);
            this.Controls.Add(this.lCode);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.ld);
            this.Controls.Add(this.lPup);
            this.Controls.Add(this.lpp);
            this.Controls.Add(this.ls);
            this.Controls.Add(this.lNumZak);
            this.Controls.Add(this.lz);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fShowOrder";
            this.Text = "fShowOrder";
            this.Load += new System.EventHandler(this.fShowOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBook1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInOrderBindingNavigator)).EndInit();
            this.productInOrderBindingNavigator.ResumeLayout(false);
            this.productInOrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lz;
        public System.Windows.Forms.Label lNumZak;
        public System.Windows.Forms.Label lPup;
        public System.Windows.Forms.Label lpp;
        public System.Windows.Forms.Label ls;
        public System.Windows.Forms.Label ld;
        public System.Windows.Forms.Label lCode;
        public System.Windows.Forms.Label lc;
        private dbBook1DataSet dbBook1DataSet;
        private System.Windows.Forms.BindingSource productInOrderBindingSource;
        private dbBook1DataSetTableAdapters.ProductInOrderTableAdapter productInOrderTableAdapter;
        private dbBook1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productInOrderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productInOrderBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox PPB;
        private System.Windows.Forms.Label lDisc;
        private System.Windows.Forms.Label lSumm;
        private System.Windows.Forms.Label lF;
        private System.Windows.Forms.Label lNP;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label lDeC;
        private System.Windows.Forms.DataGridView productInOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private dbBook1DataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private System.Windows.Forms.BindingSource orderProductBindingSource;
        private System.Windows.Forms.BindingSource groupOpBindingSource;
        private dbBook1DataSetTableAdapters.GroupOpTableAdapter groupOpTableAdapter;
        private System.Windows.Forms.Label lSummD;
        private System.Windows.Forms.Label lDiscD;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bPDF;
    }
}