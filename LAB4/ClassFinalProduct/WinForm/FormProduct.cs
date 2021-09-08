using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassFinalProduct;

namespace WinForm
{
    /// <summary>
    /// Класс диалоговой формы товаров
    /// </summary>
    public partial class FormProduct : Form
    {
        private Product _product;
        public FormProduct()
        {
            InitializeComponent();
        }
        public FormProduct(Product product)
        {
            InitializeComponent();
            _product = product;
            if (!_product.isValid)
            {
                h1_title_form_product.Text = "Добавить товар";
                Text = "Добавить товар";
            }
            else
            {
                Text = "Редактировать товар";
                h1_title_form_product.Text = "Редактировать товар";
                textBox_title_product.Text = _product._title;
                textBox_trade_price.Text = _product.Trade_price.ToString();
                textBox_whosale_price.Text = _product.Wholesale_price.ToString();
                description_product.Text = _product._description;
            }
        }

        private void save_product_Click(object sender, EventArgs e)
        {
            try
            {
                _product._title = textBox_title_product.Text;
                _product.Trade_price = Convert.ToDecimal(textBox_trade_price.Text);
                _product.Wholesale_price = Convert.ToDecimal(textBox_whosale_price.Text);
                _product._description = description_product.Text;
                if (!_product.isValid)
                {
                    MessageBox.Show("Неверный параметр");
                    DialogResult = DialogResult.None;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверные значения");
                DialogResult = DialogResult.None;
            }
        }
    }
}