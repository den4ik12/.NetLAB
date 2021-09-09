
namespace MyFormLab1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ok = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(164, 331);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(335, 79);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "button1";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(231, 143);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(187, 22);
            this.text.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button_ok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox text;
    }
}

