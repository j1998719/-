namespace WindowsFormsApp2
{
    partial class 餐車
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.返回 = new System.Windows.Forms.Button();
            this.確定 = new System.Windows.Forms.Button();
            this.套餐名字 = new System.Windows.Forms.Label();
            this.配料 = new System.Windows.Forms.GroupBox();
            this.rdo脆薯 = new System.Windows.Forms.RadioButton();
            this.rdo雞汁飯 = new System.Windows.Forms.RadioButton();
            this.飲料 = new System.Windows.Forms.GroupBox();
            this.rdo紅茶 = new System.Windows.Forms.RadioButton();
            this.rdo可樂 = new System.Windows.Forms.RadioButton();
            this.飲料加大 = new System.Windows.Forms.RadioButton();
            this.配料加大 = new System.Windows.Forms.RadioButton();
            this.配料升級 = new System.Windows.Forms.GroupBox();
            this.飲料升級 = new System.Windows.Forms.GroupBox();
            this.dataGridViewIColumnsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewIColumnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdo柳橙汁 = new System.Windows.Forms.RadioButton();
            this.配料.SuspendLayout();
            this.飲料.SuspendLayout();
            this.配料升級.SuspendLayout();
            this.飲料升級.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIColumnsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIColumnsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 返回
            // 
            this.返回.Location = new System.Drawing.Point(129, 432);
            this.返回.Name = "返回";
            this.返回.Size = new System.Drawing.Size(168, 68);
            this.返回.TabIndex = 0;
            this.返回.Text = "返回";
            this.返回.UseVisualStyleBackColor = true;
            this.返回.Click += new System.EventHandler(this.button2_Click);
            // 
            // 確定
            // 
            this.確定.Location = new System.Drawing.Point(421, 432);
            this.確定.Name = "確定";
            this.確定.Size = new System.Drawing.Size(159, 68);
            this.確定.TabIndex = 4;
            this.確定.Text = "確定";
            this.確定.UseVisualStyleBackColor = true;
            this.確定.Click += new System.EventHandler(this.確定_Click);
            // 
            // 套餐名字
            // 
            this.套餐名字.Location = new System.Drawing.Point(127, 20);
            this.套餐名字.Name = "套餐名字";
            this.套餐名字.Size = new System.Drawing.Size(109, 23);
            this.套餐名字.TabIndex = 5;
            this.套餐名字.Text = "無";
            this.套餐名字.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.套餐名字.Click += new System.EventHandler(this.套餐名字_Click);
            // 
            // 配料
            // 
            this.配料.Controls.Add(this.rdo脆薯);
            this.配料.Controls.Add(this.rdo雞汁飯);
            this.配料.Location = new System.Drawing.Point(129, 58);
            this.配料.Name = "配料";
            this.配料.Size = new System.Drawing.Size(218, 162);
            this.配料.TabIndex = 6;
            this.配料.TabStop = false;
            this.配料.Text = "配料";
            this.配料.Enter += new System.EventHandler(this.配料_Enter);
            // 
            // rdo脆薯
            // 
            this.rdo脆薯.AutoSize = true;
            this.rdo脆薯.Checked = true;
            this.rdo脆薯.Location = new System.Drawing.Point(57, 21);
            this.rdo脆薯.Name = "rdo脆薯";
            this.rdo脆薯.Size = new System.Drawing.Size(47, 16);
            this.rdo脆薯.TabIndex = 10;
            this.rdo脆薯.TabStop = true;
            this.rdo脆薯.Text = "脆薯";
            this.rdo脆薯.UseVisualStyleBackColor = true;
            this.rdo脆薯.CheckedChanged += new System.EventHandler(this.脆薯_CheckedChanged);
            // 
            // rdo雞汁飯
            // 
            this.rdo雞汁飯.AutoSize = true;
            this.rdo雞汁飯.Location = new System.Drawing.Point(57, 53);
            this.rdo雞汁飯.Name = "rdo雞汁飯";
            this.rdo雞汁飯.Size = new System.Drawing.Size(59, 16);
            this.rdo雞汁飯.TabIndex = 9;
            this.rdo雞汁飯.Text = "雞汁飯";
            this.rdo雞汁飯.UseVisualStyleBackColor = true;
            this.rdo雞汁飯.CheckedChanged += new System.EventHandler(this.雞汁飯_CheckedChanged);
            // 
            // 飲料
            // 
            this.飲料.Controls.Add(this.rdo柳橙汁);
            this.飲料.Controls.Add(this.rdo紅茶);
            this.飲料.Controls.Add(this.rdo可樂);
            this.飲料.Location = new System.Drawing.Point(129, 247);
            this.飲料.Name = "飲料";
            this.飲料.Size = new System.Drawing.Size(218, 165);
            this.飲料.TabIndex = 0;
            this.飲料.TabStop = false;
            this.飲料.Text = "飲料";
            this.飲料.Enter += new System.EventHandler(this.飲料_Enter);
            // 
            // rdo紅茶
            // 
            this.rdo紅茶.AutoSize = true;
            this.rdo紅茶.Location = new System.Drawing.Point(57, 71);
            this.rdo紅茶.Name = "rdo紅茶";
            this.rdo紅茶.Size = new System.Drawing.Size(47, 16);
            this.rdo紅茶.TabIndex = 12;
            this.rdo紅茶.Text = "紅茶";
            this.rdo紅茶.UseVisualStyleBackColor = true;
            this.rdo紅茶.CheckedChanged += new System.EventHandler(this.紅茶_CheckedChanged);
            // 
            // rdo可樂
            // 
            this.rdo可樂.AutoSize = true;
            this.rdo可樂.Checked = true;
            this.rdo可樂.Location = new System.Drawing.Point(57, 38);
            this.rdo可樂.Name = "rdo可樂";
            this.rdo可樂.Size = new System.Drawing.Size(47, 16);
            this.rdo可樂.TabIndex = 11;
            this.rdo可樂.TabStop = true;
            this.rdo可樂.Text = "可樂";
            this.rdo可樂.UseVisualStyleBackColor = true;
            this.rdo可樂.CheckedChanged += new System.EventHandler(this.可樂_CheckedChanged);
            // 
            // 飲料加大
            // 
            this.飲料加大.AutoSize = true;
            this.飲料加大.Location = new System.Drawing.Point(17, 64);
            this.飲料加大.Name = "飲料加大";
            this.飲料加大.Size = new System.Drawing.Size(47, 16);
            this.飲料加大.TabIndex = 14;
            this.飲料加大.TabStop = true;
            this.飲料加大.Text = "加大";
            this.飲料加大.UseVisualStyleBackColor = true;
            this.飲料加大.CheckedChanged += new System.EventHandler(this.飲料加大_CheckedChanged);
            // 
            // 配料加大
            // 
            this.配料加大.AutoSize = true;
            this.配料加大.Location = new System.Drawing.Point(14, 53);
            this.配料加大.Name = "配料加大";
            this.配料加大.Size = new System.Drawing.Size(47, 16);
            this.配料加大.TabIndex = 15;
            this.配料加大.TabStop = true;
            this.配料加大.Text = "加大";
            this.配料加大.UseVisualStyleBackColor = true;
            this.配料加大.CheckedChanged += new System.EventHandler(this.配料加大_CheckedChanged);
            // 
            // 配料升級
            // 
            this.配料升級.Controls.Add(this.配料加大);
            this.配料升級.Location = new System.Drawing.Point(371, 58);
            this.配料升級.Name = "配料升級";
            this.配料升級.Size = new System.Drawing.Size(75, 161);
            this.配料升級.TabIndex = 16;
            this.配料升級.TabStop = false;
            this.配料升級.Text = "升級";
            // 
            // 飲料升級
            // 
            this.飲料升級.Controls.Add(this.飲料加大);
            this.飲料升級.Location = new System.Drawing.Point(368, 254);
            this.飲料升級.Name = "飲料升級";
            this.飲料升級.Size = new System.Drawing.Size(77, 157);
            this.飲料升級.TabIndex = 17;
            this.飲料升級.TabStop = false;
            this.飲料升級.Text = "升級";
            // 
            // rdo柳橙汁
            // 
            this.rdo柳橙汁.AutoSize = true;
            this.rdo柳橙汁.Location = new System.Drawing.Point(57, 103);
            this.rdo柳橙汁.Name = "rdo柳橙汁";
            this.rdo柳橙汁.Size = new System.Drawing.Size(59, 16);
            this.rdo柳橙汁.TabIndex = 13;
            this.rdo柳橙汁.TabStop = true;
            this.rdo柳橙汁.Text = "柳橙汁";
            this.rdo柳橙汁.UseVisualStyleBackColor = true;
            this.rdo柳橙汁.CheckedChanged += new System.EventHandler(this.rdo柳橙汁_CheckedChanged);
            // 
            // 餐車
            // 
            this.ClientSize = new System.Drawing.Size(697, 575);
            this.Controls.Add(this.飲料升級);
            this.Controls.Add(this.配料升級);
            this.Controls.Add(this.飲料);
            this.Controls.Add(this.配料);
            this.Controls.Add(this.套餐名字);
            this.Controls.Add(this.確定);
            this.Controls.Add(this.返回);
            this.Name = "餐車";
            this.Load += new System.EventHandler(this.payMomey_Load);
            this.配料.ResumeLayout(false);
            this.配料.PerformLayout();
            this.飲料.ResumeLayout(false);
            this.飲料.PerformLayout();
            this.配料升級.ResumeLayout(false);
            this.配料升級.PerformLayout();
            this.飲料升級.ResumeLayout(false);
            this.飲料升級.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIColumnsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIColumnsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button 返回;
        private System.Windows.Forms.BindingSource dataGridViewIColumnsBindingSource1;
        private System.Windows.Forms.BindingSource dataGridViewIColumnsBindingSource;
        private System.Windows.Forms.Button 確定;
        private System.Windows.Forms.Label 套餐名字;
        private System.Windows.Forms.GroupBox 配料;
        private System.Windows.Forms.GroupBox 飲料;
        private System.Windows.Forms.RadioButton rdo脆薯;
        private System.Windows.Forms.RadioButton rdo雞汁飯;
        private System.Windows.Forms.RadioButton rdo紅茶;
        private System.Windows.Forms.RadioButton rdo可樂;
        private System.Windows.Forms.RadioButton 飲料加大;
        private System.Windows.Forms.RadioButton 配料加大;
        private System.Windows.Forms.GroupBox 配料升級;
        private System.Windows.Forms.GroupBox 飲料升級;
        private System.Windows.Forms.RadioButton rdo柳橙汁;
    }
}