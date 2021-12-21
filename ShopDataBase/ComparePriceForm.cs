using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class ComparePriceForm : Form
    {
        private MainForm mainForm;
        public ComparePriceForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /*private void ComparePriceForm_Load(object sender, EventArgs e)
        {
            label2.Text = MainForm.PriceTree.compare.ToString();
        }*/

        private void ComparePriceForm_Load_1(object sender, EventArgs e)
        {
            label2.Text = MainForm.PriceTree.compare.ToString();
        }
    }
}
