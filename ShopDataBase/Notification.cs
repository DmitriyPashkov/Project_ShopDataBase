using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class Notification : Form
    {        
        public Notification(string lb1)
        {
            InitializeComponent();
            label1.Text = lb1;
        }        
    }
}
