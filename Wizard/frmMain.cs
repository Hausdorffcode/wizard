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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewInfo_Click(object sender, EventArgs e)
        {
            Controller MyController = new Controller(this);
            MyController.run();
        }

        public void SetArgs(Args s)
        {
            txtName.Text = s.name;
            txtSex.Text = s.sex.ToString();
            txtHobby.Text = s.hobby;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
