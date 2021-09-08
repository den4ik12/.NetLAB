using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassFinalProduct;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormConsumer : Form
    {
        private ClassFinalProduct.Сonsumer _consumer;
        public FormConsumer()
        {
            InitializeComponent();
        }

        public FormConsumer(ClassFinalProduct.Сonsumer сonsumer)
        {
            InitializeComponent();
            _consumer = сonsumer;
            if (_consumer.isValid)
            {
                Text = "Изменить покупателя";
                input_name_customer.Text = _consumer._person.Name;
                Age_input.Value = _consumer._person.Age;
                inpute_lastName.Text = _consumer._person.Last_Name;
                phone_input.Text = _consumer._number_phone.ToString();
                adrr_input.Text = _consumer._address;
            }
            else
                Text = "Добавить покупателя";
        }

        private void save_customer_Click(object sender, EventArgs e)
        {
            try
            {
                _consumer._number_phone = Convert.ToInt32(phone_input.Text);
                _consumer._address = adrr_input.Text;
                _consumer._person = new User(input_name_customer.Text, inpute_lastName.Text, Convert.ToInt32(Age_input.Value));
                if (!_consumer.isValid)
                {
                    DialogResult = DialogResult.None;
                    MessageBox.Show("Неверные данные");
                }
            }
            catch (System.FormatException)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Неверные данные");
            }
        
        }

    }
}
