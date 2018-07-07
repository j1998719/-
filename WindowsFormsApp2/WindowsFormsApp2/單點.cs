using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
        public abstract class 單點
        {
            public string name = "無";
            public string description = "無";
            public abstract string Type();
            
            
            public abstract int GetPrice();

            public virtual string GetName()
            {
                return this.name;
            }

            public virtual string GetDescription()
            {
                return this.description;
            }

            public  int OrderNumber =1 ;
        }
}
