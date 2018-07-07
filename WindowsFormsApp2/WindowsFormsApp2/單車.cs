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
    public partial class 單車 : Form
    {
        

        string MyOrderDetail;
        string 餐車標題;
        object sender = null;
        EventArgs e = new EventArgs();
        int 加價;

        
        


        public void 不重複添加(單點 other)

        {
            
            int number = 1;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == other.GetName())
                    {
                        number = (int)row.Cells[2].Value + 1;
                        dataGridView1.Rows.Remove(row);
                    }
                    
                }
                
            }

            dataGridView1.Rows.Add(other.GetName(), other.GetPrice(), number, number*other.GetPrice());
            
            B總價_Click(sender, e);

            

        }

        public void 不重複添加(套餐 other)
        {
            
            int number = 1;
            
            餐車標題 = other.GetName();

            餐車_Click(sender, e);
            MyOrderDetail = other.GetName() + "(" + MyOrderDetail + ")";
            加價 += other.GetPrice();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == MyOrderDetail)
                    {
                        number = (int)row.Cells[2].Value + 1;
                        dataGridView1.Rows.Remove(row);
                    }

                }

            }

            dataGridView1.Rows.Add(MyOrderDetail, 加價, number, number * 加價);
            B總價_Click(sender, e);

        }


        public 單車()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            單點 order = new 卡拉雞腿堡();
            
            不重複添加(order);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            單點 order = new 雞汁飯();
            不重複添加(order);
            
        }

        private void 餐車_Click(object sender, EventArgs e)
        {
            
            餐車 餐車 = new 餐車();

            
            餐車.標題 = 餐車標題;

            餐車.ShowDialog();

            MyOrderDetail = 餐車.OrderDetail;
            加價 = 餐車.加價;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            單點 order = new 紐澳良烤雞腿堡();
            不重複添加(order);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            單點 order = new 脆薯();
            不重複添加(order);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            單點 order = new 可樂();
            不重複添加(order);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            單點 order = new 紅茶();
            不重複添加(order);
            
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "刪除")
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                }
            }

            B總價_Click(sender, e);
        }

        private void B總價_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells[0].Value != null)
                    total += (int)row.Cells[3].Value;
            }
            B總價.Text = total.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            套餐 order = new 紐澳良烤雞腿堡套餐();
            不重複添加(order);
            B總價_Click(sender, e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void B套餐_Click(object sender, EventArgs e)
        {
            G套餐.Left = 161;
            G套餐.Top = 12;
            G套餐.Width = 512;
            G套餐.Height = 231;
            G套餐.Visible = true;
            G單點.Visible = false;
            B套餐.Enabled = false;
            B單點.Enabled = true;
        }

        private void B單點_Click(object sender, EventArgs e)
        {
            G單點.Left = 161;
            G單點.Top = 12;
            G單點.Width = 512;
            G單點.Height = 231;
            G單點.Visible = true;
            G套餐.Visible = false;
            B單點.Enabled = false;
            B套餐.Enabled = true;
        }

        private void 套餐1_Click(object sender, EventArgs e)
        {
            套餐 order = new 卡啦雞腿堡套餐();
            不重複添加(order);
            B總價_Click(sender, e);
        }

        private void 單車_Load(object sender, EventArgs e)
        {

        }
    }
}
