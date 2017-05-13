using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard
{
    public class Controller
    {
        public Args Info;
        private frmMain mainFrom;
        private List<frmOther> frmList;
        private int curFromIndex;

        public Controller(frmMain m)
        {
            Info = new Args();
            this.mainFrom = m;
            frmList = new List<frmOther>();
            frmList.Add(new frmStep1(this));
            frmList.Add(new frmStep2(this));
            frmList.Add(new frmStep3(this));
            curFromIndex = 0;
        }

        public void run()
        {
            mainFrom.Hide();
            frmList[curFromIndex].Show();
            frmList[curFromIndex].UpdateButton();
            
        }

        public bool isFirst() { return curFromIndex == 0; }

        public bool isLast() { return curFromIndex == frmList.Count - 1; }

        public void goNext()
        {
            if (!isLast())
            {
                System.Drawing.Point location = frmList[curFromIndex].Location;
                frmList[curFromIndex].Hide();
                frmList[curFromIndex].UpdateInfo();

                frmList[++curFromIndex].Location = location;
                frmList[curFromIndex].Show();
                frmList[curFromIndex].UpdateButton();
            }
        }

        public void goPrev()
        {
            if (!isFirst())
            {
                System.Drawing.Point location = frmList[curFromIndex].Location;
                frmList[curFromIndex].Hide();
                frmList[curFromIndex].UpdateInfo();

                frmList[--curFromIndex].Location = location;
                frmList[curFromIndex].Show();
                frmList[curFromIndex].UpdateButton();
            }
        }

        public void cancle()
        {
            foreach(var item in frmList)
            {
                item.Close();
            }
            mainFrom.Show();
        }

        public void finish()
        {
            frmList[curFromIndex].UpdateInfo();
            mainFrom.SetArgs(Info);
            foreach (var item in frmList)
            {
                item.Close();
            }
            mainFrom.Show();
        }
    }
}
