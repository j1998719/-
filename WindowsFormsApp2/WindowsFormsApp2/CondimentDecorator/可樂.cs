using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class 可樂 : 單點
    {
        

        public override string GetDescription()
        {
            return "可樂";
        }

        public override string GetName()
        {
            return "可樂";
        }

        public override int GetPrice()
        {
            return 30;
        }

        public override string Type()
        {
            return "飲料";
        }
    }
}
