
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
            this.textBoxDescriptionProduct = new System.Windows.Forms.TextBox();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.labelTitleFormProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleProduct
            // 
            this.labelTitleProduct.AutoSize = true;
            this.labelTitleProduct.Location = new System.Drawing.Point(8, 116);
            this.labelTitleProduct.Name = "labelTitleProduct";
            this.labelTitleProduct.Size = new System.Drawing.Size(63, 13);
            this.labelTitleProduct.TabIndex = 0;
            this.labelTitleProduct.Text = "Название: ";
            this.labelTitleProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTradePrice
            // 
            this.labelTradePrice.AutoSize = true;
            this.labelTradePrice.Location = new System.Drawing.Point(328, 113);
            this.labelTradePrice.Name = "labelTradePrice";
            this.labelTradePrice.Size = new System.Drawing.Size(88, 13);
            this.labelTradePrice.TabIndex = 1;
            this.labelTradePrice.Text = "Розничная цена";
            // 
            // labelWhosalePrice
            // 
            this.labelWhosalePrice.AutoSize = true;
            this.labelWhosalePrice.Location = new System.Drawing.Point(328, 185);
            this.labelWhosalePrice.Name = "labelWhosalePrice";
            this.labelWhosalePrice.Size = new System.Drawing.Size(77, 13);
            this.labelWhosalePrice.TabIndex = 3;
            this.labelWhosalePrice.Text = "Оптовая цена";
            // 
            // textBoxTitleProduct
            // 
            this.textBoxTitleProduct.Location = new System.Drawing.Point(77, 113);
            this.textBoxTitleProduct.Name = "textBoxTitleProduct";
            this.textBoxTitleProduct.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitleProduct.TabIndex = 4;
            // 
            // textBoxTradePrice
            // 
            this.textBoxTradePrice.Location = new System.Drawing.Point(422, 110);
            this.textBoxTradePrice.Name = "textBoxTradePrice";
            this.textBoxTradePrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxTradePrice.TabIndex = 5;
            // 
            // textBoxWhosalePrice
            // 
            this.textBoxWhosalePrice.Location = new System.Drawing.Point(422, 182);
            this.textBoxWhosalePrice.Name = "textBoxWhosalePrice";
            this.textBoxWhosalePrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxWhosalePrice.TabIndex = 7;
            // 
            // labelDescriptionProduct
            // 
            this.labelDescriptionProduct.AutoSize = true;
            this.labelDescriptionProduct.Location = new System.Drawing.Point(12, 172);
            this.labelDescriptionProduct.Name = "labelDescriptionProduct";
            this.labelDescriptionProduct.Size = new System.Drawing.Size(57, 13);
            this.labelDescriptionProduct.TabIndex = 8;
            this.labelDescriptionProduct.Text = "Описание";
            // 
            // textBoxDescriptionProduct
            // 
            this.textBoxDescriptionProduct.Location = new System.Drawing.Point(77, 172);
            this.textBoxDescriptionProduct.Multiline = true;
            this.textBoxDescriptionProduct.Name = "textBoxDescriptionProduct";
            this.textBoxDescriptionProduct.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescriptionProduct.Size = new System.Drawing.Size(182, 117);
            this.textBoxDescriptionProduct.TabIndex = 9;
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveProduct.Location = new System.Drawing.Point(358, 248);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(164, 59);
            this.buttonSaveProduct.TabIndex = 10;
            this.buttonSaveProduct.Text = "Сохранить";
            this.buttonSaveProduct.UseVisualStyleBackColor = true;
            this.buttonSaveProduct.Click += new System.EventHandler(this.Save_product_Click);
            // 
            // labelTitleFormProduct
            // 
            this.labelTitleFormProduct.AutoSize = true;
            this.labelTitleFormProduct.Location = new System.Drawing.Point(163, 31);
            this.labelTitleFormProduct.Name = "labelTitleFormProduct";
            this.labelTitleFormProduct.Size = new System.Drawing.Size(38, 13);
            this.labelTitleFormProduct.TabIndex = 11;
            this.labelTitleFormProduct.Text = "Товар";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 319);
            this.Controls.Add(this.labelTitleFormProduct);
            this.Controls.Add(this.buttonSaveProduct);
            this.Controls.Add(this.textBoxDescriptionProduct);
            this.Controls.Add(this.labelDescriptionProduct);
            this.Controls.Add(this.textBoxWhosalePrice);
            this.Controls.Add(this.textBoxTradePrice);
            this.Controls.Add(this.textBoxTitleProduct);
            this.Controls.Add(this.labelWhosalePrice);
            this.Controls.Add(this.labelTradePrice);
            this.Controls.Add(this.labelTitleProduct);
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
        private System.Windows.Forms.TextBox textBoxDescriptionProduct;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Label labelTitleFormProduct;
    }
}