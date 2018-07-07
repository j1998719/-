using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class 加大 : CondimentDecorator
    {
        單點 單點;

        public 加大(單點 other)
        {
            this.單點 = other;
        }

        public override string GetName()
        {
            return 單點.GetName() + "加大";
        }

        public override string GetDescription()
        {
            return 單點.GetDescription() + "加大";
        }

        public override int GetPrice()
        {
            return 單點.GetPrice() + 25;
        }

        public override string Type()
        {
            return "加大";
        }
    }
}
