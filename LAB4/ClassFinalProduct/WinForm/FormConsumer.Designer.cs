
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
            this.saveCustomer = new System.Windows.Forms.Button();
            this.labelNameCustomer = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.labelAddr = new System.Windows.Forms.Label();
            this.inputNameNustomer = new System.Windows.Forms.TextBox();
            this.inpute_lastName = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.NumericUpDown();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.adrrInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).BeginInit();
            this.SuspendLayout();
            // 
            // saveCustomer
            // 
            this.saveCustomer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveCustomer.Location = new System.Drawing.Point(504, 224);
            this.saveCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveCustomer.Name = "saveCustomer";
            this.saveCustomer.Size = new System.Drawing.Size(199, 59);
            this.saveCustomer.TabIndex = 0;
            this.saveCustomer.Text = "Сохранить";
            this.saveCustomer.UseVisualStyleBackColor = true;
            this.saveCustomer.Click += new System.EventHandler(this.save_customer_Click);
            // 
            // labelNameCustomer
            // 
            this.labelNameCustomer.AutoSize = true;
            this.labelNameCustomer.Location = new System.Drawing.Point(41, 44);
            this.labelNameCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameCustomer.Name = "labelNameCustomer";
            this.labelNameCustomer.Size = new System.Drawing.Size(35, 17);
            this.labelNameCustomer.TabIndex = 1;
            this.labelNameCustomer.Text = "Имя";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(41, 94);
            this.labelLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(70, 17);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Фамилия";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(41, 142);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(62, 17);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Возраст";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(473, 39);
            this.label_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(68, 17);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Телефон";
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Location = new System.Drawing.Point(473, 89);
            this.labelAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(48, 17);
            this.labelAddr.TabIndex = 5;
            this.labelAddr.Text = "Адрес";
            // 
            // inputNameNustomer
            // 
            this.inputNameNustomer.Location = new System.Drawing.Point(161, 36);
            this.inputNameNustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputNameNustomer.Name = "inputNameNustomer";
            this.inputNameNustomer.Size = new System.Drawing.Size(132, 22);
            this.inputNameNustomer.TabIndex = 6;
            // 
            // inpute_lastName
            // 
            this.inpute_lastName.Location = new System.Drawing.Point(161, 85);
            this.inpute_lastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inpute_lastName.Name = "inpute_lastName";
            this.inpute_lastName.Size = new System.Drawing.Size(132, 22);
            this.inpute_lastName.TabIndex = 7;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(161, 142);
            this.ageInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageInput.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ageInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(133, 22);
            this.ageInput.TabIndex = 8;
            this.ageInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(569, 36);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(132, 22);
            this.phoneInput.TabIndex = 9;
            // 
            // adrrInput
            // 
            this.adrrInput.Location = new System.Drawing.Point(572, 85);
            this.adrrInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adrrInput.Name = "adrrInput";
            this.adrrInput.Size = new System.Drawing.Size(132, 22);
            this.adrrInput.TabIndex = 10;
            // 
            // FormConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 298);
            this.Controls.Add(this.adrrInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.inpute_lastName);
            this.Controls.Add(this.inputNameNustomer);
            this.Controls.Add(this.labelAddr);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelNameCustomer);
            this.Controls.Add(this.saveCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConsumer";
            this.Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveCustomer;
        private System.Windows.Forms.Label labelNameCustomer;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.TextBox inputNameNustomer;
        private System.Windows.Forms.TextBox inpute_lastName;
        private System.Windows.Forms.NumericUpDown ageInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox adrrInput;
    }
}