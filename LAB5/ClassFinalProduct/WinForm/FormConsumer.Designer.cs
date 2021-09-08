
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
            this.save_customer = new System.Windows.Forms.Button();
            this.label_name_customer = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_addr = new System.Windows.Forms.Label();
            this.input_name_customer = new System.Windows.Forms.TextBox();
            this.inpute_lastName = new System.Windows.Forms.TextBox();
            this.Age_input = new System.Windows.Forms.NumericUpDown();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.adrr_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Age_input)).BeginInit();
            this.SuspendLayout();
            // 
            // save_customer
            // 
            this.save_customer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_customer.Location = new System.Drawing.Point(378, 182);
            this.save_customer.Name = "save_customer";
            this.save_customer.Size = new System.Drawing.Size(149, 48);
            this.save_customer.TabIndex = 0;
            this.save_customer.Text = "Сохранить";
            this.save_customer.UseVisualStyleBackColor = true;
            this.save_customer.Click += new System.EventHandler(this.save_customer_Click);
            // 
            // label_name_customer
            // 
            this.label_name_customer.AutoSize = true;
            this.label_name_customer.Location = new System.Drawing.Point(31, 36);
            this.label_name_customer.Name = "label_name_customer";
            this.label_name_customer.Size = new System.Drawing.Size(29, 13);
            this.label_name_customer.TabIndex = 1;
            this.label_name_customer.Text = "Имя";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(31, 76);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(56, 13);
            this.label_lastname.TabIndex = 2;
            this.label_lastname.Text = "Фамилия";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(31, 115);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(49, 13);
            this.label_age.TabIndex = 3;
            this.label_age.Text = "Возраст";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(355, 32);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(52, 13);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Телефон";
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Location = new System.Drawing.Point(355, 72);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(38, 13);
            this.label_addr.TabIndex = 5;
            this.label_addr.Text = "Адрес";
            // 
            // input_name_customer
            // 
            this.input_name_customer.Location = new System.Drawing.Point(121, 29);
            this.input_name_customer.Name = "input_name_customer";
            this.input_name_customer.Size = new System.Drawing.Size(100, 20);
            this.input_name_customer.TabIndex = 6;
            // 
            // inpute_lastName
            // 
            this.inpute_lastName.Location = new System.Drawing.Point(121, 69);
            this.inpute_lastName.Name = "inpute_lastName";
            this.inpute_lastName.Size = new System.Drawing.Size(100, 20);
            this.inpute_lastName.TabIndex = 7;
            // 
            // Age_input
            // 
            this.Age_input.Location = new System.Drawing.Point(121, 115);
            this.Age_input.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Age_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age_input.Name = "Age_input";
            this.Age_input.Size = new System.Drawing.Size(100, 20);
            this.Age_input.TabIndex = 8;
            this.Age_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // phone_input
            // 
            this.phone_input.Location = new System.Drawing.Point(427, 29);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(100, 20);
            this.phone_input.TabIndex = 9;
            // 
            // adrr_input
            // 
            this.adrr_input.Location = new System.Drawing.Point(429, 69);
            this.adrr_input.Name = "adrr_input";
            this.adrr_input.Size = new System.Drawing.Size(100, 20);
            this.adrr_input.TabIndex = 10;
            // 
            // FormConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 242);
            this.Controls.Add(this.adrr_input);
            this.Controls.Add(this.phone_input);
            this.Controls.Add(this.Age_input);
            this.Controls.Add(this.inpute_lastName);
            this.Controls.Add(this.input_name_customer);
            this.Controls.Add(this.label_addr);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_name_customer);
            this.Controls.Add(this.save_customer);
            this.Name = "FormConsumer";
            this.Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.Age_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_customer;
        private System.Windows.Forms.Label label_name_customer;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.TextBox input_name_customer;
        private System.Windows.Forms.TextBox inpute_lastName;
        private System.Windows.Forms.NumericUpDown Age_input;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.TextBox adrr_input;
    }
}