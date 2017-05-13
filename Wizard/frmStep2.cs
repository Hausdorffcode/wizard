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
    public partial class frmStep2 : frmOther
    {
        public frmStep2()
        {
            InitializeComponent();
        }

        public frmStep2(Controller c) : base(c)
        {
            InitializeComponent();
        }

        public override void UpdateInfo()
        {
            if (radioButtonMale.Checked)
            {
                this.controller.Info.sex = Sex.Man;
            }
            else
            {
                this.controller.Info.sex = Sex.Women;
            }
        }
    }
}
