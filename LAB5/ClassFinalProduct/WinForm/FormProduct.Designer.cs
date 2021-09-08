
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
            this.label_title_product = new System.Windows.Forms.Label();
            this.label_trade_price = new System.Windows.Forms.Label();
            this.label_whosale_price = new System.Windows.Forms.Label();
            this.textBox_title_product = new System.Windows.Forms.TextBox();
            this.textBox_trade_price = new System.Windows.Forms.TextBox();
            this.textBox_whosale_price = new System.Windows.Forms.TextBox();
            this.label_description_product = new System.Windows.Forms.Label();
            this.description_product = new System.Windows.Forms.TextBox();
            this.save_product = new System.Windows.Forms.Button();
            this.h1_title_form_product = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title_product
            // 
            this.label_title_product.AutoSize = true;
            this.label_title_product.Location = new System.Drawing.Point(8, 116);
            this.label_title_product.Name = "label_title_product";
            this.label_title_product.Size = new System.Drawing.Size(63, 13);
            this.label_title_product.TabIndex = 0;
            this.label_title_product.Text = "Название: ";
            this.label_title_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_trade_price
            // 
            this.label_trade_price.AutoSize = true;
            this.label_trade_price.Location = new System.Drawing.Point(328, 113);
            this.label_trade_price.Name = "label_trade_price";
            this.label_trade_price.Size = new System.Drawing.Size(88, 13);
            this.label_trade_price.TabIndex = 1;
            this.label_trade_price.Text = "Розничная цена";
            // 
            // label_whosale_price
            // 
            this.label_whosale_price.AutoSize = true;
            this.label_whosale_price.Location = new System.Drawing.Point(328, 185);
            this.label_whosale_price.Name = "label_whosale_price";
            this.label_whosale_price.Size = new System.Drawing.Size(77, 13);
            this.label_whosale_price.TabIndex = 3;
            this.label_whosale_price.Text = "Оптовая цена";
            // 
            // textBox_title_product
            // 
            this.textBox_title_product.Location = new System.Drawing.Point(77, 113);
            this.textBox_title_product.Name = "textBox_title_product";
            this.textBox_title_product.Size = new System.Drawing.Size(100, 20);
            this.textBox_title_product.TabIndex = 4;
            // 
            // textBox_trade_price
            // 
            this.textBox_trade_price.Location = new System.Drawing.Point(422, 110);
            this.textBox_trade_price.Name = "textBox_trade_price";
            this.textBox_trade_price.Size = new System.Drawing.Size(100, 20);
            this.textBox_trade_price.TabIndex = 5;
            // 
            // textBox_whosale_price
            // 
            this.textBox_whosale_price.Location = new System.Drawing.Point(422, 182);
            this.textBox_whosale_price.Name = "textBox_whosale_price";
            this.textBox_whosale_price.Size = new System.Drawing.Size(100, 20);
            this.textBox_whosale_price.TabIndex = 7;
            // 
            // label_description_product
            // 
            this.label_description_product.AutoSize = true;
            this.label_description_product.Location = new System.Drawing.Point(12, 172);
            this.label_description_product.Name = "label_description_product";
            this.label_description_product.Size = new System.Drawing.Size(57, 13);
            this.label_description_product.TabIndex = 8;
            this.label_description_product.Text = "Описание";
            // 
            // description_product
            // 
            this.description_product.Location = new System.Drawing.Point(77, 172);
            this.description_product.Multiline = true;
            this.description_product.Name = "description_product";
            this.description_product.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.description_product.Size = new System.Drawing.Size(182, 117);
            this.description_product.TabIndex = 9;
            // 
            // save_product
            // 
            this.save_product.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_product.Location = new System.Drawing.Point(358, 248);
            this.save_product.Name = "save_product";
            this.save_product.Size = new System.Drawing.Size(164, 59);
            this.save_product.TabIndex = 10;
            this.save_product.Text = "Сохранить";
            this.save_product.UseVisualStyleBackColor = true;
            this.save_product.Click += new System.EventHandler(this.save_product_Click);
            // 
            // h1_title_form_product
            // 
            this.h1_title_form_product.AutoSize = true;
            this.h1_title_form_product.Location = new System.Drawing.Point(163, 31);
            this.h1_title_form_product.Name = "h1_title_form_product";
            this.h1_title_form_product.Size = new System.Drawing.Size(38, 13);
            this.h1_title_form_product.TabIndex = 11;
            this.h1_title_form_product.Text = "Товар";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 319);
            this.Controls.Add(this.h1_title_form_product);
            this.Controls.Add(this.save_product);
            this.Controls.Add(this.description_product);
            this.Controls.Add(this.label_description_product);
            this.Controls.Add(this.textBox_whosale_price);
            this.Controls.Add(this.textBox_trade_price);
            this.Controls.Add(this.textBox_title_product);
            this.Controls.Add(this.label_whosale_price);
            this.Controls.Add(this.label_trade_price);
            this.Controls.Add(this.label_title_product);
            this.Name = "FormProduct";
            this.Text = "Добавить товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title_product;
        private System.Windows.Forms.Label label_trade_price;
        private System.Windows.Forms.Label label_whosale_price;
        private System.Windows.Forms.TextBox textBox_title_product;
        private System.Windows.Forms.TextBox textBox_trade_price;
        private System.Windows.Forms.TextBox textBox_whosale_price;
        private System.Windows.Forms.Label label_description_product;
        private System.Windows.Forms.TextBox description_product;
        private System.Windows.Forms.Button save_product;
        private System.Windows.Forms.Label h1_title_form_product;
    }
}