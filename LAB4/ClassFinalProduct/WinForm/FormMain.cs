using System;
using System.Collections.Generic;
using ClassFinalProduct;
using System.Windows.Forms;

namespace WinForm
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class FormMain : Form
    {
        private Product _product = new Product(); // поле хранящее продукт
        private Сonsumer _consumer = new Сonsumer(); // поле хранящее покупателя
        public FormMain()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Метод обработки кнопки добавления товара
        /// Создает объект товара и диалоговую форму добавления товара
        /// В случае корректной работы диалоговой формы сохраняет объект
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
                    _product = pr1;
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
        /// то товар заменяется на отредактированную копию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_product_MenuItem_Click(object sender, EventArgs e)
        {
            if (_product == null)
                MessageBox.Show("Не найдено товаров");
            else
            {
                Product temp_product = _product;
                FormProduct f = new FormProduct(temp_product);
                switch (f.ShowDialog())
                {
                    case DialogResult.OK:
                        _product = temp_product;
                        break;
                    default:
                        break;

                }
            }
        }
        /// <summary>
        /// Метод обработки кнопки добавления покупателя
        /// Создает временный объект покупателя, передает его в форму
        /// В случае корректной работы диалоговой формы сохраняет временный объект
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
                    _consumer = c;
                    break;
                default:
                    break;

            }


        }
        /// <summary>
        /// Метод обработки кнопки изменения покупателя
        /// Создает временный объект покупателя и передает его в конструктор формы
        /// В случае корректной работы диалоговой формы временный сохраняет объект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_consumer_menuItem_Click(object sender, EventArgs e)
        {
            if (_consumer == null)
            {
                MessageBox.Show("Не найдено покупателей");
            }
            else
            {
                ClassFinalProduct.Сonsumer c = _consumer;
                FormConsumer f = new FormConsumer(c);
                switch (f.ShowDialog())
                {
                    case DialogResult.OK:
                        _consumer = c;
                        break;
                    default:
                        break;

                }
            }
        }
        /// <summary>
        /// Обработки кнопки выхода 
        /// Закрывает форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
