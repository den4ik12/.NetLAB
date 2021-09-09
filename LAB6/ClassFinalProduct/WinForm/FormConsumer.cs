using System;
using ClassFinalProduct;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormConsumer : Form
    {
        private ClassFinalProduct.Сonsumer _consumer;
        public ClassFinalProduct.Сonsumer Сonsumer
        {
            get { return _consumer; }
            set
            {
                _consumer = value;

                input_name_customer.Text = _consumer._person.Name;
                Age_input.Value = _consumer._person.Age;
                inpute_lastName.Text = _consumer._person.Last_Name;
                phone_input.Text = _consumer._number_phone.ToString();
                adrr_input.Text = _consumer._address;
            }
        }
        public FormConsumer()
        {
            InitializeComponent();
        }

        private void save_customer_Click(object sender, EventArgs e)
        {
            try
            {
                _consumer._number_phone = Convert.ToInt32(phone_input.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception) {
                DialogResult = DialogResult.None;
                MessageBox.Show("Неверные данные");
            }
            _consumer._address = adrr_input.Text;
            _consumer._person = new User(input_name_customer.Text, inpute_lastName.Text, Convert.ToInt32(Age_input.Value));
        }

    }
}
