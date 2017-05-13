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
    public partial class frmStep1 : frmOther
    {
        public frmStep1()
        {
            InitializeComponent();
        }

        public frmStep1(Controller c) : base(c)
        {
            InitializeComponent();
        }

        public override void UpdateInfo()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name can not be empty!");
                
            }
            else
            {
                this.controller.Info.name = txtName.Text;
            }
        }
    }
}
