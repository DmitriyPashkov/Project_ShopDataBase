using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class AddGeneral : Form
    {
        private MainForm mainForm;
        public AddGeneral(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var ShopItem = mainForm.dictShop.Search(textBox1.Text, textBox2.Text);
            var PriceItem = mainForm.namePrice.Search(textBox3.Text);

            if (ShopItem != null && PriceItem != null)
            {
                if (mainForm.ShopTree.Find(textBox1.Text + textBox2.Text) == null ||
                    mainForm.PriceTree.Find(textBox3.Text) == null)
                {
                    mainForm.dictGeneral.Add(Tuple.Create(ShopItem, PriceItem));
                    mainForm.ShopTree.Add(ShopItem);
                    mainForm.PriceTree.Add(PriceItem);
                    Notification NotForm = new Notification("Запись добавлена!");
                    NotForm.Show();
                    mainForm.RefreshGeneralTable();
                }
                else if (!mainForm.dictGeneral.Contains(Tuple.Create(ShopItem, PriceItem)))
                {
                    mainForm.dictGeneral.Add(Tuple.Create(ShopItem, PriceItem));
                    mainForm.ShopTree.Add(ShopItem);
                    mainForm.PriceTree.Add(PriceItem);
                    Notification NotForm = new Notification("Запись добавлена!");
                    NotForm.Show();
                    mainForm.RefreshGeneralTable();
                }
                else
                {
                    Notification NotForm = new Notification("Запись уже существует!");
                    NotForm.Show();
                }
            }
            else
            {
                Notification NotForm = new Notification("Записи не существует!");
                NotForm.Show();
            }
            
            Close();
        }
    }
}
