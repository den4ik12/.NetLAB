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
                set_deal_config();
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
            fill_comboBox(); //Заполнение списка товаров и покупателей
        }


        private void _company_ProductRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBox_product.Items.Count; i++)
            {
                var product = comboBox_product.Items[i] as Product;
                if (product?.ProductId == key)
                {
                    comboBox_product.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_ProductAdded(object sender, EventArgs e)
        {
            comboBox_product.Items.Add(sender);
        }

        private void _company_ConsumerRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBox_consumer.Items.Count; i++)
            {
                var consumer = comboBox_consumer.Items[i] as ClassFinalProduct.Сonsumer;
                if (consumer?.UserId == key)
                {
                    comboBox_consumer.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_ConsumerAdded(object sender, EventArgs e)
        {
            comboBox_consumer.Items.Add(sender);
        }

        private void fill_comboBox()
        {
            foreach (var product in _company.Products)
                comboBox_product.Items.Add(product);

            foreach (var consumer in _company.Consumers)
                comboBox_consumer.Items.Add(consumer);
        }
        private void set_deal_config()
        {
            comboBox_product.SelectedItem = _deal._product;
            comboBox_consumer.SelectedItem = _deal._person;
            

            dateTimePicker_deal.Value = _deal._time;
            checkBox_wholesale.Checked = _deal._wholesale;
            if (!_deal._wholesale){
                numericUpDown_count_product.Minimum = 1;
            }
            numericUpDown_count_product.Value = _deal._count;
        }
        private void button_save_deal_Click(object sender, EventArgs e)
        {
            _deal._product = comboBox_product.SelectedItem as Product;
            _deal._person = comboBox_consumer.SelectedItem as ClassFinalProduct.Сonsumer;
            _deal._count = Convert.ToInt32(numericUpDown_count_product.Value);
            _deal._time = dateTimePicker_deal.Value;
            _deal._wholesale = checkBox_wholesale.Checked;
            DialogResult = DialogResult.OK;

        }

        private void checkBox_wholesale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_wholesale.Checked)
                set_checkbox(500, 10000);
            else
                set_checkbox(1, 100);
        }
        private void set_checkbox(int min, int max) 
            {
                numericUpDown_count_product.Minimum = min;
                numericUpDown_count_product.Maximum = max;
            }

    }
}
