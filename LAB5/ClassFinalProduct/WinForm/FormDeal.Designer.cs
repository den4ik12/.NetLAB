
namespace WinForm
{
    partial class FormDeal
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
            this.dateTimePicker_deal = new System.Windows.Forms.DateTimePicker();
            this.label_product_deal = new System.Windows.Forms.Label();
            this.label_count_deal = new System.Windows.Forms.Label();
            this.label_consumer_deal = new System.Windows.Forms.Label();
            this.label_opt_deal = new System.Windows.Forms.Label();
            this.label_date_deal = new System.Windows.Forms.Label();
            this.checkBox_wholesale = new System.Windows.Forms.CheckBox();
            this.comboBox_consumer = new System.Windows.Forms.ComboBox();
            this.numericUpDown_count_product = new System.Windows.Forms.NumericUpDown();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.button_save_deal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count_product)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_deal
            // 
            this.dateTimePicker_deal.Location = new System.Drawing.Point(102, 236);
            this.dateTimePicker_deal.Name = "dateTimePicker_deal";
            this.dateTimePicker_deal.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker_deal.TabIndex = 0;
            // 
            // label_product_deal
            // 
            this.label_product_deal.AutoSize = true;
            this.label_product_deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_product_deal.Location = new System.Drawing.Point(22, 58);
            this.label_product_deal.Name = "label_product_deal";
            this.label_product_deal.Size = new System.Drawing.Size(58, 20);
            this.label_product_deal.TabIndex = 1;
            this.label_product_deal.Text = "Товар:";
            // 
            // label_count_deal
            // 
            this.label_count_deal.AutoSize = true;
            this.label_count_deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count_deal.Location = new System.Drawing.Point(22, 106);
            this.label_count_deal.Name = "label_count_deal";
            this.label_count_deal.Size = new System.Drawing.Size(104, 20);
            this.label_count_deal.TabIndex = 2;
            this.label_count_deal.Text = "Количество:";
            // 
            // label_consumer_deal
            // 
            this.label_consumer_deal.AutoSize = true;
            this.label_consumer_deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_consumer_deal.Location = new System.Drawing.Point(22, 149);
            this.label_consumer_deal.Name = "label_consumer_deal";
            this.label_consumer_deal.Size = new System.Drawing.Size(104, 20);
            this.label_consumer_deal.TabIndex = 3;
            this.label_consumer_deal.Text = "Покупатель:";
            // 
            // label_opt_deal
            // 
            this.label_opt_deal.AutoSize = true;
            this.label_opt_deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_opt_deal.Location = new System.Drawing.Point(22, 191);
            this.label_opt_deal.Name = "label_opt_deal";
            this.label_opt_deal.Size = new System.Drawing.Size(141, 20);
            this.label_opt_deal.TabIndex = 4;
            this.label_opt_deal.Text = "Оптовая закупка:";
            // 
            // label_date_deal
            // 
            this.label_date_deal.AutoSize = true;
            this.label_date_deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date_deal.Location = new System.Drawing.Point(25, 236);
            this.label_date_deal.Name = "label_date_deal";
            this.label_date_deal.Size = new System.Drawing.Size(52, 20);
            this.label_date_deal.TabIndex = 5;
            this.label_date_deal.Text = "Дата:";
            // 
            // checkBox_wholesale
            // 
            this.checkBox_wholesale.AutoSize = true;
            this.checkBox_wholesale.Location = new System.Drawing.Point(169, 197);
            this.checkBox_wholesale.Name = "checkBox_wholesale";
            this.checkBox_wholesale.Size = new System.Drawing.Size(15, 14);
            this.checkBox_wholesale.TabIndex = 6;
            this.checkBox_wholesale.UseVisualStyleBackColor = true;
            this.checkBox_wholesale.CheckedChanged += new System.EventHandler(this.checkBox_wholesale_CheckedChanged);
            // 
            // comboBox_consumer
            // 
            this.comboBox_consumer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_consumer.FormattingEnabled = true;
            this.comboBox_consumer.Location = new System.Drawing.Point(132, 149);
            this.comboBox_consumer.Name = "comboBox_consumer";
            this.comboBox_consumer.Size = new System.Drawing.Size(121, 21);
            this.comboBox_consumer.TabIndex = 7;
            // 
            // numericUpDown_count_product
            // 
            this.numericUpDown_count_product.Location = new System.Drawing.Point(133, 105);
            this.numericUpDown_count_product.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_count_product.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_count_product.Name = "numericUpDown_count_product";
            this.numericUpDown_count_product.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_count_product.TabIndex = 8;
            this.numericUpDown_count_product.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_product
            // 
            this.comboBox_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(87, 56);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(121, 21);
            this.comboBox_product.TabIndex = 9;
            // 
            // button_save_deal
            // 
            this.button_save_deal.Location = new System.Drawing.Point(43, 300);
            this.button_save_deal.Name = "button_save_deal";
            this.button_save_deal.Size = new System.Drawing.Size(231, 44);
            this.button_save_deal.TabIndex = 10;
            this.button_save_deal.Text = "Сохранить";
            this.button_save_deal.UseVisualStyleBackColor = true;
            this.button_save_deal.Click += new System.EventHandler(this.button_save_deal_Click);
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 382);
            this.Controls.Add(this.button_save_deal);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.numericUpDown_count_product);
            this.Controls.Add(this.comboBox_consumer);
            this.Controls.Add(this.checkBox_wholesale);
            this.Controls.Add(this.label_date_deal);
            this.Controls.Add(this.label_opt_deal);
            this.Controls.Add(this.label_consumer_deal);
            this.Controls.Add(this.label_count_deal);
            this.Controls.Add(this.label_product_deal);
            this.Controls.Add(this.dateTimePicker_deal);
            this.Name = "FormDeal";
            this.Text = "FormDeal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_count_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_deal;
        private System.Windows.Forms.Label label_product_deal;
        private System.Windows.Forms.Label label_count_deal;
        private System.Windows.Forms.Label label_consumer_deal;
        private System.Windows.Forms.Label label_opt_deal;
        private System.Windows.Forms.Label label_date_deal;
        private System.Windows.Forms.CheckBox checkBox_wholesale;
        private System.Windows.Forms.ComboBox comboBox_consumer;
        private System.Windows.Forms.NumericUpDown numericUpDown_count_product;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.Button button_save_deal;
    }
}