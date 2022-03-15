using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMostRecentlyUsed_apps
{
    public partial class reportGeneratedPopUp : Form
    {
        public reportGeneratedPopUp()
        {
            InitializeComponent();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {

        }

        private void reportGeneratedPopUp_Load(object sender, EventArgs e)
        {
            reportNameLabel.Text = Form1.reportName;
        }
    }
}
