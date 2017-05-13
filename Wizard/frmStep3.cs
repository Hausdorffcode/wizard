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
    public partial class frmStep3 : frmOther
    {
        public frmStep3()
        {
            InitializeComponent();
        }

        public frmStep3(Controller c) : base(c)
        {
            InitializeComponent();
        }

        public override void UpdateInfo()
        {
            string s = "";
            if (checkBoxChess.Checked)
            {
                s += (checkBoxChess.Text + System.Environment.NewLine);
            }
            if (checkBoxBasketBll.Checked)
            {
                s += checkBoxBasketBll.Text + System.Environment.NewLine;
            }
            if (checkBoxReading.Checked)
            {
                s += checkBoxReading.Text + System.Environment.NewLine;
            }
            if (checkBoxShopping.Checked)
            {
                s += checkBoxShopping.Text + System.Environment.NewLine;
            }
            if (s == "")
            {
                s = "None";
            }
            this.controller.Info.hobby = s;
        }
    }
}
