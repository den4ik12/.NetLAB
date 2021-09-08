using System;
using System.Collections.Generic;
using ClassFinalProduct;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //test_add_deal();
            update_list_products();
            update_list_consumers();
            update_deal_list();

        }

        /// <summary>
        /// Метод обработки кнопки добавления товара
        /// Создает объект товара и диалоговую форму добавления товара
        /// В случае корректной работы диалоговой формы добавляет объект "товара" в список "товаров"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_product_MenuItem_Click(object sender, EventArgs e)
        {
            Product pr1 = new Product();
            FormProduct f = new FormProduct(pr1);
            switch (f.ShowDialog())
            {
                case DialogResult.OK:
                    Company.Products.Add(pr1.ProductId, pr1);
                    update_list_products();
                    break;
                default:
                    break;
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
            if (Company.Products.Count == 0)
                MessageBox.Show("Не найдено товаров");
            else
            {
                Product temp_product = listViewProduct.SelectedItems[0].Tag as Product;
                FormProduct f = new FormProduct(temp_product);
                switch (f.ShowDialog())
                {
                    case DialogResult.OK:
                        update_list_products();
                        break;
                    default:
                        break;

                }
            }
        }
        
        /// <summary>
        /// Метод обновления списка товаров
        /// </summary>
        private void update_list_products()
        {
            listViewProduct.Items.Clear();
            foreach (var product in Company.Products.Values)
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
        }

        /// <summary>
        /// Метод автоматического добавления товаров, сделок, покупателей (тест)
        /// </summary>
        private void test_add_deal()
        {
            Product pr2 = new Product(title: "iPhone 11", wholosale_price: 124124, trade_price: 324234, description: "Крутой телефон");
            Product pr1 = new Product(title: "Tesla", wholosale_price: 124124, trade_price: 324234, description: "car");
            User user = new User("Denis", "Volodin", 20);
            User user2 = new User("Julia", "Sim", 20);
            Сonsumer c2 = new Сonsumer(5, user, "Moscow");
            Сonsumer c1 = new Сonsumer(5, user2, "Bryansk");
            Company.Deals.Add(new Deal(DateTime.Now, pr1, 508, c2, true));
            Company.Products.Add(pr1.ProductId, pr1);
            Company.Products.Add(pr2.ProductId, pr2);
            Company.Consumers.Add(c2.UserId,c2);
            Company.Consumers.Add(c1.UserId,c1);
        }
       /// <summary>
       /// Метод обработки кнопки добавления нового покупателя
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void add_consumer_menuItem_Click(object sender, EventArgs e)
        {
            Сonsumer c = new Сonsumer();
            FormConsumer f = new FormConsumer(c);
            switch (f.ShowDialog())
                {
                    case DialogResult.OK:
                        Company.Consumers.Add(c.UserId,c);
                        update_list_consumers();
                        break;
                    default:
                        break;

                }

        }
        /// <summary>
        /// Метод обработки кнопки редактирования выбранного в ListViev покупателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_consumer_menuItem_Click(object sender, EventArgs e)
        {
            if (Company.Consumers.Count == 0)
                {
                    MessageBox.Show("Не найдено покупателей");
                }
            else
                {
                    ClassFinalProduct.Сonsumer c = listConsumer.SelectedItems[0].Tag as Сonsumer; // возвращает объект выбранного в списке покупателя
                    FormConsumer f = new FormConsumer(c);
                    switch (f.ShowDialog())
                    {
                        case DialogResult.OK:
                            update_list_consumers();
                            break;
                        default:
                            break;

                    }
                }
        }
        /// <summary>
        /// Метод обновления списка покупателей
        /// </summary>
        private void update_list_consumers()
        {
            listConsumer.Items.Clear();
            foreach (var consumer in Company.Consumers.Values)
            {
                ListViewItem lvi = new ListViewItem

                {
                    Tag = consumer,
                    Text = consumer._person.Name
                };
                lvi.SubItems.Add(consumer._person.Last_Name);
                lvi.SubItems.Add(consumer._number_phone.ToString());
                lvi.SubItems.Add(consumer._address);
                listConsumer.Items.Add(lvi);

            }
        }

        private void add_deal_menu_Click(object sender, EventArgs e)
        {
            if (Company.Products.Count > 0 && Company.Consumers.Count > 0)
            {
                Deal d = new Deal();
                FormDeal f = new FormDeal(d);
                switch (f.ShowDialog())
                {
                    case DialogResult.OK:
                        Company.Deals.Add(d);
                        update_deal_list();
                        break;
                }
            }
            else
                MessageBox.Show("Отсутствуют товары или покупатели");
        }

        private void change_deal_menu_Click(object sender, EventArgs e)
        {
             if (Company.Deals.Count != 0)
             {
                Deal d = listViewDeal.SelectedItems[0].Tag as Deal;
                FormDeal f = new FormDeal(d);
                switch (f.ShowDialog()) 
                {
                    case DialogResult.OK:
                        update_deal_list();
                        break;
                    default:
                        break;
                }
             }
             else 
                  MessageBox.Show("Сделок нет!");
        }

        private void update_deal_list() 
        {
            listViewDeal.Items.Clear();
            foreach (var deal in Company.Deals)
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
        }
    }
}
