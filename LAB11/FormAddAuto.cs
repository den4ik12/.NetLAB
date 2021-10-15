using System;
using System.Windows.Forms;
using LAB11.Models;

namespace LAB11
{
    public partial class FormAddAuto : Form
    {
        private Car _car;
        public Car Car 
        {
            get
            {
                return _car;
            }
            set
            {
                _car = value;
                textBoxNumber.Text = _car.Number;
                textBoxProducer.Text = _car.ProducerId.ToString();
            }
        }
        public FormAddAuto()
        {
            InitializeComponent();
        }

        private void buttonSendCar_Click(object sender, EventArgs e)
        {
            Car.Number = textBoxNumber.Text;
            Car.ProducerId = Convert.ToInt32(textBoxProducer.Text);
        }
    }
}
