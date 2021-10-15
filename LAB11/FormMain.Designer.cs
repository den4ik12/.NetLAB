
namespace LAB11
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnHeaderAutoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProducerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadCars = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddCar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewProducers = new System.Windows.Forms.ListView();
            this.columnHeaderProducerIdPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitleProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountryProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripProducers = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadProducers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddProducer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateProducer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveProducer = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStripProducers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewCars);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Машины";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewCars
            // 
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAutoId,
            this.columnHeaderNumber,
            this.columnHeaderProducerID});
            this.listViewCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(3, 28);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(764, 393);
            this.listViewCars.TabIndex = 1;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderAutoId
            // 
            this.columnHeaderAutoId.Text = "ID Авто";
            this.columnHeaderAutoId.Width = 57;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Номер";
            this.columnHeaderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderNumber.Width = 93;
            // 
            // columnHeaderProducerID
            // 
            this.columnHeaderProducerID.Text = "ID Производителя";
            this.columnHeaderProducerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderProducerID.Width = 115;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadCars,
            this.toolStripButtonAddCar,
            this.toolStripButtonUpdate,
            this.toolStripButtonRemove});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLoadCars
            // 
            this.toolStripButtonLoadCars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadCars.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadCars.Image")));
            this.toolStripButtonLoadCars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadCars.Name = "toolStripButtonLoadCars";
            this.toolStripButtonLoadCars.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonLoadCars.Text = "Загрузить";
            this.toolStripButtonLoadCars.Click += new System.EventHandler(this.toolStripButtonLoadCars_Click);
            // 
            // toolStripButtonAddCar
            // 
            this.toolStripButtonAddCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddCar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddCar.Image")));
            this.toolStripButtonAddCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddCar.Name = "toolStripButtonAddCar";
            this.toolStripButtonAddCar.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonAddCar.Text = "Добавить";
            this.toolStripButtonAddCar.Click += new System.EventHandler(this.toolStripButtonAddCar_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdate.Text = "Обновить";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemove.Image")));
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonRemove.Text = "Удалить";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewProducers);
            this.tabPage2.Controls.Add(this.toolStripProducers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Производители";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewProducers
            // 
            this.listViewProducers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProducerIdPK,
            this.columnHeaderTitleProducer,
            this.columnHeaderCountryProducer});
            this.listViewProducers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProducers.HideSelection = false;
            this.listViewProducers.Location = new System.Drawing.Point(3, 28);
            this.listViewProducers.Name = "listViewProducers";
            this.listViewProducers.Size = new System.Drawing.Size(764, 393);
            this.listViewProducers.TabIndex = 2;
            this.listViewProducers.UseCompatibleStateImageBehavior = false;
            this.listViewProducers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProducerIdPK
            // 
            this.columnHeaderProducerIdPK.Text = "ID Производителя";
            this.columnHeaderProducerIdPK.Width = 111;
            // 
            // columnHeaderTitleProducer
            // 
            this.columnHeaderTitleProducer.Text = "Название";
            this.columnHeaderTitleProducer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTitleProducer.Width = 93;
            // 
            // columnHeaderCountryProducer
            // 
            this.columnHeaderCountryProducer.Text = "Страна производителя";
            this.columnHeaderCountryProducer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCountryProducer.Width = 163;
            // 
            // toolStripProducers
            // 
            this.toolStripProducers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadProducers,
            this.toolStripButtonAddProducer,
            this.toolStripButtonUpdateProducer,
            this.toolStripButtonRemoveProducer});
            this.toolStripProducers.Location = new System.Drawing.Point(3, 3);
            this.toolStripProducers.Name = "toolStripProducers";
            this.toolStripProducers.Size = new System.Drawing.Size(764, 25);
            this.toolStripProducers.TabIndex = 3;
            this.toolStripProducers.Text = "toolStrip2";
            // 
            // toolStripButtonLoadProducers
            // 
            this.toolStripButtonLoadProducers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadProducers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadProducers.Image")));
            this.toolStripButtonLoadProducers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadProducers.Name = "toolStripButtonLoadProducers";
            this.toolStripButtonLoadProducers.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonLoadProducers.Text = "Загрузить";
            this.toolStripButtonLoadProducers.Click += new System.EventHandler(this.toolStripButtonLoadProducers_Click);
            // 
            // toolStripButtonAddProducer
            // 
            this.toolStripButtonAddProducer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddProducer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProducer.Image")));
            this.toolStripButtonAddProducer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddProducer.Name = "toolStripButtonAddProducer";
            this.toolStripButtonAddProducer.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonAddProducer.Text = "Добавить";
            this.toolStripButtonAddProducer.Click += new System.EventHandler(this.toolStripButtonAddProducer_Click);
            // 
            // toolStripButtonUpdateProducer
            // 
            this.toolStripButtonUpdateProducer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateProducer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateProducer.Image")));
            this.toolStripButtonUpdateProducer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateProducer.Name = "toolStripButtonUpdateProducer";
            this.toolStripButtonUpdateProducer.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdateProducer.Text = "Обновить";
            this.toolStripButtonUpdateProducer.Click += new System.EventHandler(this.toolStripButtonUpdateProducer_Click);
            // 
            // toolStripButtonRemoveProducer
            // 
            this.toolStripButtonRemoveProducer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemoveProducer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveProducer.Image")));
            this.toolStripButtonRemoveProducer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveProducer.Name = "toolStripButtonRemoveProducer";
            this.toolStripButtonRemoveProducer.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonRemoveProducer.Text = "Удалить";
            this.toolStripButtonRemoveProducer.Click += new System.EventHandler(this.toolStripButtonRemoveProducer_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "CarManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStripProducers.ResumeLayout(false);
            this.toolStripProducers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ColumnHeader columnHeaderAutoId;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderProducerID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadCars;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddCar;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewProducers;
        private System.Windows.Forms.ColumnHeader columnHeaderProducerIdPK;
        private System.Windows.Forms.ColumnHeader columnHeaderTitleProducer;
        private System.Windows.Forms.ColumnHeader columnHeaderCountryProducer;
        private System.Windows.Forms.ToolStrip toolStripProducers;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadProducers;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddProducer;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateProducer;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveProducer;
    }
}

