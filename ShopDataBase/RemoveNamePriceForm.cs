using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class RemoveNamePriceForm : Form
    {
        private MainForm mainForm;
        public RemoveNamePriceForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MainForm.namePrice.Remove(textBox1.Text);
                mainForm.RefreshPriceTable();
            }
            else
            {
                ErrorForm error = new ErrorForm();
                error.Show();
            }
            Close();
        }
    }
}
