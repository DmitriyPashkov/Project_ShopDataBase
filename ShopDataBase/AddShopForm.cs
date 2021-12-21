using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class AddShopForm : Form
    {
        private MainForm mainForm;
        public AddShopForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (mainForm.dictShop.Search(textBox1.Text, textBox2.Text) == null)
            {
                mainForm.dictShop.Add(new Item<string, string>(textBox1.Text, textBox2.Text));
                mainForm.RefreshShopTable();
                Notification NotForm = new Notification("Запись добавлена!");
                NotForm.Show();
            }
            else
            {
                Notification NotForm = new Notification("Введите уникальный ключ!");
                NotForm.Show();
            }
            Close();
        }
    }
}