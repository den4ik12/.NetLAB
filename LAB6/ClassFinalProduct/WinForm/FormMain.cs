﻿using System;
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
                Update_deal_list(deal);
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
                Update_list_products(room);
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
                Update_list_consumers(consumer);
            }
        }

        private void Add_product_MenuItem_Click(object sender, EventArgs e)
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
        private void Change_product_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var product = listViewProduct.SelectedItems[0].Tag as Product;
                _formProduct.Product = product;
                if (_formProduct.ShowDialog() == DialogResult.OK)
                {
                    listViewProduct.SelectedItems[0].Text = _formProduct.Product.ToString();
                    var listViewItem = listViewProduct.SelectedItems[0];
                    listViewItem.Text = product.Title.ToString();
                    listViewItem.SubItems[1].Text = product.Wholesale_price.ToString();
                    listViewItem.SubItems[2].Text = product.TradePrice.ToString();
                    listViewItem.SubItems[3].Text = product.Description;
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
        private void Update_list_products(Product product)
        {
            ListViewItem lvi = new ListViewItem
            {
                Tag = product,
                Text = product.ToString()

            };
            lvi.SubItems.Add(product.TradePrice.ToString());
            lvi.SubItems.Add(product.Wholesale_price.ToString());
            lvi.SubItems.Add(product.Description.ToString());
            listViewProduct.Items.Add(lvi);

        }

        /// <summary>
        /// Метод автоматического добавления товаров, сделок, покупателей (тест)
        /// </summary>
        private void _Test_add_deal()
        {
            ;
        }
        /// <summary>
        /// Метод обработки кнопки добавления нового покупателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_consumer_menuItem_Click(object sender, EventArgs e)
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
        private void Change_consumer_menuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var сonsumer = listViewConsumer.SelectedItems[0].Tag as ClassFinalProduct.Сonsumer;
                _formConsumer.Сonsumer = сonsumer;
                if (_formConsumer.ShowDialog() == DialogResult.OK)
                {
                    listViewConsumer.SelectedItems[0].Text = _formConsumer.Сonsumer.Person.Name;
                    var listViewItem = listViewConsumer.SelectedItems[0];
                    listViewItem.Text = сonsumer.Person.Name;
                    listViewItem.SubItems[1].Text = сonsumer.Person.LastName;
                    listViewItem.SubItems[2].Text = сonsumer.NumberPhone.ToString();
                    listViewItem.SubItems[3].Text = сonsumer.Address;
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
        private void Update_list_consumers(Сonsumer consumer)
        {

            ListViewItem lvi = new ListViewItem

            {
                Tag = consumer,
                Text = consumer.Person.Name
            };
            lvi.SubItems.Add(consumer.Person.LastName);
            lvi.SubItems.Add(consumer.NumberPhone.ToString());
            lvi.SubItems.Add(consumer.Address);
            listViewConsumer.Items.Add(lvi);
        }

        private void Add_deal_menu_Click(object sender, EventArgs e)
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

        private void Change_deal_menu_Click(object sender, EventArgs e)
        {
            try
            {
                var deal = listViewDeal.SelectedItems[0].Tag as Deal;
                _formDeal.Deal = deal;
                if (_formDeal.ShowDialog() == DialogResult.OK)
                {
                    deal = _formDeal.Deal;
                    var listViewItem = listViewDeal.SelectedItems[0];
                    listViewItem.Text = deal.Productt.ToString();
                    listViewItem.SubItems[1].Text = deal.Count.ToString();
                    listViewItem.SubItems[2].Text = deal.Person.ToString();
                    listViewItem.SubItems[3].Text = deal.Wholesale.ToString();
                    listViewItem.SubItems[4].Text = deal.Time.ToShortDateString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с сделкой");
            }
        }

        private void Update_deal_list(Deal deal)
        {

            ListViewItem lvi = new ListViewItem
            {
                Tag = deal,
                Text = deal.Productt.ToString()
            };
            lvi.SubItems.Add(deal.Count.ToString());
            lvi.SubItems.Add(deal.Person.ToString());
            lvi.SubItems.Add(deal.Wholesale.ToString());
            lvi.SubItems.Add(deal.Time.ToString());
            listViewDeal.Items.Add(lvi);
        }

        private void ListViewConsumer_Remove(object sender, KeyEventArgs e)
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
        private void ListViewProduct_Remove(object sender, KeyEventArgs e)
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
