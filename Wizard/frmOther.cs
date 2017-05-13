using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizard
{
    public partial class frmOther : Form
    {
        protected Controller controller;

        public frmOther()
        {
            InitializeComponent();
        }

        public frmOther(Controller c)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.controller = c;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            controller.goPrev();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            controller.goNext();
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            controller.finish();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            controller.cancle();
        }

        public virtual void UpdateInfo()
        {

        }

        public void UpdateButton()
        {
            if (controller.isFirst())
            {
                btnPrev.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
            }
            if (controller.isLast())
            {
                btnNext.Enabled = false;
                btnfinish.Enabled = true;
            }
            else
            {
                btnNext.Enabled = true;
                btnfinish.Enabled = false;
            }
        }
    }
}
