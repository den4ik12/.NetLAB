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
    /// <summary>
    /// Класс диалоговой формы создания/редактирования покупателя 
    /// </summary>
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
            if (_consumer.IsValid)
            {
                Text = "Изменить покупателя";
                inputNameNustomer.Text = _consumer.Person.Name;
                inpute_lastName.Text = _consumer.Person.LastName;
                phoneInput.Text = _consumer.NumberPhone.ToString();
                adrrInput.Text = _consumer.Address;
            }
            else
                Text = "Добавить покупателя";
        }

        private void save_customer_Click(object sender, EventArgs e)
        {
            try
            {
                _consumer.NumberPhone = Convert.ToInt32(phoneInput.Text);
                _consumer.Address = adrrInput.Text;
                _consumer.Person = new User(inputNameNustomer.Text, inpute_lastName.Text, Convert.ToInt32(ageInput.Value));
                if (!_consumer.IsValid)
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
