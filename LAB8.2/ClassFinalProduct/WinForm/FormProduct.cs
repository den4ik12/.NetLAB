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
                textBoxTitleProduct.Text = _product.Title;
                textBoxTradePrice.Text = _product.TradePrice.ToString();
                textBoxWhosalePrice.Text = _product.Wholesale_price.ToString();
                textBoxDescriptionProduct.Text = _product.Description;
            }
        }
        public FormProduct()
        {
            InitializeComponent();
        }

        private void Save_product_Click(object sender, EventArgs e)
        {
          _product.Title = textBoxTitleProduct.Text;
            try
            {
                _product.TradePrice = Convert.ToDecimal(textBoxTradePrice.Text);
                _product.Wholesale_price = Convert.ToDecimal(textBoxWhosalePrice.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные");
                DialogResult = DialogResult.None;
            }
          _product.Description = textBoxDescriptionProduct.Text;
        }
    }
}