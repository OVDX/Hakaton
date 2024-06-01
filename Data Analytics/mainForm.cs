using Data_Analyst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Analytics
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        List<Product> listOfProducts = new List<Product>();

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


            

            typeCmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            typeCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            typeCmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            typeCmb.IntegralHeight = false;
            typeCmb.MaxDropDownItems = 5;

            nameCmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            nameCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            nameCmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameCmb.IntegralHeight = false;
            nameCmb.MaxDropDownItems = 5;
        }

        private void typeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
