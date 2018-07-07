using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class 雞汁飯 : 單點
    {
        

        public override string GetDescription()
        {
            return "雞汁飯";
        }

        public override string GetName()
        {
            return "雞汁飯";
        }

        public override int GetPrice()
        {
            return 100;
        }

        public override string Type()
        {
            return "配菜";
        }
    }
}
