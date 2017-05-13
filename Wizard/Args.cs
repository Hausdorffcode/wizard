using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard
{
    public class Args
    {
        public string name = "";
        public string hobby = "";
        public Sex sex;
    }

    public enum Sex
    {
        Man = 1,
        Women = 0
    }
}
