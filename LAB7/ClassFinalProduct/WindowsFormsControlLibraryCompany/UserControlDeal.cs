using System;
using System.Windows.Forms;
using System.Drawing;
using ClassFinalProduct;

namespace WindowsFormsControlLibraryCompany
{
    public partial class UserControlDeal : UserControl
    {


        private readonly Company _company = Company.Instanse;
        public Deal Deal { get; }

        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControlDeal)) continue;
                            var userControlSettlement = control as UserControlDeal;
                            if (userControlSettlement != this)
                            {
                                userControlSettlement.Selected = false;
                            }
                        }
                    }
                    _selected = value;
                    Refresh();
                }
            }
        }
           public UserControlDeal(Deal deal)
        {
            InitializeComponent();
            Deal = deal;
        }

        private void UserControlDeal_Paint(object sender, PaintEventArgs e)
        {
            textBoxProduct.Text = $"{Deal.Productt}";
            textBoxConsumer.Text = Deal.Person.ToString();
            textBoxDateDeal.Text = $"{Deal.Time:dd MMMM yyyy}";
            textBoxCount.Text = $"{Deal.Count}";
            if (!Deal.Wholesale)
            {
                textBoxCount.BackColor = Color.Green;
            }
            else
            {
                textBoxCount.BackColor = Deal.Count > 1000 ? Color.Red : Color.Yellow;
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;

        }

        private void UserControlDeal_Click(object sender, EventArgs e)
        {
            Selected = true;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _company.RemoveDeal(Deal);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о сделке");
            }
        }
    }
}
