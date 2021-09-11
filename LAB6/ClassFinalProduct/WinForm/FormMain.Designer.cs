
namespace WinForm
{
    partial class FormMain
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
            this.MenuStripMy = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddDealMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeDealMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.columnHeaderProductTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWhosale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTradeSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageConsumers = new System.Windows.Forms.TabPage();
            this.listViewConsumer = new System.Windows.Forms.ListView();
            this.columnNameConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastNameConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageDeal = new System.Windows.Forms.TabPage();
            this.listViewDeal = new System.Windows.Forms.ListView();
            this.columnHeaderProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWhosaleD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTimeDeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStripMy.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageConsumers.SuspendLayout();
            this.tabPageDeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMy
            // 
            this.MenuStripMy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStripMy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripMy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProduct,
            this.toolStripMenuItemConsumer,
            this.toolStripMenuItemDeal});
            this.MenuStripMy.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMy.Name = "MenuStripMy";
            this.MenuStripMy.Size = new System.Drawing.Size(920, 40);
            this.MenuStripMy.TabIndex = 0;
            this.MenuStripMy.Text = "menuStrip1";
            // 
            // toolStripMenuItemProduct
            // 
            this.toolStripMenuItemProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddProduct,
            this.toolStripMenuItemChangeProduct});
            this.toolStripMenuItemProduct.Name = "toolStripMenuItemProduct";
            this.toolStripMenuItemProduct.Size = new System.Drawing.Size(112, 36);
            this.toolStripMenuItemProduct.Text = "Товары";
            // 
            // toolStripMenuItemAddProduct
            // 
            this.toolStripMenuItemAddProduct.Name = "toolStripMenuItemAddProduct";
            this.toolStripMenuItemAddProduct.Size = new System.Drawing.Size(266, 36);
            this.toolStripMenuItemAddProduct.Text = "Добавить";
            this.toolStripMenuItemAddProduct.Click += new System.EventHandler(this.Add_product_MenuItem_Click);
            // 
            // toolStripMenuItemChangeProduct
            // 
            this.toolStripMenuItemChangeProduct.Name = "toolStripMenuItemChangeProduct";
            this.toolStripMenuItemChangeProduct.Size = new System.Drawing.Size(266, 36);
            this.toolStripMenuItemChangeProduct.Text = "Редактировать";
            this.toolStripMenuItemChangeProduct.Click += new System.EventHandler(this.Change_product_MenuItem_Click);
            // 
            // toolStripMenuItemConsumer
            // 
            this.toolStripMenuItemConsumer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddConsumer,
            this.toolStripMenuItemChangeConsumer});
            this.toolStripMenuItemConsumer.Name = "toolStripMenuItemConsumer";
            this.toolStripMenuItemConsumer.Size = new System.Drawing.Size(160, 36);
            this.toolStripMenuItemConsumer.Text = "Покупатели";
            // 
            // toolStripMenuItemAddConsumer
            // 
            this.toolStripMenuItemAddConsumer.Name = "toolStripMenuItemAddConsumer";
            this.toolStripMenuItemAddConsumer.Size = new System.Drawing.Size(266, 36);
            this.toolStripMenuItemAddConsumer.Text = "Добавить";
            this.toolStripMenuItemAddConsumer.Click += new System.EventHandler(this.Add_consumer_menuItem_Click);
            // 
            // toolStripMenuItemChangeConsumer
            // 
            this.toolStripMenuItemChangeConsumer.Name = "toolStripMenuItemChangeConsumer";
            this.toolStripMenuItemChangeConsumer.Size = new System.Drawing.Size(266, 36);
            this.toolStripMenuItemChangeConsumer.Text = "Редактировать";
            this.toolStripMenuItemChangeConsumer.Click += new System.EventHandler(this.Change_consumer_menuItem_Click);
            // 
            // toolStripMenuItemDeal
            // 
            this.toolStripMenuItemDeal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddDealMenu,
            this.toolStripMenuItemChangeDealMenu});
            this.toolStripMenuItemDeal.Name = "toolStripMenuItemDeal";
            this.toolStripMenuItemDeal.Size = new System.Drawing.Size(109, 36);
            this.toolStripMenuItemDeal.Text = "Сделки";
            // 
            // ToolStripMenuItemAddDealMenu
            // 
            this.ToolStripMenuItemAddDealMenu.Name = "ToolStripMenuItemAddDealMenu";
            this.ToolStripMenuItemAddDealMenu.Size = new System.Drawing.Size(266, 36);
            this.ToolStripMenuItemAddDealMenu.Text = "Добавить";
            this.ToolStripMenuItemAddDealMenu.Click += new System.EventHandler(this.Add_deal_menu_Click);
            // 
            // toolStripMenuItemChangeDealMenu
            // 
            this.toolStripMenuItemChangeDealMenu.Name = "toolStripMenuItemChangeDealMenu";
            this.toolStripMenuItemChangeDealMenu.Size = new System.Drawing.Size(266, 36);
            this.toolStripMenuItemChangeDealMenu.Text = "Редактировать";
            this.toolStripMenuItemChangeDealMenu.Click += new System.EventHandler(this.Change_deal_menu_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 32);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPageConsumers);
            this.tabControlMain.Controls.Add(this.tabPageDeal);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 40);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(920, 514);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(912, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProductTitle,
            this.columnHeaderWhosale,
            this.columnHeaderTradeSale,
            this.columnHeaderDescription});
            this.listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(4, 4);
            this.listViewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(904, 477);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            this.listViewProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListViewProduct_Remove);
            // 
            // columnHeaderProductTitle
            // 
            this.columnHeaderProductTitle.Tag = "";
            this.columnHeaderProductTitle.Text = "Название";
            this.columnHeaderProductTitle.Width = 234;
            // 
            // columnHeaderWhosale
            // 
            this.columnHeaderWhosale.Text = "Оптовая цена";
            this.columnHeaderWhosale.Width = 110;
            // 
            // columnHeaderTradeSale
            // 
            this.columnHeaderTradeSale.Text = "Рыночная цена";
            this.columnHeaderTradeSale.Width = 110;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Описание";
            this.columnHeaderDescription.Width = 220;
            // 
            // tabPageConsumers
            // 
            this.tabPageConsumers.Controls.Add(this.listViewConsumer);
            this.tabPageConsumers.Location = new System.Drawing.Point(4, 25);
            this.tabPageConsumers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageConsumers.Name = "tabPageConsumers";
            this.tabPageConsumers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageConsumers.Size = new System.Drawing.Size(912, 485);
            this.tabPageConsumers.TabIndex = 1;
            this.tabPageConsumers.Text = "Покупатели";
            this.tabPageConsumers.UseVisualStyleBackColor = true;
            // 
            // listViewConsumer
            // 
            this.listViewConsumer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameConsumer,
            this.columnLastNameConsumer,
            this.columnPhoneConsumer,
            this.columnHeaderAddr});
            this.listViewConsumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewConsumer.FullRowSelect = true;
            this.listViewConsumer.GridLines = true;
            this.listViewConsumer.HideSelection = false;
            this.listViewConsumer.Location = new System.Drawing.Point(4, 4);
            this.listViewConsumer.Margin = new System.Windows.Forms.Padding(4);
            this.listViewConsumer.Name = "listViewConsumer";
            this.listViewConsumer.Size = new System.Drawing.Size(904, 477);
            this.listViewConsumer.TabIndex = 0;
            this.listViewConsumer.UseCompatibleStateImageBehavior = false;
            this.listViewConsumer.View = System.Windows.Forms.View.Details;
            this.listViewConsumer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListViewConsumer_Remove);
            // 
            // columnNameConsumer
            // 
            this.columnNameConsumer.Text = "Имя";
            this.columnNameConsumer.Width = 100;
            // 
            // columnLastNameConsumer
            // 
            this.columnLastNameConsumer.Text = "Фамилия";
            this.columnLastNameConsumer.Width = 100;
            // 
            // columnPhoneConsumer
            // 
            this.columnPhoneConsumer.Text = "Телефон";
            this.columnPhoneConsumer.Width = 110;
            // 
            // columnHeaderAddr
            // 
            this.columnHeaderAddr.Text = "Адрес";
            this.columnHeaderAddr.Width = 100;
            // 
            // tabPageDeal
            // 
            this.tabPageDeal.Controls.Add(this.listViewDeal);
            this.tabPageDeal.Location = new System.Drawing.Point(4, 25);
            this.tabPageDeal.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDeal.Name = "tabPageDeal";
            this.tabPageDeal.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDeal.Size = new System.Drawing.Size(912, 485);
            this.tabPageDeal.TabIndex = 2;
            this.tabPageDeal.Text = "Сделка";
            this.tabPageDeal.UseVisualStyleBackColor = true;
            // 
            // listViewDeal
            // 
            this.listViewDeal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProduct,
            this.columnHeaderCountProduct,
            this.columnHeaderConsumer,
            this.columnHeaderWhosaleD,
            this.columnHeaderTimeDeal});
            this.listViewDeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeal.FullRowSelect = true;
            this.listViewDeal.GridLines = true;
            this.listViewDeal.HideSelection = false;
            this.listViewDeal.Location = new System.Drawing.Point(4, 4);
            this.listViewDeal.Margin = new System.Windows.Forms.Padding(4);
            this.listViewDeal.Name = "listViewDeal";
            this.listViewDeal.Size = new System.Drawing.Size(904, 477);
            this.listViewDeal.TabIndex = 0;
            this.listViewDeal.UseCompatibleStateImageBehavior = false;
            this.listViewDeal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProduct
            // 
            this.columnHeaderProduct.Text = "Товар";
            this.columnHeaderProduct.Width = 150;
            // 
            // columnHeaderCountProduct
            // 
            this.columnHeaderCountProduct.Text = "Количество";
            this.columnHeaderCountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCountProduct.Width = 75;
            // 
            // columnHeaderConsumer
            // 
            this.columnHeaderConsumer.Text = "Покупатель";
            this.columnHeaderConsumer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderConsumer.Width = 90;
            // 
            // columnHeaderWhosaleD
            // 
            this.columnHeaderWhosaleD.Text = "Оптовая продажа";
            this.columnHeaderWhosaleD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderWhosaleD.Width = 110;
            // 
            // columnHeaderTimeDeal
            // 
            this.columnHeaderTimeDeal.Text = "Дата сделки";
            this.columnHeaderTimeDeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTimeDeal.Width = 110;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 554);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.MenuStripMy);
            this.MainMenuStrip = this.MenuStripMy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "CRM фирмы";
            this.MenuStripMy.ResumeLayout(false);
            this.MenuStripMy.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageConsumers.ResumeLayout(false);
            this.tabPageDeal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangeProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConsumer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddConsumer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangeConsumer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeal;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddDealMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangeDealMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnHeaderProductTitle;
        private System.Windows.Forms.TabPage tabPageConsumers;
        private System.Windows.Forms.TabPage tabPageDeal;
        private System.Windows.Forms.ListView listViewConsumer;
        private System.Windows.Forms.ColumnHeader columnNameConsumer;
        private System.Windows.Forms.ColumnHeader columnLastNameConsumer;
        private System.Windows.Forms.ColumnHeader columnPhoneConsumer;
        private System.Windows.Forms.ColumnHeader columnHeaderAddr;
        private System.Windows.Forms.ColumnHeader columnHeaderWhosale;
        private System.Windows.Forms.ColumnHeader columnHeaderTradeSale;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ListView listViewDeal;
        private System.Windows.Forms.ColumnHeader columnHeaderProduct;
        private System.Windows.Forms.ColumnHeader columnHeaderCountProduct;
        private System.Windows.Forms.ColumnHeader columnHeaderConsumer;
        private System.Windows.Forms.ColumnHeader columnHeaderWhosaleD;
        private System.Windows.Forms.ColumnHeader columnHeaderTimeDeal;
    }
}

