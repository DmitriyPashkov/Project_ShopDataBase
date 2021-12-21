using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class CompareForm : Form
    {
        private MainForm mainForm;      
        public CompareForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;            
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            label2.Text = MainForm.ShopTree.compare.ToString();           
        }
    }
}
