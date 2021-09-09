
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
            this.My_menu = new System.Windows.Forms.MenuStrip();
            this.product_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_product_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.change_product_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_consumer_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.change_consumer_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_deal_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.change_deal_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.cProductTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cWhosale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTradeSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageConsumers = new System.Windows.Forms.TabPage();
            this.listConsumer = new System.Windows.Forms.ListView();
            this.columnNameConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastNameConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageDeal = new System.Windows.Forms.TabPage();
            this.listViewDeal = new System.Windows.Forms.ListView();
            this.cProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCountProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cConsumer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cWhosaleD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTimeDeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.My_menu.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageConsumers.SuspendLayout();
            this.tabPageDeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // My_menu
            // 
            this.My_menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.My_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.product_MenuItem,
            this.покупателиToolStripMenuItem,
            this.сделкиToolStripMenuItem});
            this.My_menu.Location = new System.Drawing.Point(0, 0);
            this.My_menu.Name = "My_menu";
            this.My_menu.Size = new System.Drawing.Size(690, 33);
            this.My_menu.TabIndex = 0;
            this.My_menu.Text = "menuStrip1";
            // 
            // product_MenuItem
            // 
            this.product_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_product_MenuItem,
            this.change_product_MenuItem});
            this.product_MenuItem.Name = "product_MenuItem";
            this.product_MenuItem.Size = new System.Drawing.Size(89, 29);
            this.product_MenuItem.Text = "Товары";
            // 
            // add_product_MenuItem
            // 
            this.add_product_MenuItem.Name = "add_product_MenuItem";
            this.add_product_MenuItem.Size = new System.Drawing.Size(213, 30);
            this.add_product_MenuItem.Text = "Добавить";
            this.add_product_MenuItem.Click += new System.EventHandler(this.add_product_MenuItem_Click);
            // 
            // change_product_MenuItem
            // 
            this.change_product_MenuItem.Name = "change_product_MenuItem";
            this.change_product_MenuItem.Size = new System.Drawing.Size(213, 30);
            this.change_product_MenuItem.Text = "Редактировать";
            this.change_product_MenuItem.Click += new System.EventHandler(this.change_product_MenuItem_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_consumer_menuItem,
            this.change_consumer_menuItem});
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            // 
            // add_consumer_menuItem
            // 
            this.add_consumer_menuItem.Name = "add_consumer_menuItem";
            this.add_consumer_menuItem.Size = new System.Drawing.Size(213, 30);
            this.add_consumer_menuItem.Text = "Добавить";
            this.add_consumer_menuItem.Click += new System.EventHandler(this.add_consumer_menuItem_Click);
            // 
            // change_consumer_menuItem
            // 
            this.change_consumer_menuItem.Name = "change_consumer_menuItem";
            this.change_consumer_menuItem.Size = new System.Drawing.Size(213, 30);
            this.change_consumer_menuItem.Text = "Редактировать";
            this.change_consumer_menuItem.Click += new System.EventHandler(this.change_consumer_menuItem_Click);
            // 
            // сделкиToolStripMenuItem
            // 
            this.сделкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_deal_menu,
            this.change_deal_menu});
            this.сделкиToolStripMenuItem.Name = "сделкиToolStripMenuItem";
            this.сделкиToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.сделкиToolStripMenuItem.Text = "Сделки";
            // 
            // add_deal_menu
            // 
            this.add_deal_menu.Name = "add_deal_menu";
            this.add_deal_menu.Size = new System.Drawing.Size(213, 30);
            this.add_deal_menu.Text = "Добавить";
            this.add_deal_menu.Click += new System.EventHandler(this.add_deal_menu_Click);
            // 
            // change_deal_menu
            // 
            this.change_deal_menu.Name = "change_deal_menu";
            this.change_deal_menu.Size = new System.Drawing.Size(213, 30);
            this.change_deal_menu.Text = "Редактировать";
            this.change_deal_menu.Click += new System.EventHandler(this.change_deal_menu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage1);
            this.tabControl_main.Controls.Add(this.tabPageConsumers);
            this.tabControl_main.Controls.Add(this.tabPageDeal);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 33);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(690, 417);
            this.tabControl_main.TabIndex = 1;
            this.tabControl_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewDeal_Remove);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cProductTitle,
            this.cWhosale,
            this.cTradeSale,
            this.cDescription});
            this.listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(3, 3);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(676, 385);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // cProductTitle
            // 
            this.cProductTitle.Tag = "";
            this.cProductTitle.Text = "Название";
            this.cProductTitle.Width = 234;
            // 
            // cWhosale
            // 
            this.cWhosale.Text = "Оптовая цена";
            this.cWhosale.Width = 110;
            // 
            // cTradeSale
            // 
            this.cTradeSale.Text = "Рыночная цена";
            this.cTradeSale.Width = 110;
            // 
            // cDescription
            // 
            this.cDescription.Text = "Описание";
            this.cDescription.Width = 220;
            // 
            // tabPageConsumers
            // 
            this.tabPageConsumers.Controls.Add(this.listConsumer);
            this.tabPageConsumers.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsumers.Name = "tabPageConsumers";
            this.tabPageConsumers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsumers.Size = new System.Drawing.Size(682, 391);
            this.tabPageConsumers.TabIndex = 1;
            this.tabPageConsumers.Text = "Покупатели";
            this.tabPageConsumers.UseVisualStyleBackColor = true;
            // 
            // listConsumer
            // 
            this.listConsumer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameConsumer,
            this.columnLastNameConsumer,
            this.columnPhoneConsumer,
            this.Addr});
            this.listConsumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConsumer.FullRowSelect = true;
            this.listConsumer.GridLines = true;
            this.listConsumer.HideSelection = false;
            this.listConsumer.Location = new System.Drawing.Point(3, 3);
            this.listConsumer.Name = "listConsumer";
            this.listConsumer.Size = new System.Drawing.Size(676, 385);
            this.listConsumer.TabIndex = 0;
            this.listConsumer.UseCompatibleStateImageBehavior = false;
            this.listConsumer.View = System.Windows.Forms.View.Details;
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
            // Addr
            // 
            this.Addr.Text = "Адрес";
            this.Addr.Width = 100;
            // 
            // tabPageDeal
            // 
            this.tabPageDeal.Controls.Add(this.listViewDeal);
            this.tabPageDeal.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeal.Name = "tabPageDeal";
            this.tabPageDeal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeal.Size = new System.Drawing.Size(682, 391);
            this.tabPageDeal.TabIndex = 2;
            this.tabPageDeal.Text = "Сделка";
            this.tabPageDeal.UseVisualStyleBackColor = true;
            // 
            // listViewDeal
            // 
            this.listViewDeal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cProduct,
            this.cCountProduct,
            this.cConsumer,
            this.cWhosaleD,
            this.cTimeDeal});
            this.listViewDeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeal.FullRowSelect = true;
            this.listViewDeal.GridLines = true;
            this.listViewDeal.HideSelection = false;
            this.listViewDeal.Location = new System.Drawing.Point(3, 3);
            this.listViewDeal.Name = "listViewDeal";
            this.listViewDeal.Size = new System.Drawing.Size(676, 385);
            this.listViewDeal.TabIndex = 0;
            this.listViewDeal.UseCompatibleStateImageBehavior = false;
            this.listViewDeal.View = System.Windows.Forms.View.Details;
            // 
            // cProduct
            // 
            this.cProduct.Text = "Товар";
            this.cProduct.Width = 150;
            // 
            // cCountProduct
            // 
            this.cCountProduct.Text = "Количество";
            this.cCountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cCountProduct.Width = 75;
            // 
            // cConsumer
            // 
            this.cConsumer.Text = "Покупатель";
            this.cConsumer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cConsumer.Width = 90;
            // 
            // cWhosaleD
            // 
            this.cWhosaleD.Text = "Оптовая продажа";
            this.cWhosaleD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cWhosaleD.Width = 110;
            // 
            // cTimeDeal
            // 
            this.cTimeDeal.Text = "Дата сделки";
            this.cTimeDeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cTimeDeal.Width = 110;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.My_menu);
            this.MainMenuStrip = this.My_menu;
            this.Name = "FormMain";
            this.Text = "CRM фирмы";
            this.My_menu.ResumeLayout(false);
            this.My_menu.PerformLayout();
            this.tabControl_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageConsumers.ResumeLayout(false);
            this.tabPageDeal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip My_menu;
        private System.Windows.Forms.ToolStripMenuItem product_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_product_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem change_product_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_consumer_menuItem;
        private System.Windows.Forms.ToolStripMenuItem change_consumer_menuItem;
        private System.Windows.Forms.ToolStripMenuItem сделкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_deal_menu;
        private System.Windows.Forms.ToolStripMenuItem change_deal_menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader cProductTitle;
        private System.Windows.Forms.TabPage tabPageConsumers;
        private System.Windows.Forms.TabPage tabPageDeal;
        private System.Windows.Forms.ListView listConsumer;
        private System.Windows.Forms.ColumnHeader columnNameConsumer;
        private System.Windows.Forms.ColumnHeader columnLastNameConsumer;
        private System.Windows.Forms.ColumnHeader columnPhoneConsumer;
        private System.Windows.Forms.ColumnHeader Addr;
        private System.Windows.Forms.ColumnHeader cWhosale;
        private System.Windows.Forms.ColumnHeader cTradeSale;
        private System.Windows.Forms.ColumnHeader cDescription;
        private System.Windows.Forms.ListView listViewDeal;
        private System.Windows.Forms.ColumnHeader cProduct;
        private System.Windows.Forms.ColumnHeader cCountProduct;
        private System.Windows.Forms.ColumnHeader cConsumer;
        private System.Windows.Forms.ColumnHeader cWhosaleD;
        private System.Windows.Forms.ColumnHeader cTimeDeal;
    }
}

