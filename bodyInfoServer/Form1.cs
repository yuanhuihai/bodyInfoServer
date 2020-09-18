using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using comWithPlc;
using oracleDatabase;

namespace bodyInfoServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        getPlcValues operatePLC = new getPlcValues();

        oracleDatabaseOperate operateDatabase = new oracleDatabaseOperate();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        #region 程序后台运行



        //窗体关闭时执行，窗体后台运行
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出程序吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void hideMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();

        }

        //桌面右小角图标
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//判断鼠标的按键
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Minimized;

                    this.Hide();
                }
                else if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                }
            }
        }


        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 20000;
            bodySkid.Text = operatePLC.getCharValue("10.228.141.94", 960, 340, 4);
            bodyType.Text = operatePLC.getCharValue("10.228.141.94", 960, 118, 3);
            bodyColor.Text = operatePLC.getCharValue("10.228.141.94", 960, 132, 4);
            bodyFis.Text = operatePLC.getCharValue("10.228.141.94", 960, 8, 8);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 10000;
  
            if (bodySkid.Text == "....")
            {

            }
            else
            {
                string sqlstr = "insert into bodyColorSeq values('','" + bodyFis.Text + "','" + bodyColor.Text + "','" + bodySkid.Text + "','" + bodyType.Text + "','','') ";
                operateDatabase.OrcGetCom(sqlstr);
                timer3.Stop();
            }
        }

        private void bodySkid_TextChanged(object sender, EventArgs e)
        {
            timer3.Start();
        }
    }
}
