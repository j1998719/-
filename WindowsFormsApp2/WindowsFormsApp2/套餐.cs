using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class 套餐 : 單點
    {
        單點 主菜;
        單點 飲料;
        單點 配料;

        public int Price;

        public  virtual void 設定主菜(單點 other)
        {
            this.主菜 = other;
        }

        public override int GetPrice()
        {
            return Price;
        }

        public virtual void 設定飲料(單點 other)
        {
            if(other.Type() == "貴的飲料")
            {
                Price += 15;
            }

            this.飲料 = other;
        }

        public virtual void 設定配料(單點 other)
        {
            this.配料 = other;
        }

        public override string GetDescription()
        {
            return 主菜.GetDescription() + 飲料.GetDescription() + 配料.GetDescription();
        }

    }
}
