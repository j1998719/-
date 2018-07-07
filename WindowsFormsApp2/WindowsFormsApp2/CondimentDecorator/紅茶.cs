using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class 紅茶 : 單點
    {
        

        public override string GetDescription()
        {
            return "紅茶";
        }

        public override string GetName()
        {
            return "紅茶";
        }

        public override int GetPrice()
        {
            return 30;
        }

        public override string Type()
        {
            return "配菜";
        }
    }
}
