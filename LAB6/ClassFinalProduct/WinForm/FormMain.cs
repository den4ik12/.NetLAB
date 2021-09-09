using System;
using System.Collections.Generic;
using ClassFinalProduct;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormMain : Form
    {
        private readonly Company _company = Company.Instanse;
        readonly FormProduct _formProduct = new FormProduct();
        readonly FormConsumer _formConsumer = new FormConsumer();
        readonly FormDeal _formDeal = new FormDeal();
        public FormMain()
        {
            InitializeComponent();
            _company.ConsumerAdded += _company_ConsumerAdded;
            _company.ConsumerRemoved += _company_ConsumerRemoved;
            _company.ProductAdded += _company_ProductAdded;
            _company.ProductRemoved += _company_ProductRemoved;
            _company.DealAdded += _company_DealAdded;
            _company.DealRemoved += _company_DealRemoved;
            //test_add_deal();
            //update_list_products();
            //update_list_consumers();
            //update_deal_list();

        }

        private void _company_DealRemoved(object sender, EventArgs e)
        {
            var deal = sender as Deal;
            for (int i = 0; i < listViewDeal.Items.Count; i++)
            {
                if ((Deal)listViewDeal.Items[i].Tag == deal)
                {
                    listViewDeal.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_DealAdded(object sender, EventArgs e)
        {
            var deal = sender as Deal;
            if (deal != null)
            {
                update_deal_list(deal);
            }
        }

        private void _company_ProductRemoved(object sender, EventArgs e)
        {
            var productNumber = (int)sender;
            for (int i = 0; i < listViewProduct.Items.Count; i++)
            {
                if (((Product)listViewProduct.Items[i].Tag).ProductId == productNumber)
                {
                    listViewProduct.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_ProductAdded(object sender, EventArgs e)
        {
            var room = sender as Product;
            if (room != null)
            {
                update_list_products(room);
            }
        }
        private void _company_ConsumerRemoved(object sender, EventArgs e)
        {
            var userId = (int)sender;
            for (int i = 0; i < listViewConsumer.Items.Count; i++)
            {
                if (((ClassFinalProduct.Сonsumer)listViewConsumer.Items[i].Tag).UserId == userId)
                {
                    listViewConsumer.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _company_ConsumerAdded(object sender, EventArgs e)
        {
            var consumer = sender as ClassFinalProduct.Сonsumer;
            if (consumer != null)
            {
                update_list_consumers(consumer);
            }
        }

        private void add_product_MenuItem_Click(object sender, EventArgs e)
        {
            var product = new Product();
            _formProduct.Product = product;
            if (_formProduct.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _company.AddProduct(product);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        /// <summary>
        /// Метод обработки кнопки редактирования товара
        /// Если список товаров пусть выдаёт соответствующее сообщение
        /// Если товары найдены, то создает форму редактирования товара и создает копию текущего товара
        /// На вход форме подается копия объекта редактируемого товара, если диалоговое окно успешно отработало
        /// то товар из списка заменяется на отредактированную копию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_product_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var product = listViewProduct.SelectedItems[0].Tag as Product;
                _formProduct.Product = product;
                if (_formProduct.ShowDialog() == DialogResult.OK)
                {
                    listViewProduct.SelectedItems[0].Text = _formProduct.Product.ToString();
                    var listViewItem = listViewProduct.SelectedItems[0];
                    listViewItem.Text = product._title.ToString();
                    listViewItem.SubItems[1].Text = product.Wholesale_price.ToString();
                    listViewItem.SubItems[2].Text = product.Trade_price.ToString();
                    listViewItem.SubItems[3].Text = product._description;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с продуктом");
            }
        }

        /// <summary>
        /// Метод обновления списка товаров
        /// </summary>
        private void update_list_products(Product product)
        {
            ListViewItem lvi = new ListViewItem
            {
                Tag = product,
                Text = product.ToString()

            };
            lvi.SubItems.Add(product.Trade_price.ToString());
            lvi.SubItems.Add(product.Wholesale_price.ToString());
            lvi.SubItems.Add(product._description.ToString());
            listViewProduct.Items.Add(lvi);

        }

        /// <summary>
        /// Метод автоматического добавления товаров, сделок, покупателей (тест)
        /// </summary>
        private void test_add_deal()
        {
            ;
        }
        /// <summary>
        /// Метод обработки кнопки добавления нового покупателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_consumer_menuItem_Click(object sender, EventArgs e)
        {
            var consumer = new ClassFinalProduct.Сonsumer();
            _formConsumer.Сonsumer = consumer;
            if (_formConsumer.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _company.AddConsumer(consumer);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }
        /// <summary>
        /// Метод обработки кнопки редактирования выбранного в ListViev покупателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_consumer_menuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var сonsumer = listViewConsumer.SelectedItems[0].Tag as ClassFinalProduct.Сonsumer;
                _formConsumer.Сonsumer = сonsumer;
                if (_formConsumer.ShowDialog() == DialogResult.OK)
                {
                    listViewConsumer.SelectedItems[0].Text = _formConsumer.Сonsumer._person.Name;
                    var listViewItem = listViewConsumer.SelectedItems[0];
                    listViewItem.Text = сonsumer._person.Name;
                    listViewItem.SubItems[1].Text = сonsumer._person.Last_Name;
                    listViewItem.SubItems[2].Text = сonsumer._number_phone.ToString();
                    listViewItem.SubItems[3].Text = сonsumer._address;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с номером");
            }
        }
        /// <summary>
        /// Метод обновления списка покупателей
        /// </summary>
        private void update_list_consumers(Сonsumer consumer)
        {

            ListViewItem lvi = new ListViewItem

            {
                Tag = consumer,
                Text = consumer._person.Name
            };
            lvi.SubItems.Add(consumer._person.Last_Name);
            lvi.SubItems.Add(consumer._number_phone.ToString());
            lvi.SubItems.Add(consumer._address);
            listViewConsumer.Items.Add(lvi);
        }

        private void add_deal_menu_Click(object sender, EventArgs e)
        {
            var deal = new Deal();
            _formDeal.Deal = deal;
            if (_formDeal.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _company.AddDeal(deal);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void change_deal_menu_Click(object sender, EventArgs e)
        {
            try
            {
                var deal = listViewDeal.SelectedItems[0].Tag as Deal;
                _formDeal.Deal = deal;
                if (_formDeal.ShowDialog() == DialogResult.OK)
                {
                    deal = _formDeal.Deal;
                    var listViewItem = listViewDeal.SelectedItems[0];
                    listViewItem.Text = deal._product.ToString();
                    listViewItem.SubItems[1].Text = deal._count.ToString();
                    listViewItem.SubItems[2].Text = deal._person.ToString();
                    listViewItem.SubItems[3].Text = deal._wholesale.ToString();
                    listViewItem.SubItems[4].Text = deal._time.ToShortDateString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с сделкой");
            }
        }

        private void update_deal_list(Deal deal)
        {

            ListViewItem lvi = new ListViewItem
            {
                Tag = deal,
                Text = deal._product.ToString()
            };
            lvi.SubItems.Add(deal._count.ToString());
            lvi.SubItems.Add(deal._person.ToString());
            lvi.SubItems.Add(deal._wholesale.ToString());
            lvi.SubItems.Add(deal._time.ToString());
            listViewDeal.Items.Add(lvi);
        }

        private void listViewDeal_Remove(object sender, KeyEventArgs e)
        {

        }
        private void listViewConsumer_Remove(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var consumer = listViewConsumer.SelectedItems[0].Tag as ClassFinalProduct.Сonsumer;
                    if (consumer != null)
                    {
                        _company.RemoveConsumer(consumer.UserId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с покупателем");
                }
            }

        }
        private void listViewProduct_Remove(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var product = listViewProduct.SelectedItems[0].Tag as Product;
                    if (product != null)
                    {
                        _company.RemoveProduct(product.ProductId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с товаром");
                }
            }
        }
    }
}
