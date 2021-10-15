
namespace LAB11
{
    partial class FormAddProducer
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
            this.labelTitleProducer = new System.Windows.Forms.Label();
            this.labelCountryProducer = new System.Windows.Forms.Label();
            this.textBoxTitleProducer = new System.Windows.Forms.TextBox();
            this.textBoxCountryProducer = new System.Windows.Forms.TextBox();
            this.buttonAddProducer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleProducer
            // 
            this.labelTitleProducer.AutoSize = true;
            this.labelTitleProducer.Location = new System.Drawing.Point(25, 20);
            this.labelTitleProducer.Name = "labelTitleProducer";
            this.labelTitleProducer.Size = new System.Drawing.Size(57, 13);
            this.labelTitleProducer.TabIndex = 0;
            this.labelTitleProducer.Text = "Название";
            // 
            // labelCountryProducer
            // 
            this.labelCountryProducer.AutoSize = true;
            this.labelCountryProducer.Location = new System.Drawing.Point(25, 65);
            this.labelCountryProducer.Name = "labelCountryProducer";
            this.labelCountryProducer.Size = new System.Drawing.Size(43, 13);
            this.labelCountryProducer.TabIndex = 1;
            this.labelCountryProducer.Text = "Страна";
            // 
            // textBoxTitleProducer
            // 
            this.textBoxTitleProducer.Location = new System.Drawing.Point(112, 16);
            this.textBoxTitleProducer.Name = "textBoxTitleProducer";
            this.textBoxTitleProducer.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitleProducer.TabIndex = 2;
            // 
            // textBoxCountryProducer
            // 
            this.textBoxCountryProducer.Location = new System.Drawing.Point(112, 61);
            this.textBoxCountryProducer.Name = "textBoxCountryProducer";
            this.textBoxCountryProducer.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountryProducer.TabIndex = 3;
            // 
            // buttonAddProducer
            // 
            this.buttonAddProducer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddProducer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddProducer.Location = new System.Drawing.Point(0, 102);
            this.buttonAddProducer.Name = "buttonAddProducer";
            this.buttonAddProducer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddProducer.Size = new System.Drawing.Size(289, 62);
            this.buttonAddProducer.TabIndex = 4;
            this.buttonAddProducer.Text = "Добавить";
            this.buttonAddProducer.UseVisualStyleBackColor = true;
            this.buttonAddProducer.Click += new System.EventHandler(this.buttonAddProducer_Click);
            // 
            // FormAddProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 164);
            this.Controls.Add(this.buttonAddProducer);
            this.Controls.Add(this.textBoxCountryProducer);
            this.Controls.Add(this.textBoxTitleProducer);
            this.Controls.Add(this.labelCountryProducer);
            this.Controls.Add(this.labelTitleProducer);
            this.Name = "FormAddProducer";
            this.Text = "FormAddProducer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleProducer;
        private System.Windows.Forms.Label labelCountryProducer;
        private System.Windows.Forms.TextBox textBoxTitleProducer;
        private System.Windows.Forms.TextBox textBoxCountryProducer;
        private System.Windows.Forms.Button buttonAddProducer;
    }
}