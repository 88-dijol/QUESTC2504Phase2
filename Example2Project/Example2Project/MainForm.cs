using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2Project
{
    public partial class frmCounterApp : Form
    {
        public frmCounterApp()
        {
            InitializeComponent();

            CounterConfig.lblStatus = lblStatus;
        }

        private frmCounter frmCounter = new frmCounter();
        private frmExtendedCounter frmExtendedCounter = new frmExtendedCounter();


        private void mnuSimpleCounter_Click(object sender, EventArgs e)
        {

            //frmCounter.MdiParent = this;
            //frmCounter.Show();
            //frmCounter.Activate();  ---we dont want to use this in counter .config we are using an another method 
            CounterConfig.ShowChild(this,frmCounter);

        }

        private void mnuExtendedCounter_Click(object sender, EventArgs e)
        {
            //frmExtendedCounter.MdiParent = this;
            //frmExtendedCounter.Show();
            //frmExtendedCounter.Activate();
            CounterConfig.ShowChild(this, frmExtendedCounter);

        }
    }
}
