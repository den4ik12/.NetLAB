using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB12
{
    public partial class Form1 : Form
    {
        int counter = 0; // сквозной номер строки в массиве строк, которые выводятся
        int curPage; // текущая страница

        public Form1()
        {
            InitializeComponent();
            loginTextBox.Validating += loginBox_Validating;
            firstNameTextBox.Validating += FirstNameTextBox_Validating;
            lastNameTextBox.Validating += LastNameTextBox_Validating;
        }

        private void LastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameTextBox.Text))
            {
                errorProvider1.SetError(lastNameTextBox, "Не указана фамилия!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void FirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(firstNameTextBox.Text))
            {
                errorProvider1.SetError(firstNameTextBox, "Не указано имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void autoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataSet1.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.carDataSet1.Producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataSet1.Auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.carDataSet1.Auto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataSet1.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.carDataSet1.Producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.carDataSet.Producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDataSet.Auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.carDataSet.Auto);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.autoTableAdapter.Update(this.carDataSet.Auto);
        }
        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDataSet);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void загрузитьТаблицуПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.autoTableAdapter.Fill(this.carDataSet.Auto);
        }

        private void loadDBProducerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.producerTableAdapter.Fill(this.carDataSet.Producer);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.autoTableAdapter.Update(this.carDataSet.Auto);
        }

        private void loginBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(loginTextBox.Text))
            {
                errorProvider1.SetError(loginTextBox, "Не указано номер!");
            }
            else if (loginTextBox.Text.Length < 7)
            {
                errorProvider1.SetError(loginTextBox, "Номер неверный!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void загрузитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)autoBindingSource.Current;
            CarDataSet.AutoRow ur = (CarDataSet.AutoRow)(drw.Row);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(ofd.FileName);
                toolStripStatusLabel1.Text = "Фотография загружена успешно";
            }
        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DataRowView drw = (DataRowView)autoBindingSource.Current;
            CarDataSet.AutoRow ur = (CarDataSet.AutoRow)(drw.Row);
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (photoPictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    photoPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    toolStripStatusLabel1.Text = "Фотография успешно сохранена";
                }
            }
        }


        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyGrid1.Visible = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyGrid1.Visible = true;
        }



        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Перед началом печати переменные-счетчики
            // установить в начальные значения
            counter = 0;
                curPage = 1;
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RichTextBox richTextBox1 = new RichTextBox();
            int index = usersDataGridView.CurrentRow.Index;

            string phone = (string)usersDataGridView.Rows[index].Cells[0].Value;
            string name = (string)usersDataGridView.Rows[index].Cells[1].Value;
            string lastName = (string)usersDataGridView.Rows[index].Cells[2].Value;
            string marka = usersDataGridView.Rows[index].Cells[3].Value.ToString();

            richTextBox1.Text += $"Номер машины: {phone}\n" +
                $"Имя владельца: {name}\n" +
                $"Фамилия владельца: {lastName}\n" +
                $"Марка: {marka}";

            // Создать шрифт myFont
            Font myFont = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);

            string curLine; // текущая выводимая строка

            // Отступы внутри страницы
            float leftMargin = e.MarginBounds.Left; // отступы слева в документе
            float topMargin = e.MarginBounds.Top; // отступы сверху в документе
            float yPos = 0; // текущая позиция Y для вывода строки

            int nPages; // количество страниц
            int nLines; // максимально-возможное количество строк на странице
            int i; // номер текущей строки для вывода на странице

            // Вычислить максимально возможное количество строк на странице
            nLines = (int)(e.MarginBounds.Height / myFont.GetHeight(e.Graphics));

            // Вычислить количество страниц для печати
            nPages = (richTextBox1.Lines.Length - 1) / nLines + 1;

            // Цикл печати/вывода одной страницы
            i = 0;
            while ((i < nLines) && (counter < richTextBox1.Lines.Length))
            {
                // Взять строку для вывода из richTextBox1
                curLine = richTextBox1.Lines[counter];

                // Вычислить текущую позицию по оси Y
                yPos = topMargin + i * myFont.GetHeight(e.Graphics);

                // Вывести строку в документ
                e.Graphics.DrawString(curLine, myFont, Brushes.Blue,
                  leftMargin, yPos, new StringFormat());

                counter++;
                i++;
            }

            // Если весь текст не помещается на 1 страницу, то
            // нужно добавить дополнительную страницу для печати
            e.HasMorePages = false;

            if (curPage < nPages)
            {
                curPage++;
                e.HasMorePages = true;
            }
        }

        private void настройкаПечатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
                printPreviewDialog1.ShowDialog();
        }
    }
}
