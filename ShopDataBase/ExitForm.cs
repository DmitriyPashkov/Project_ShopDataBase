using System;
using System.Windows.Forms;

namespace ShopDataBase
{
    public partial class ExitForm : Form
    {
        MainForm mainForm;        
        public ExitForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.SaveData();
            mainForm.isSaved = true;
            mainForm.Close();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.isSaved = true;
            mainForm.Close();          
        }     
    }
}
