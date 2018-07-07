using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class 紐澳良烤雞腿堡 : CondimentDecorator
    {
              

        public override string GetName()
        {
            return "紐澳良烤雞腿堡";
        }

        public override string GetDescription()
        {
            return "紐澳良烤雞腿"; 
        }

        public override int GetPrice()
        {
            return 100;
        }

        public override string Type()
        {
            return "主菜";
        }
    }
}
