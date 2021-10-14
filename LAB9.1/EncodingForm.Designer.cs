
namespace LAB8._1
{
    partial class EncodingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncodingForm));
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Items.AddRange(new object[] {
            resources.GetString("comboBoxEncoding.Items"),
            resources.GetString("comboBoxEncoding.Items1"),
            resources.GetString("comboBoxEncoding.Items2"),
            resources.GetString("comboBoxEncoding.Items3"),
            resources.GetString("comboBoxEncoding.Items4"),
            resources.GetString("comboBoxEncoding.Items5"),
            resources.GetString("comboBoxEncoding.Items6"),
            resources.GetString("comboBoxEncoding.Items7")});
            resources.ApplyResources(this.comboBoxEncoding, "comboBoxEncoding");
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // EncodingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxEncoding);
            this.Name = "EncodingForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.Button buttonExit;
    }
}