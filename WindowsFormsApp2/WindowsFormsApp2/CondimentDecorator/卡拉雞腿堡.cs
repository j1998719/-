using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class 卡拉雞腿堡 : 單點
    {
        單點 hamburger;
        
        
        public 卡拉雞腿堡(單點 HAMBURGER)
        {
            this.hamburger = HAMBURGER;
        }

        public 卡拉雞腿堡()
        {
            
        }

        public override string GetName()
        {
            return "卡拉雞腿堡";
        }

        public override string GetDescription()
        {
            return "卡拉雞腿堡";
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
