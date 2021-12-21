using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class SearchGeneralShop : Form
    {
        private MainForm mainForm;        

        public SearchGeneralShop(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var FoundItem = mainForm.ShopTree.Find(textBox1.Text + textBox2.Text);

            if (FoundItem != null)
            {              
                mainForm.ShowShops(FoundItem);
                Notification NotForm = new Notification("Найдены совпадения! Сравнений: " + mainForm.ShopTree.compare.ToString());
                NotForm.Show();
                Close();
            }
            else
            {
                Notification NotForm = new Notification("Совпадения не найдены! Сравнений: " + mainForm.ShopTree.compare.ToString());
                NotForm.Show();
            }
        }
    }
}
