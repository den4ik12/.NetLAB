using Microsoft.Win32;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Data;
namespace LAB13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CarDataSet _carDataSet;
        private CarDataSetTableAdapters.AutoTableAdapter _autoDbDataSetUsersTableAdapter;
        private CarDataSetTableAdapters.ProducerTableAdapter _producerDbDataSetCommentsTableAdapter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            _carDataSet = (CarDataSet)FindResource("carDataSet");
            // Загрузить данные в таблицу Auto. Можно изменить этот код как требуется.
            _autoDbDataSetUsersTableAdapter = new CarDataSetTableAdapters.AutoTableAdapter();
            _autoDbDataSetUsersTableAdapter.Fill(_carDataSet.Auto);
            CollectionViewSource autoViewSource = (CollectionViewSource)FindResource("autoViewSource");
            autoViewSource.View.MoveCurrentToFirst();

            _producerDbDataSetCommentsTableAdapter = new CarDataSetTableAdapters.ProducerTableAdapter();
            _producerDbDataSetCommentsTableAdapter.Fill(_carDataSet.Producer);
            CollectionViewSource producerViewSource = (CollectionViewSource)FindResource("producerViewSource");
            producerViewSource.View.MoveCurrentToFirst();
        }

        private void saveAuto_Click(object sender, RoutedEventArgs e)
        {
            _autoDbDataSetUsersTableAdapter.Update(_carDataSet);
        }

        private void saveProducer_Click(object sender, RoutedEventArgs e)
        {
            _producerDbDataSetCommentsTableAdapter.Update(_carDataSet);
        }

        private void deleteAuto_Click(object sender, RoutedEventArgs e)
            {
                for (int i = 0; i < autoDataGrid.SelectedItems.Count; i++)
                {
                    var dataRowView = autoDataGrid.SelectedItems[i] as DataRowView;
                    if (dataRowView != null)
                    {
                        DataRow dataRow = dataRowView.Row;
                        dataRow.Delete();
                    }
                }
                _autoDbDataSetUsersTableAdapter.Update(_carDataSet.Auto);
            }

        private void deleteProducer_Click(object sender, RoutedEventArgs e)
        {
            {
                for (int i = 0; i < producerDataGrid.SelectedItems.Count; i++)
                {
                    var dataRowView = producerDataGrid.SelectedItems[i] as DataRowView;
                    if (dataRowView != null)
                    {
                        DataRow dataRow = dataRowView.Row;
                        dataRow.Delete();
                    }
                }
                _producerDbDataSetCommentsTableAdapter.Update(_carDataSet.Producer);
            }
        }

        private void ContextImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image files (*.jpg)|*.jpg|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (autoDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = autoDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as CarDataSet.AutoRow;
                        if (dataRow != null)
                        {
                            dataRow.Photo = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }
    }
}
