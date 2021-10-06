﻿
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuStripMy.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageConsumers.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMy
            // 
            this.MenuStripMy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStripMy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripMy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItemProduct,
            this.toolStripMenuItemConsumer,
            this.toolStripMenuItemDeal});
            this.MenuStripMy.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMy.Name = "MenuStripMy";
            this.MenuStripMy.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStripMy.Size = new System.Drawing.Size(690, 33);
            this.MenuStripMy.TabIndex = 0;
            this.MenuStripMy.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlToolStripMenuItem,
            this.jsonToolStripMenuItem,
            this.binToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.importToolStripMenuItem.Text = "Импорт";
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xmlToolStripMenuItem.Text = "XML";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jsonToolStripMenuItem.Text = "JSON";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binToolStripMenuItem.Text = "BIN";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlExportToolStripMenuItem,
            this.jsonExportToolStripMenuItem,
            this.binExportToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.exportToolStripMenuItem.Text = "Экспорт";
            // 
            // xmlExportToolStripMenuItem
            // 
            this.xmlExportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlExportToolStripMenuItem.Name = "xmlExportToolStripMenuItem";
            this.xmlExportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xmlExportToolStripMenuItem.Text = "XML";
            this.xmlExportToolStripMenuItem.Click += new System.EventHandler(this.xmlExportToolStripMenuItem_Click);
            // 
            // jsonExportToolStripMenuItem
            // 
            this.jsonExportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jsonExportToolStripMenuItem.Name = "jsonExportToolStripMenuItem";
            this.jsonExportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jsonExportToolStripMenuItem.Text = "JSON";
            this.jsonExportToolStripMenuItem.Click += new System.EventHandler(this.jsonExportToolStripMenuItem_Click);
            // 
            // binExportToolStripMenuItem
            // 
            this.binExportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binExportToolStripMenuItem.Name = "binExportToolStripMenuItem";
            this.binExportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binExportToolStripMenuItem.Text = "BIN";
            this.binExportToolStripMenuItem.Click += new System.EventHandler(this.binExportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.exitToolStripMenuItem.Text = "Закрыть";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemProduct
            // 
            this.toolStripMenuItemProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddProduct,
            this.toolStripMenuItemChangeProduct});
            this.toolStripMenuItemProduct.Name = "toolStripMenuItemProduct";
            this.toolStripMenuItemProduct.Size = new System.Drawing.Size(89, 29);
            this.toolStripMenuItemProduct.Text = "Товары";
            // 
            // toolStripMenuItemAddProduct
            // 
            this.toolStripMenuItemAddProduct.Name = "toolStripMenuItemAddProduct";
            this.toolStripMenuItemAddProduct.Size = new System.Drawing.Size(213, 30);
            this.toolStripMenuItemAddProduct.Text = "Добавить";
            this.toolStripMenuItemAddProduct.Click += new System.EventHandler(this.Add_product_MenuItem_Click);
            // 
            // toolStripMenuItemChangeProduct
            // 
            this.toolStripMenuItemChangeProduct.Name = "toolStripMenuItemChangeProduct";
            this.toolStripMenuItemChangeProduct.Size = new System.Drawing.Size(213, 30);
            this.toolStripMenuItemChangeProduct.Text = "Редактировать";
            this.toolStripMenuItemChangeProduct.Click += new System.EventHandler(this.Change_product_MenuItem_Click);
            // 
            // toolStripMenuItemConsumer
            // 
            this.toolStripMenuItemConsumer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddConsumer,
            this.toolStripMenuItemChangeConsumer});
            this.toolStripMenuItemConsumer.Name = "toolStripMenuItemConsumer";
            this.toolStripMenuItemConsumer.Size = new System.Drawing.Size(127, 29);
            this.toolStripMenuItemConsumer.Text = "Покупатели";
            // 
            // toolStripMenuItemAddConsumer
            // 
            this.toolStripMenuItemAddConsumer.Name = "toolStripMenuItemAddConsumer";
            this.toolStripMenuItemAddConsumer.Size = new System.Drawing.Size(213, 30);
            this.toolStripMenuItemAddConsumer.Text = "Добавить";
            this.toolStripMenuItemAddConsumer.Click += new System.EventHandler(this.Add_consumer_menuItem_Click);
            // 
            // toolStripMenuItemChangeConsumer
            // 
            this.toolStripMenuItemChangeConsumer.Name = "toolStripMenuItemChangeConsumer";
            this.toolStripMenuItemChangeConsumer.Size = new System.Drawing.Size(213, 30);
            this.toolStripMenuItemChangeConsumer.Text = "Редактировать";
            this.toolStripMenuItemChangeConsumer.Click += new System.EventHandler(this.Change_consumer_menuItem_Click);
            // 
            // toolStripMenuItemDeal
            // 
            this.toolStripMenuItemDeal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddDealMenu,
            this.toolStripMenuItemChangeDealMenu});
            this.toolStripMenuItemDeal.Name = "toolStripMenuItemDeal";
            this.toolStripMenuItemDeal.Size = new System.Drawing.Size(86, 29);
            this.toolStripMenuItemDeal.Text = "Сделки";
            // 
            // ToolStripMenuItemAddDealMenu
            // 
            this.ToolStripMenuItemAddDealMenu.Name = "ToolStripMenuItemAddDealMenu";
            this.ToolStripMenuItemAddDealMenu.Size = new System.Drawing.Size(213, 30);
            this.ToolStripMenuItemAddDealMenu.Text = "Добавить";
            this.ToolStripMenuItemAddDealMenu.Click += new System.EventHandler(this.Add_deal_menu_Click);
            // 
            // toolStripMenuItemChangeDealMenu
            // 
            this.toolStripMenuItemChangeDealMenu.Name = "toolStripMenuItemChangeDealMenu";
            this.toolStripMenuItemChangeDealMenu.Size = new System.Drawing.Size(213, 30);
            this.toolStripMenuItemChangeDealMenu.Text = "Редактировать";
            this.toolStripMenuItemChangeDealMenu.Click += new System.EventHandler(this.Change_deal_menu_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPageConsumers);
            this.tabControlMain.Controls.Add(this.tabPageDeal);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 33);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(690, 417);
            this.tabControlMain.TabIndex = 1;
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
            this.columnHeaderProductTitle,
            this.columnHeaderWhosale,
            this.columnHeaderTradeSale,
            this.columnHeaderDescription});
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
            this.tabPageConsumers.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsumers.Name = "tabPageConsumers";
            this.tabPageConsumers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsumers.Size = new System.Drawing.Size(682, 391);
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
            this.listViewConsumer.Location = new System.Drawing.Point(3, 3);
            this.listViewConsumer.Name = "listViewConsumer";
            this.listViewConsumer.Size = new System.Drawing.Size(676, 385);
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
            this.tabPageDeal.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeal.Name = "tabPageDeal";
            this.tabPageDeal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeal.Size = new System.Drawing.Size(682, 391);
            this.tabPageDeal.TabIndex = 2;
            this.tabPageDeal.Text = "Сделка";
            this.tabPageDeal.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.MenuStripMy);
            this.MainMenuStrip = this.MenuStripMy;
            this.Name = "FormMain";
            this.Text = "CRM фирмы";
            this.MenuStripMy.ResumeLayout(false);
            this.MenuStripMy.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageConsumers.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
