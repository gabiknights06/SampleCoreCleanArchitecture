using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJA_Inventory.view.GUIHelper
{
    public partial class BusyDialog : Form
    {

        Stopwatch _stopWatch;

        string _header { get; set; }

        string _message { get; set; }

        public static BusyDialog Instance { get; set; }
        public BusyDialog()
        {
            InitializeComponent();
            Initialize();
        }

        public BusyDialog(string header, string message) : this()
        {
            if(header != string.Empty)
                lbl_header.Text = " " +header;
            if(message != string.Empty)
            lbl_msg.Text = message;
        }

        void Initialize()
        {
            lbl_header.Text = " Processing";
            lbl_msg.Text = "Please wait. This may take a moment.";
            timer.Start();
            _stopWatch = new Stopwatch();
            _stopWatch.Start();

        }

        public static void Display(string header = "", string msg = "", bool asdialog = true)
        {
            if (Instance == null)
            {
                Instance = new BusyDialog(header, msg);
            }

            if (asdialog) Instance.ShowDialog();
            //else Instance.Show();
        }

        public static void CloseInstance()
        {
            if (Instance == null) return;
            Instance.Close();


           Instance.Dispose();
            Instance = null;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:hh\\:mm\\:ss}", _stopWatch.Elapsed);
        }
    }
}
