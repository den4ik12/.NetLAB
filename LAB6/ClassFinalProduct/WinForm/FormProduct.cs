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
    public partial class FormProduct : Form
    {
        private Product _product;
        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;
                textBox_title_product.Text = _product._title;
                textBox_trade_price.Text = _product.Trade_price.ToString();
                textBox_whosale_price.Text = _product.Wholesale_price.ToString();
                description_product.Text = _product._description;
            }
        }
        public FormProduct()
        {
            InitializeComponent();
        }

        private void save_product_Click(object sender, EventArgs e)
        {
          _product._title = textBox_title_product.Text;
            try
            {
                _product.Trade_price = Convert.ToDecimal(textBox_trade_price.Text);
                _product.Wholesale_price = Convert.ToDecimal(textBox_whosale_price.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception  exp)
            {
                MessageBox.Show("Неверные данные");
                DialogResult = DialogResult.None;
            }
          _product._description = description_product.Text;
        }
    }
}