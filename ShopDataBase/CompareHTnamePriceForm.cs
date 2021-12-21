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
    public partial class CompareHTnamePriceForm : Form
    {
        private MainForm mainForm;
        public CompareHTnamePriceForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CompareHTnamePriceForm_Load(object sender, EventArgs e)
        {
            label2.Text = MainForm.namePrice.compare.ToString();
        }
    }
}
