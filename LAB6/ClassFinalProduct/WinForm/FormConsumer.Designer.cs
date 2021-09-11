
namespace WinForm
{
    partial class FormConsumer
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
            this.buttonSaveCustomer = new System.Windows.Forms.Button();
            this.labelNameCustomer = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddr = new System.Windows.Forms.Label();
            this.textBoxNameCustomer = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAdrrInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveCustomer
            // 
            this.buttonSaveCustomer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveCustomer.Location = new System.Drawing.Point(378, 182);
            this.buttonSaveCustomer.Name = "buttonSaveCustomer";
            this.buttonSaveCustomer.Size = new System.Drawing.Size(149, 48);
            this.buttonSaveCustomer.TabIndex = 0;
            this.buttonSaveCustomer.Text = "Сохранить";
            this.buttonSaveCustomer.UseVisualStyleBackColor = true;
            this.buttonSaveCustomer.Click += new System.EventHandler(this.Save_customer_Click);
            // 
            // labelNameCustomer
            // 
            this.labelNameCustomer.AutoSize = true;
            this.labelNameCustomer.Location = new System.Drawing.Point(31, 36);
            this.labelNameCustomer.Name = "labelNameCustomer";
            this.labelNameCustomer.Size = new System.Drawing.Size(29, 13);
            this.labelNameCustomer.TabIndex = 1;
            this.labelNameCustomer.Text = "Имя";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(31, 76);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(56, 13);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Фамилия";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(31, 115);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 13);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Возраст";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(355, 32);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Телефон";
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Location = new System.Drawing.Point(355, 72);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(38, 13);
            this.labelAddr.TabIndex = 5;
            this.labelAddr.Text = "Адрес";
            // 
            // textBoxNameCustomer
            // 
            this.textBoxNameCustomer.Location = new System.Drawing.Point(121, 29);
            this.textBoxNameCustomer.Name = "textBoxNameCustomer";
            this.textBoxNameCustomer.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCustomer.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(121, 69);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(121, 115);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownAge.TabIndex = 8;
            this.numericUpDownAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(427, 29);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxAdrrInput
            // 
            this.textBoxAdrrInput.Location = new System.Drawing.Point(429, 69);
            this.textBoxAdrrInput.Name = "textBoxAdrrInput";
            this.textBoxAdrrInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdrrInput.TabIndex = 10;
            // 
            // FormConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 242);
            this.Controls.Add(this.textBoxAdrrInput);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxNameCustomer);
            this.Controls.Add(this.labelAddr);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelNameCustomer);
            this.Controls.Add(this.buttonSaveCustomer);
            this.Name = "FormConsumer";
            this.Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCustomer;
        private System.Windows.Forms.Label labelNameCustomer;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.TextBox textBoxNameCustomer;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAdrrInput;
    }
}