using System;
using System.Collections.Generic;
using ClassFinalProduct;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormDeal : Form
    {
        private Deal _deal;

        public Deal Deal
        {
            get { return _deal; }
            set
            {
                _deal = value;
                Set_deal_config();
            }
        }
        private readonly Company _company = Company.Instanse;
        public FormDeal()
        {
            InitializeComponent();
            _company.ConsumerAdded += _company_ConsumerAdded;
            _company.ConsumerRemoved += _company_ConsumerRemoved;
            _company.ProductAdded += _company_ProductAdded;
            _company.ProductRemoved += _company_ProductRemoved;
            Fill_comboBox(); //Заполнение списка товаров и покупателей
        }

        private void _company_ProductRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxProduct.Items.Count; i++)
            {
                var product = comboBoxProduct.Items[i] as Product;
                if (product?.ProductId == key)
                {
                    comboBoxProduct.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_ProductAdded(object sender, EventArgs e)
        {
            comboBoxProduct.Items.Add(sender);
        }

        private void _company_ConsumerRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxConsumer.Items.Count; i++)
            {
                var consumer = comboBoxConsumer.Items[i] as ClassFinalProduct.Сonsumer;
                if (consumer?.UserId == key)
                {
                    comboBoxConsumer.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_ConsumerAdded(object sender, EventArgs e)
        {
            comboBoxConsumer.Items.Add(sender);
        }

        private void Fill_comboBox()
        {
            foreach (var product in _company.Products)
                comboBoxProduct.Items.Add(product);

            foreach (var consumer in _company.Consumers)
                comboBoxConsumer.Items.Add(consumer);
        }
        private void Set_deal_config()
        {
            comboBoxProduct.SelectedItem = _deal.Productt;
            comboBoxConsumer.SelectedItem = _deal.Person;
            

            dateTimePickerDeal.Value = _deal.Time;
            checkBoxWholesale.Checked = _deal.Wholesale;
            if (!_deal.Wholesale){
                numericUpDownCountProduct.Minimum = 1;
            }
            numericUpDownCountProduct.Value = _deal.Count;
        }
        private void Button_save_deal_Click(object sender, EventArgs e)
        {
            _deal.Productt = comboBoxProduct.SelectedItem as Product;
            _deal.Person = comboBoxConsumer.SelectedItem as ClassFinalProduct.Сonsumer;
            _deal.Count = Convert.ToInt32(numericUpDownCountProduct.Value);
            _deal.Time = dateTimePickerDeal.Value;
            _deal.Wholesale = checkBoxWholesale.Checked;
            DialogResult = DialogResult.OK;

        }

        private void CheckBox_wholesale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWholesale.Checked)
                Set_checkbox(500, 10000);
            else
                Set_checkbox(1, 100);
        }
        private void Set_checkbox(int min, int max) 
            {
                numericUpDownCountProduct.Minimum = min;
                numericUpDownCountProduct.Maximum = max;
            }

    }
}
