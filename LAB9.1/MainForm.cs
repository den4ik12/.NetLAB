using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LAB8._1

{
    public partial class MainForm : Form
    {
        private string file_path;
        private FileSystemWatcher wather;
        private FileSystemWatcher Wather
        {
            set
            {
                wather = new FileSystemWatcher(Path.GetDirectoryName(file_path))
                {
                    NotifyFilter = NotifyFilters.LastWrite
                };
                wather.Changed += WatherChanged;
                wather.Filter = Path.GetFileName(file_path);
                wather.IncludeSubdirectories = true;
                wather.EnableRaisingEvents = true;
                contentRichTextBox.Visible = true;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void WatherChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
                return;
            try
            {
                string text = File.ReadAllText(file_path);
                contentRichTextBox.Invoke(new Action(() => contentRichTextBox.Text = text));
            }
            catch (IOException)
            {

            }
    
        }
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.DefaultExt = ".txt";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            file_path = openFileDialog.FileName;
            Wather = new FileSystemWatcher();
            Encoding encod_type = EncodInput();
            contentRichTextBox.Text = File.ReadAllText(file_path, encod_type);
           
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = ".txt";
            Encoding encod_type = EncodInput();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            file_path = saveFileDialog.FileName;
            wather.Changed -= WatherChanged;
            contentRichTextBox.Visible = false;
            File.WriteAllText(file_path, contentRichTextBox.Text,encod_type);
            MessageBox.Show("Файл сохранен");
        }

        private void ContentRichTextBox_TextChanged(object sender, EventArgs e)
        {
            saveFileToolStripMenuItem.Enabled = true;
        }

        private void SaveChanged(object sender, EventArgs e)
        {
            saveFileToolStripMenuItem.Enabled = true;
        }

        private void SaveChangedBtn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                Encoding encod_type = EncodInput();
                File.WriteAllText(file_path, contentRichTextBox.Text,encod_type);
            }
            if (e.KeyCode == Keys.P && e.Control)
            {
                Encoding encod_type = EncodInput();
                contentRichTextBox.Text = contentRichTextBox.Text = File.ReadAllText(file_path, encod_type);
            }
        }

        private string ChangeEncoding(string text, Encoding curE, Encoding nextE)
        {
            byte[] lastBytes = curE.GetBytes(text);
            byte[] nextBytes = Encoding.Convert(curE, nextE, lastBytes);
            return nextE.GetString(nextBytes);
        }

        private Encoding EncodInput()
        {
            int code = 0;
            Encoding encoding_type = Encoding.UTF8;
            EncodingForm formEnc = new EncodingForm();
            if (formEnc.ShowDialog() == DialogResult.OK)
                code = formEnc.comboBoxEncoding.SelectedIndex;
            switch (code)
            {
                case 0:
                    encoding_type = Encoding.UTF8;
                    break;
                case 1:
                    encoding_type = Encoding.Unicode;
                    break;
                case 2:
                    encoding_type = Encoding.ASCII;
                    break;
                case 3:
                    encoding_type = Encoding.GetEncoding("windows-1251");
                    break;
                case 4:
                    encoding_type = Encoding.GetEncoding("IBM437");
                    break;
                case 5:
                    encoding_type = Encoding.GetEncoding("macintosh");
                    break;
                case 6:
                    encoding_type = Encoding.GetEncoding("utf-7");
                    break;
                case 7:
                    encoding_type = Encoding.GetEncoding("koi8-u");
                    break;
            }
            return encoding_type;
        }
    }
}
