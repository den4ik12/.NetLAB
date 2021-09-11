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

                textBoxNameCustomer.Text = _consumer.Person.Name;
                numericUpDownAge.Value = _consumer.Person.Age;
                textBoxLastName.Text = _consumer.Person.LastName;
                textBoxPhone.Text = _consumer.NumberPhone.ToString();
                textBoxAdrrInput.Text = _consumer.Address;
            }
        }
        public FormConsumer()
        {
            InitializeComponent();
        }

        private void Save_customer_Click(object sender, EventArgs e)
        {
            try
            {
                _consumer.NumberPhone = Convert.ToInt32(textBoxPhone.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception) {
                DialogResult = DialogResult.None;
                MessageBox.Show("Неверные данные");
            }
            _consumer.Address = textBoxAdrrInput.Text;
            _consumer.Person = new User(textBoxNameCustomer.Text, textBoxLastName.Text, Convert.ToInt32(numericUpDownAge.Value));
        }

    }
}
