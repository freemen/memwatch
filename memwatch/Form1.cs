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
        private int pushTimes;
        //private Process mProcess;
        private Process[] mProcesses;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pushTimes = 0;

            lv.GridLines = true;
            lv.Columns.Add("进程ID",60,HorizontalAlignment.Center);
            lv.Columns.Add("线程数");
            lv.Columns.Add("物理内存",100,HorizontalAlignment.Left);
            lv.Columns.Add("分页内存", 100, HorizontalAlignment.Right);
            lv.Columns.Add("优先级");
            lv.Visible = true;
            infoText.Text = "init ok";
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
            if (pushTimes == 0)
            {
                pushTimes = 1;
                refreshTimer.Start();

            }else{
                pushTimes = 0;
                refreshTimer.Stop();
                infoText.Text = "don't push me any more!";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //mProcess.Close();
            infoText.Text = "oh my god~";
            this.Close();
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count >= 1)
            {
                lv.Sort();
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            //lv.Items.Clear();
            String[] info = new String[7];
            mProcesses = Process.GetProcesses();
            foreach (Process mProcess in mProcesses)
            {
                info[0] = mProcess.ProcessName;
                info[1] = mProcess.MainWindowTitle;
                info[2] = Convert.ToString(mProcess.Id);
                info[3] = Convert.ToString(mProcess.Threads.Count);
                info[4] = Convert.ToString(mProcess.WorkingSet64 / 1024) + "K";
                info[5] = Convert.ToString(mProcess.PagedMemorySize64 / 1024) + "K";
                info[6] = mProcess.BasePriority.ToString();

                String indexkey = "p" + info[2].ToString();
                int index = lv.Items.IndexOfKey(indexkey);
                if (!lv.Items.ContainsKey(indexkey))
                {
                    logBox.AppendText("\nno " + indexkey);
                }
                ListViewItem li = new ListViewItem(info, indexkey);
                if (index<0)
                {
                    lv.Items.Add(li);
                    //logBox.AppendText("\nnew LVIkey is"+li.ImageKey );
                }
                else
                {
                    if (!lv.Items[index].Equals(li))
                    {
                        lv.Items.RemoveAt(index);
                        lv.Items.Add(li);
                        logBox.AppendText("\nitem changed so" + indexkey);
                    }
                }
            }
            foreach (ListViewItem lvi in lv.Items)
            {
                //TODO:delete the ones that didn't appear anymore
            }

        }

    }
}
