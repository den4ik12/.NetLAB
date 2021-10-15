using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using LAB11.Models;

namespace LAB11
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new SqlConnection(
                "Data Source=localhost;Initial Catalog=Car;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }
        private void toolStripButtonLoadCars_Click(object sender, EventArgs e)
        {
            var cars = Car.List(_connection);
            listViewCars.Items.Clear();
            for (int i = 0; i < cars.Count; i++)
            {
                var car = cars[i];
                var listListViewItem = listViewCars.Items.Add(car.AutoId.ToString());
                listListViewItem.Tag = car;
                listListViewItem.SubItems.Add(car.Number);
                listListViewItem.SubItems.Add(car.ProducerId.ToString());
            }
        }

        private void toolStripButtonAddCar_Click(object sender, EventArgs e)
        {
            FormAddAuto f = new FormAddAuto
            {
                Car = new Car()
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                Car.Insert(_connection, f.Car);
            }
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            FormAddAuto f = new FormAddAuto
            {
                Car = listViewCars.SelectedItems[0].Tag as Car
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                Car.Update(_connection, f.Car);
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Car car = listViewCars.SelectedItems[0].Tag as Car;
            Car.Delete(_connection, car.AutoId);
        }

        private void toolStripButtonLoadProducers_Click(object sender, EventArgs e)
        {
            var producers = Producer.List(_connection);
            listViewProducers.Items.Clear();
            for (int i = 0; i < producers.Count; i++)
            {
                var producer = producers[i];
                var listListViewItem = listViewProducers.Items.Add(producer.ProducerId.ToString());
                listListViewItem.Tag = producer;
                listListViewItem.SubItems.Add(producer.Title);
                listListViewItem.SubItems.Add(producer.Country);
            }
        }

        private void toolStripButtonAddProducer_Click(object sender, EventArgs e)
        {
            FormAddProducer f = new FormAddProducer
            {
                Producer = new Producer()
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                Producer.Insert(_connection, f.Producer);
            }
        }

        private void toolStripButtonUpdateProducer_Click(object sender, EventArgs e)
        {
            FormAddProducer f = new FormAddProducer
            {
                Producer = listViewProducers.SelectedItems[0].Tag as Producer
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                Producer.Update(_connection, f.Producer);
            }
        }

        private void toolStripButtonRemoveProducer_Click(object sender, EventArgs e)
        {
            Producer.Delete(_connection, ((Producer)listViewProducers.SelectedItems[0].Tag).ProducerId);
        }
    }
}
