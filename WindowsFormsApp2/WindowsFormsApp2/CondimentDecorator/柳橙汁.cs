using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
     public class 柳橙汁 : 單點
    {
        public override string GetDescription()
        {
            return "柳橙汁";
        }

        public override string GetName()
        {
            return "柳橙汁";
        }

        public override int GetPrice()
        {
            return 45;
        }

        public override string Type()
        {
            return "貴的飲料";
        }
    }
}
