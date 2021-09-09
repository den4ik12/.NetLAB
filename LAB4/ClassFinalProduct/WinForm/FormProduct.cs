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
            if (!_product.IsValid)
            {
                h1TitleFormProduct.Text = "Добавить товар";
                Text = "Добавить товар";
            }
            else
            {
                Text = "Редактировать товар";
                h1TitleFormProduct.Text = "Редактировать товар";
                textBoxTitleProduct.Text = _product.Title;
                textBoxTradePrice.Text = _product.TradePrice.ToString();
                textBoxWhosalePrice.Text = _product.WholesaPrice.ToString();
                descriptionProduct.Text = _product.Description;
            }
        }

        private void save_product_Click(object sender, EventArgs e)
        {
            try
            {
                _product.Title = textBoxTitleProduct.Text;
                _product.TradePrice = Convert.ToDecimal(textBoxTradePrice.Text);
                _product.WholesaPrice = Convert.ToDecimal(textBoxWhosalePrice.Text);
                _product.Description = descriptionProduct.Text;
                if (!_product.IsValid)
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