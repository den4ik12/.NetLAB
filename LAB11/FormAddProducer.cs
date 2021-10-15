using System;
using System.Windows.Forms;
using LAB11.Models;

namespace LAB11
{
    public partial class FormAddProducer : Form
    {
        private Producer _producer;

        public Producer Producer
        {
            get
            {
                return _producer;
            }
            set
            {
                _producer = value;
                textBoxTitleProducer.Text = _producer.Title;
                textBoxCountryProducer.Text = _producer.Country;
            }
        }
        public FormAddProducer()
        {
            InitializeComponent();
        }

        private void buttonAddProducer_Click(object sender, EventArgs e)
        {
            Producer.Country = textBoxCountryProducer.Text;
            Producer.Title = textBoxTitleProducer.Text;
        }
    }
}
