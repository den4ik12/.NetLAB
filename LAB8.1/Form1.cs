using System;
using System.IO;
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
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            file_path = openFileDialog.FileName;
            Wather = new FileSystemWatcher();
            contentRichTextBox.Text = File.ReadAllText(file_path);
           
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            file_path = saveFileDialog.FileName;
            wather.Changed -= WatherChanged;
            contentRichTextBox.Visible = false;
            File.WriteAllText(file_path, contentRichTextBox.Text);
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
                File.WriteAllText(file_path, contentRichTextBox.Text);
        }
    }
}
