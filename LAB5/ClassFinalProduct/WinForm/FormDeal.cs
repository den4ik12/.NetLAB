using System;
using System.Collections.Generic;
using ClassFinalProduct;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormDeal : Form
    {
        private Deal _deal;
        public FormDeal(Deal deal)
        {
            InitializeComponent();
            _deal = deal;
            fill_comboBox(); //Заполнение списка товаров и покупателей
            if (_deal.isValid)
            {
                set_deal_config();
                Text = "Редактировать товар";
            }
            else
            {
                Text = "Добавить товар";
            }
            
        }

        private void fill_comboBox()
        {
            foreach (var product in Company.Products.Values)
                comboBox_product.Items.Add(product);

            foreach (var consumer in Company.Consumers.Values)
                comboBox_consumer.Items.Add(consumer);
        }
        private void set_deal_config()
        {
            comboBox_product.SelectedItem = _deal._product;
            comboBox_consumer.SelectedItem = _deal._person;
            numericUpDown_count_product.Value = _deal._count;
            dateTimePicker_deal.Value = _deal._time;
            checkBox_wholesale.Checked = _deal._wholesale;
        }
        private void button_save_deal_Click(object sender, EventArgs e)
        {
            _deal._product = comboBox_product.SelectedItem as Product;
            _deal._person = comboBox_consumer.SelectedItem as ClassFinalProduct.Сonsumer;
            _deal._count = Convert.ToInt32(numericUpDown_count_product.Value);
            _deal._time = dateTimePicker_deal.Value;
            _deal._wholesale = checkBox_wholesale.Checked;
            if (_deal.isValid)
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
