
namespace LAB11
{
    partial class FormAddAuto
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.buttonSendCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 25);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(41, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(15, 58);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(86, 13);
            this.labelProducer.TabIndex = 1;
            this.labelProducer.Text = "Производитель";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(128, 25);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 2;
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(128, 58);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(100, 20);
            this.textBoxProducer.TabIndex = 3;
            // 
            // buttonSendCar
            // 
            this.buttonSendCar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSendCar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSendCar.Location = new System.Drawing.Point(0, 105);
            this.buttonSendCar.Name = "buttonSendCar";
            this.buttonSendCar.Size = new System.Drawing.Size(248, 62);
            this.buttonSendCar.TabIndex = 4;
            this.buttonSendCar.Text = "Добавить";
            this.buttonSendCar.UseVisualStyleBackColor = true;
            this.buttonSendCar.Click += new System.EventHandler(this.buttonSendCar_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 167);
            this.Controls.Add(this.buttonSendCar);
            this.Controls.Add(this.textBoxProducer);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelProducer);
            this.Controls.Add(this.labelNumber);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.Button buttonSendCar;
    }
}