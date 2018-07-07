using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class 卡啦雞腿堡套餐 : 套餐
    {
        單點 主菜 = new 卡拉雞腿堡();
        單點 飲料 = new 可樂();
        單點 配料 = new 脆薯();

        

        public override string GetName()
        {
            return "卡拉雞腿堡套餐";
        }

        public override int GetPrice()
        {
            return 100;
        }

        public override string Type()
        {
            return "套餐";
        }
    }
}
