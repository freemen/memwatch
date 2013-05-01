using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace memwatch
{
    public partial class Form1 : Form
    {
        private int pushTimes = 1;
        private Process mProcess = null;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lv.View = View.Details;
            //lv.GridLines = true;
            lv.Columns.Add("进程ID");
            lv.Columns.Add("线程数");
            lv.Columns.Add("物理内存");
            lv.Visible = true;
            infoText.Text = "init ok";
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lv.Width = (Form1.ActiveForm.Size.Width * 3) / 4; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int r = rand.Next() % 255;
            int g = (rand.Next() >> 8) % 255;
            int b = (rand.Next() >> 16) % 255;
            this.infoText.Text = "r:"+r.ToString()+"g"+g.ToString()+"b"+b.ToString();

            this.BackColor = Color.FromArgb(r,g,b);
        }

        private void infoText_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();
            li.SubItems.Clear();
            li.SubItems[0].Text = "en?";
            li.SubItems.Add("iiii:");
            this.lv.Items.Add(li);
            this.lv.Items.Add("pig");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //mProcess.Close();
            infoText.Text = "oh my god~";
            this.Close();
        }
    }
}
