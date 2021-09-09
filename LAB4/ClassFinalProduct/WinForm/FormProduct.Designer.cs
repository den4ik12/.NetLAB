
namespace WinForm
{
    partial class FormProduct
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
            this.labelTitleProduct = new System.Windows.Forms.Label();
            this.labelTradePrice = new System.Windows.Forms.Label();
            this.labelWhosalePrice = new System.Windows.Forms.Label();
            this.textBoxTitleProduct = new System.Windows.Forms.TextBox();
            this.textBoxTradePrice = new System.Windows.Forms.TextBox();
            this.textBoxWhosalePrice = new System.Windows.Forms.TextBox();
            this.labelDescriptionProduct = new System.Windows.Forms.Label();
            this.descriptionProduct = new System.Windows.Forms.TextBox();
            this.saveProduct = new System.Windows.Forms.Button();
            this.h1TitleFormProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleProduct
            // 
            this.labelTitleProduct.AutoSize = true;
            this.labelTitleProduct.Location = new System.Drawing.Point(11, 143);
            this.labelTitleProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleProduct.Name = "labelTitleProduct";
            this.labelTitleProduct.Size = new System.Drawing.Size(80, 17);
            this.labelTitleProduct.TabIndex = 0;
            this.labelTitleProduct.Text = "Название: ";
            this.labelTitleProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTradePrice
            // 
            this.labelTradePrice.AutoSize = true;
            this.labelTradePrice.Location = new System.Drawing.Point(437, 139);
            this.labelTradePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTradePrice.Name = "labelTradePrice";
            this.labelTradePrice.Size = new System.Drawing.Size(116, 17);
            this.labelTradePrice.TabIndex = 1;
            this.labelTradePrice.Text = "Розничная цена";
            // 
            // labelWhosalePrice
            // 
            this.labelWhosalePrice.AutoSize = true;
            this.labelWhosalePrice.Location = new System.Drawing.Point(437, 228);
            this.labelWhosalePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhosalePrice.Name = "labelWhosalePrice";
            this.labelWhosalePrice.Size = new System.Drawing.Size(101, 17);
            this.labelWhosalePrice.TabIndex = 3;
            this.labelWhosalePrice.Text = "Оптовая цена";
            // 
            // textBoxTitleProduct
            // 
            this.textBoxTitleProduct.Location = new System.Drawing.Point(103, 139);
            this.textBoxTitleProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTitleProduct.Name = "textBoxTitleProduct";
            this.textBoxTitleProduct.Size = new System.Drawing.Size(132, 22);
            this.textBoxTitleProduct.TabIndex = 4;
            // 
            // textBoxTradePrice
            // 
            this.textBoxTradePrice.Location = new System.Drawing.Point(563, 135);
            this.textBoxTradePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTradePrice.Name = "textBoxTradePrice";
            this.textBoxTradePrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxTradePrice.TabIndex = 5;
            // 
            // textBoxWhosalePrice
            // 
            this.textBoxWhosalePrice.Location = new System.Drawing.Point(563, 224);
            this.textBoxWhosalePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWhosalePrice.Name = "textBoxWhosalePrice";
            this.textBoxWhosalePrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxWhosalePrice.TabIndex = 7;
            // 
            // labelDescriptionProduct
            // 
            this.labelDescriptionProduct.AutoSize = true;
            this.labelDescriptionProduct.Location = new System.Drawing.Point(16, 212);
            this.labelDescriptionProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionProduct.Name = "labelDescriptionProduct";
            this.labelDescriptionProduct.Size = new System.Drawing.Size(74, 17);
            this.labelDescriptionProduct.TabIndex = 8;
            this.labelDescriptionProduct.Text = "Описание";
            // 
            // descriptionProduct
            // 
            this.descriptionProduct.Location = new System.Drawing.Point(103, 212);
            this.descriptionProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionProduct.Multiline = true;
            this.descriptionProduct.Name = "descriptionProduct";
            this.descriptionProduct.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionProduct.Size = new System.Drawing.Size(241, 143);
            this.descriptionProduct.TabIndex = 9;
            // 
            // saveProduct
            // 
            this.saveProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveProduct.Location = new System.Drawing.Point(477, 305);
            this.saveProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(219, 73);
            this.saveProduct.TabIndex = 10;
            this.saveProduct.Text = "Сохранить";
            this.saveProduct.UseVisualStyleBackColor = true;
            this.saveProduct.Click += new System.EventHandler(this.save_product_Click);
            // 
            // h1TitleFormProduct
            // 
            this.h1TitleFormProduct.AutoSize = true;
            this.h1TitleFormProduct.Location = new System.Drawing.Point(217, 38);
            this.h1TitleFormProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.h1TitleFormProduct.Name = "h1TitleFormProduct";
            this.h1TitleFormProduct.Size = new System.Drawing.Size(48, 17);
            this.h1TitleFormProduct.TabIndex = 11;
            this.h1TitleFormProduct.Text = "Товар";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 393);
            this.Controls.Add(this.h1TitleFormProduct);
            this.Controls.Add(this.saveProduct);
            this.Controls.Add(this.descriptionProduct);
            this.Controls.Add(this.labelDescriptionProduct);
            this.Controls.Add(this.textBoxWhosalePrice);
            this.Controls.Add(this.textBoxTradePrice);
            this.Controls.Add(this.textBoxTitleProduct);
            this.Controls.Add(this.labelWhosalePrice);
            this.Controls.Add(this.labelTradePrice);
            this.Controls.Add(this.labelTitleProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProduct";
            this.Text = "Добавить товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleProduct;
        private System.Windows.Forms.Label labelTradePrice;
        private System.Windows.Forms.Label labelWhosalePrice;
        private System.Windows.Forms.TextBox textBoxTitleProduct;
        private System.Windows.Forms.TextBox textBoxTradePrice;
        private System.Windows.Forms.TextBox textBoxWhosalePrice;
        private System.Windows.Forms.Label labelDescriptionProduct;
        private System.Windows.Forms.TextBox descriptionProduct;
        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.Label h1TitleFormProduct;
    }
}