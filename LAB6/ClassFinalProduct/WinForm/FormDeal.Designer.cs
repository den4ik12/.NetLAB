
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
            this.dateTimePickerDeal = new System.Windows.Forms.DateTimePicker();
            this.labelProductDeal = new System.Windows.Forms.Label();
            this.labelCountDeal = new System.Windows.Forms.Label();
            this.labelConsumerDeal = new System.Windows.Forms.Label();
            this.labelOptDeal = new System.Windows.Forms.Label();
            this.labelDateDeal = new System.Windows.Forms.Label();
            this.checkBoxWholesale = new System.Windows.Forms.CheckBox();
            this.comboBoxConsumer = new System.Windows.Forms.ComboBox();
            this.numericUpDownCountProduct = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.buttonSaveDeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDeal
            // 
            this.dateTimePickerDeal.Location = new System.Drawing.Point(136, 290);
            this.dateTimePickerDeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDeal.Name = "dateTimePickerDeal";
            this.dateTimePickerDeal.Size = new System.Drawing.Size(269, 22);
            this.dateTimePickerDeal.TabIndex = 0;
            // 
            // labelProductDeal
            // 
            this.labelProductDeal.AutoSize = true;
            this.labelProductDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductDeal.Location = new System.Drawing.Point(29, 71);
            this.labelProductDeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductDeal.Name = "labelProductDeal";
            this.labelProductDeal.Size = new System.Drawing.Size(72, 25);
            this.labelProductDeal.TabIndex = 1;
            this.labelProductDeal.Text = "Товар:";
            // 
            // labelCountDeal
            // 
            this.labelCountDeal.AutoSize = true;
            this.labelCountDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountDeal.Location = new System.Drawing.Point(29, 130);
            this.labelCountDeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountDeal.Name = "labelCountDeal";
            this.labelCountDeal.Size = new System.Drawing.Size(129, 25);
            this.labelCountDeal.TabIndex = 2;
            this.labelCountDeal.Text = "Количество:";
            // 
            // labelConsumerDeal
            // 
            this.labelConsumerDeal.AutoSize = true;
            this.labelConsumerDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConsumerDeal.Location = new System.Drawing.Point(29, 183);
            this.labelConsumerDeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConsumerDeal.Name = "labelConsumerDeal";
            this.labelConsumerDeal.Size = new System.Drawing.Size(128, 25);
            this.labelConsumerDeal.TabIndex = 3;
            this.labelConsumerDeal.Text = "Покупатель:";
            // 
            // labelOptDeal
            // 
            this.labelOptDeal.AutoSize = true;
            this.labelOptDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptDeal.Location = new System.Drawing.Point(29, 235);
            this.labelOptDeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOptDeal.Name = "labelOptDeal";
            this.labelOptDeal.Size = new System.Drawing.Size(174, 25);
            this.labelOptDeal.TabIndex = 4;
            this.labelOptDeal.Text = "Оптовая закупка:";
            // 
            // labelDateDeal
            // 
            this.labelDateDeal.AutoSize = true;
            this.labelDateDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateDeal.Location = new System.Drawing.Point(33, 290);
            this.labelDateDeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateDeal.Name = "labelDateDeal";
            this.labelDateDeal.Size = new System.Drawing.Size(67, 25);
            this.labelDateDeal.TabIndex = 5;
            this.labelDateDeal.Text = "Дата:";
            // 
            // checkBoxWholesale
            // 
            this.checkBoxWholesale.AutoSize = true;
            this.checkBoxWholesale.Location = new System.Drawing.Point(225, 242);
            this.checkBoxWholesale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxWholesale.Name = "checkBoxWholesale";
            this.checkBoxWholesale.Size = new System.Drawing.Size(18, 17);
            this.checkBoxWholesale.TabIndex = 6;
            this.checkBoxWholesale.UseVisualStyleBackColor = true;
            this.checkBoxWholesale.CheckedChanged += new System.EventHandler(this.checkBox_wholesale_CheckedChanged);
            // 
            // comboBoxConsumer
            // 
            this.comboBoxConsumer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsumer.FormattingEnabled = true;
            this.comboBoxConsumer.Location = new System.Drawing.Point(176, 183);
            this.comboBoxConsumer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxConsumer.Name = "comboBoxConsumer";
            this.comboBoxConsumer.Size = new System.Drawing.Size(160, 24);
            this.comboBoxConsumer.TabIndex = 7;
            // 
            // numericUpDownCountProduct
            // 
            this.numericUpDownCountProduct.Location = new System.Drawing.Point(177, 129);
            this.numericUpDownCountProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownCountProduct.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCountProduct.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountProduct.Name = "numericUpDownCountProduct";
            this.numericUpDownCountProduct.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownCountProduct.TabIndex = 8;
            this.numericUpDownCountProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(116, 69);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProduct.TabIndex = 9;
            // 
            // buttonSaveDeal
            // 
            this.buttonSaveDeal.Location = new System.Drawing.Point(57, 369);
            this.buttonSaveDeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveDeal.Name = "buttonSaveDeal";
            this.buttonSaveDeal.Size = new System.Drawing.Size(308, 54);
            this.buttonSaveDeal.TabIndex = 10;
            this.buttonSaveDeal.Text = "Сохранить";
            this.buttonSaveDeal.UseVisualStyleBackColor = true;
            this.buttonSaveDeal.Click += new System.EventHandler(this.button_save_deal_Click);
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 470);
            this.Controls.Add(this.buttonSaveDeal);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.numericUpDownCountProduct);
            this.Controls.Add(this.comboBoxConsumer);
            this.Controls.Add(this.checkBoxWholesale);
            this.Controls.Add(this.labelDateDeal);
            this.Controls.Add(this.labelOptDeal);
            this.Controls.Add(this.labelConsumerDeal);
            this.Controls.Add(this.labelCountDeal);
            this.Controls.Add(this.labelProductDeal);
            this.Controls.Add(this.dateTimePickerDeal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDeal";
            this.Text = "FormDeal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDeal;
        private System.Windows.Forms.Label labelProductDeal;
        private System.Windows.Forms.Label labelCountDeal;
        private System.Windows.Forms.Label labelConsumerDeal;
        private System.Windows.Forms.Label labelOptDeal;
        private System.Windows.Forms.Label labelDateDeal;
        private System.Windows.Forms.CheckBox checkBoxWholesale;
        private System.Windows.Forms.ComboBox comboBoxConsumer;
        private System.Windows.Forms.NumericUpDown numericUpDownCountProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button buttonSaveDeal;
    }
}