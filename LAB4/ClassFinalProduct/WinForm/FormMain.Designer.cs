
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.My_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // My_menu
            // 
            this.My_menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.My_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.product_MenuItem,
            this.покупателиToolStripMenuItem});
            this.My_menu.Location = new System.Drawing.Point(0, 0);
            this.My_menu.Name = "My_menu";
            this.My_menu.Size = new System.Drawing.Size(800, 33);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_exit});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(69, 29);
            this.file_menu.Text = "Файл";
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(180, 30);
            this.menu_exit.Text = "Выход";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.My_menu);
            this.MainMenuStrip = this.My_menu;
            this.Name = "FormMain";
            this.Text = "Реализация готовой продукции";
            this.My_menu.ResumeLayout(false);
            this.My_menu.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
    }
}

