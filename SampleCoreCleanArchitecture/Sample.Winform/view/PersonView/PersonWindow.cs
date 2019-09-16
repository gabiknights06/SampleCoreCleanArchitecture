using DJA_Inventory.view.GUIHelper;
using Sample.Winform.APICaller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.Winform.view.PersonView
{
    public partial class PersonWindow : Form
    {
        public PersonWindow()
        {
            InitializeComponent();
            //BusyDialog.Display();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            //var api = new PersonWebAPIRepository(URLConnection.BaseURL, URLConnection.CurrentReference);
        }
    }
}
