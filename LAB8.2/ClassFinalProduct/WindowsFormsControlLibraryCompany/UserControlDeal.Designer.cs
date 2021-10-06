namespace WindowsFormsControlLibraryCompany
{
    partial class UserControlDeal
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProduct = new System.Windows.Forms.Label();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.labelConsumer = new System.Windows.Forms.Label();
            this.textBoxConsumer = new System.Windows.Forms.TextBox();
            this.labelDateDeal = new System.Windows.Forms.Label();
            this.textBoxDateDeal = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(16, 12);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(41, 13);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Товар:";
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(92, 8);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(101, 20);
            this.textBoxProduct.TabIndex = 1;
            // 
            // labelConsumer
            // 
            this.labelConsumer.AutoSize = true;
            this.labelConsumer.Location = new System.Drawing.Point(209, 12);
            this.labelConsumer.Name = "labelConsumer";
            this.labelConsumer.Size = new System.Drawing.Size(70, 13);
            this.labelConsumer.TabIndex = 2;
            this.labelConsumer.Text = "Покупатель:";
            // 
            // textBoxConsumer
            // 
            this.textBoxConsumer.Location = new System.Drawing.Point(295, 8);
            this.textBoxConsumer.Name = "textBoxConsumer";
            this.textBoxConsumer.Size = new System.Drawing.Size(132, 20);
            this.textBoxConsumer.TabIndex = 3;
            // 
            // labelDateDeal
            // 
            this.labelDateDeal.AutoSize = true;
            this.labelDateDeal.Location = new System.Drawing.Point(16, 43);
            this.labelDateDeal.Name = "labelDateDeal";
            this.labelDateDeal.Size = new System.Drawing.Size(75, 13);
            this.labelDateDeal.TabIndex = 4;
            this.labelDateDeal.Text = "Дата сделки:";
            // 
            // textBoxDateDeal
            // 
            this.textBoxDateDeal.Location = new System.Drawing.Point(106, 39);
            this.textBoxDateDeal.Name = "textBoxDateDeal";
            this.textBoxDateDeal.Size = new System.Drawing.Size(116, 20);
            this.textBoxDateDeal.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(400, 37);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(27, 21);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "x";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(243, 42);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Количество:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(311, 37);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(73, 20);
            this.textBoxCount.TabIndex = 9;
            // 
            // UserControlDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxDateDeal);
            this.Controls.Add(this.labelDateDeal);
            this.Controls.Add(this.textBoxConsumer);
            this.Controls.Add(this.labelConsumer);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Name = "UserControlDeal";
            this.Size = new System.Drawing.Size(474, 70);
            this.Click += new System.EventHandler(this.UserControlDeal_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlDeal_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label labelConsumer;
        private System.Windows.Forms.TextBox textBoxConsumer;
        private System.Windows.Forms.Label labelDateDeal;
        private System.Windows.Forms.TextBox textBoxDateDeal;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}
