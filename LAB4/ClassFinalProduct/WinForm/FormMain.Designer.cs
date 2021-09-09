
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
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangeProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangeConsumer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStripMy.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMy
            // 
            this.MenuStripMy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStripMy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripMy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemProduct,
            this.ToolStripMenuItemConsumer});
            this.MenuStripMy.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMy.Name = "MenuStripMy";
            this.MenuStripMy.Size = new System.Drawing.Size(1067, 40);
            this.MenuStripMy.TabIndex = 0;
            this.MenuStripMy.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(85, 36);
            this.ToolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(224, 36);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // ToolStripMenuItemProduct
            // 
            this.ToolStripMenuItemProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddProduct,
            this.ToolStripMenuItemChangeProduct});
            this.ToolStripMenuItemProduct.Name = "ToolStripMenuItemProduct";
            this.ToolStripMenuItemProduct.Size = new System.Drawing.Size(112, 36);
            this.ToolStripMenuItemProduct.Text = "Товары";
            // 
            // ToolStripMenuItemAddProduct
            // 
            this.ToolStripMenuItemAddProduct.Name = "ToolStripMenuItemAddProduct";
            this.ToolStripMenuItemAddProduct.Size = new System.Drawing.Size(266, 36);
            this.ToolStripMenuItemAddProduct.Text = "Добавить";
            this.ToolStripMenuItemAddProduct.Click += new System.EventHandler(this.add_product_MenuItem_Click);
            // 
            // ToolStripMenuItemChangeProduct
            // 
            this.ToolStripMenuItemChangeProduct.Name = "ToolStripMenuItemChangeProduct";
            this.ToolStripMenuItemChangeProduct.Size = new System.Drawing.Size(266, 36);
            this.ToolStripMenuItemChangeProduct.Text = "Редактировать";
            this.ToolStripMenuItemChangeProduct.Click += new System.EventHandler(this.change_product_MenuItem_Click);
            // 
            // ToolStripMenuItemConsumer
            // 
            this.ToolStripMenuItemConsumer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddConsumer,
            this.ToolStripMenuItemChangeConsumer});
            this.ToolStripMenuItemConsumer.Name = "ToolStripMenuItemConsumer";
            this.ToolStripMenuItemConsumer.Size = new System.Drawing.Size(160, 36);
            this.ToolStripMenuItemConsumer.Text = "Покупатели";
            // 
            // ToolStripMenuItemAddConsumer
            // 
            this.ToolStripMenuItemAddConsumer.Name = "ToolStripMenuItemAddConsumer";
            this.ToolStripMenuItemAddConsumer.Size = new System.Drawing.Size(266, 36);
            this.ToolStripMenuItemAddConsumer.Text = "Добавить";
            this.ToolStripMenuItemAddConsumer.Click += new System.EventHandler(this.add_consumer_menuItem_Click);
            // 
            // ToolStripMenuItemChangeConsumer
            // 
            this.ToolStripMenuItemChangeConsumer.Name = "ToolStripMenuItemChangeConsumer";
            this.ToolStripMenuItemChangeConsumer.Size = new System.Drawing.Size(266, 36);
            this.ToolStripMenuItemChangeConsumer.Text = "Редактировать";
            this.ToolStripMenuItemChangeConsumer.Click += new System.EventHandler(this.change_consumer_menuItem_Click);
            // 
            // MenuStripContext
            // 
            this.MenuStripContext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStripContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripContext.Name = "contextMenuStrip1";
            this.MenuStripContext.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MenuStripMy);
            this.MainMenuStrip = this.MenuStripMy;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Реализация готовой продукции";
            this.MenuStripMy.ResumeLayout(false);
            this.MenuStripMy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProduct;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddProduct;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeProduct;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConsumer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddConsumer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeConsumer;
        private System.Windows.Forms.ContextMenuStrip MenuStripContext;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    }
}

