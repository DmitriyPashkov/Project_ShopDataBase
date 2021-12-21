using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class AddNamePriceForm : Form
    {
        private MainForm mainForm;
        public AddNamePriceForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonAddNamePrice_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(textBox2.Text, out int number)) && (textBox1.Text != ""))
            {
                if (mainForm.namePrice.Add(new Item<string, int>(textBox1.Text, Convert.ToInt32(textBox2.Text))))
                {
                    mainForm.RefreshPriceTable();
                    Notification NotForm = new Notification("Запись добавлена!");
                    NotForm.Show();                    
                }
                else
                {
                    Notification NotForm = new Notification("Введите уникальный ключ!");
                    NotForm.Show();
                }
            }
            else
            {
                Notification NotForm = new Notification("Некорректный ввод!");
                NotForm.Show();
            }
            Close();
        }
    }
}
