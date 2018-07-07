using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 餐車 : Form
    {

        
        public string OrderDetail = "";
        public string 標題;
        public int 加價 = 0;
        string 配料名稱;
        string 飲料名稱;
        bool 配料要不要加大 = false;
        bool 飲料要不要加大 = false;

        

        單點 脆薯 = new 脆薯();
        單點 雞汁飯 = new 雞汁飯();
        單點 紅茶 = new 紅茶();
        單點 可樂 = new 可樂();
        單點 柳橙汁 = new 柳橙汁();

        

        public void 配料清單(string other)
        {
            var 配料 = new List<單點> { 脆薯 , 雞汁飯 };
            var 飲料 = new List<單點> { 紅茶, 可樂, 柳橙汁 };

            foreach (單點 哈哈 in 配料)
            {
                if (哈哈.GetName() == other)
                {
                    if (配料要不要加大 == true)
                    {
                        加大 加大配料 = new 加大(哈哈);
                        配料名稱 = 加大配料.GetName();
                        加價 += 加大配料.GetPrice() - 哈哈.GetPrice();
                    }
                    else
                    {
                        配料名稱 = 哈哈.GetName();
                    }
                }

            }

        }

        public void 飲料清單(string other)
        {
            var 配料 = new List<單點> { 脆薯, 雞汁飯 };
            var 飲料 = new List<單點> { 紅茶, 可樂, 柳橙汁 };

            foreach (單點 哈哈 in 飲料)
            {
                if (哈哈.GetName() == other)
                {
                    if(飲料要不要加大 == true)
                    {
                        加大 加大飲料 = new 加大(哈哈);
                        飲料名稱 = 加大飲料.GetName();
                        加價 += 加大飲料.GetPrice() - 哈哈.GetPrice();
                    }
                    else
                    {
                        飲料名稱 = 哈哈.GetName();
                    }
                }
                
            }

        }



        private void 升級(string other)
        {
            foreach(單點 物件 in Controls)
            {
                if (物件.GetName() == other)
                {

                }
                    
            }
        }

        public 餐車()
        {
            InitializeComponent();
            
            
        }

       

        private void payMomey_Load(object sender, EventArgs e)
        {
            套餐名字.Text = 標題;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            單車 單車 = new 單車();
            
            單車.DataBindings.GetEnumerator();
        }

        private void 配料_Enter(object sender, EventArgs e)
        {

        }

        private void 確定_Click(object sender, EventArgs e)
        {

            foreach(RadioButton rdo in 配料.Controls)
            {
                if (rdo.Checked == true)
                    配料名稱 = rdo.Text;
            }

            foreach (RadioButton rdo in 飲料.Controls)
            {
                if (rdo.Checked == true)
                    飲料名稱 = rdo.Text;
            }


            if (配料加大.Checked == true)
            {
                配料要不要加大 = true;
            }

            if (飲料加大.Checked == true)
            {
                飲料要不要加大 = true;
            }



            配料清單(配料名稱);
            飲料清單(飲料名稱);


            OrderDetail = 配料名稱 + " " + 飲料名稱;
            

            this.Close();
           
        }

        private void 飲料_Enter(object sender, EventArgs e)
        {

        }

        private void 套餐名字_Click(object sender, EventArgs e)
        {

        }

        private void 可樂_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void 脆薯_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void 配料加大_CheckedChanged(object sender, EventArgs e)
        {

            
        }


        private void 飲料加大_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void 雞汁飯_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void 紅茶_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdo柳橙汁_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
