using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class SearchGeneralPrice : Form
    {
        private MainForm mainForm;

        public SearchGeneralPrice(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var found = mainForm.PriceTree.Find(textBox1.Text);

            if (found != null)
            {
                mainForm.ShowPrice(found);
                Notification NotForm = new Notification("Найдены совпадения! Сравнений: " + mainForm.PriceTree.compare.ToString());
                NotForm.Show();                
                Close();
            }
            else
            {
                Notification NotForm = new Notification("Совпадения не найдены! Сравнений: " + mainForm.PriceTree.compare.ToString());
                NotForm.Show();
            }
        }
    }
}
