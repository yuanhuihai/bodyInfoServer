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


/*
 timer1定时1s钟，显示时间信息
 timer2定时20s，从PLC获取值
     
     */
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


        #region 底部显示时间信息
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
        #endregion

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 20000;

            #region 颜色编组站一区来车信息
            bodySkid.Text = operatePLC.getCharValue("10.228.141.94", 960, 340, 4);
            bodyType.Text = operatePLC.getCharValue("10.228.141.94", 960, 118, 3);
            bodyColor.Text = operatePLC.getCharValue("10.228.141.94", 960, 132, 4);
            bodyFis.Text = operatePLC.getCharValue("10.228.141.94", 960, 8, 8);
            #endregion


            #region 修饰一线反修车信息
            xiushionebody.Text = operatePLC.getCharValue("10.228.141.98", 956, 18, 3);
            xiushionecolor.Text = operatePLC.getCharValue("10.228.141.98", 956, 32, 4);
            xiushioneskid.Text = operatePLC.getCharValue("10.228.141.98", 956, 240, 4);
            xiushionefis.Text = operatePLC.getCharValue("10.228.141.98", 956, 10, 8);
            #endregion

            #region 面漆一线来车信息
            tconebody.Text = operatePLC.getCharValue("10.228.141.158", 951, 18, 3);
            tconecolor.Text = operatePLC.getCharValue("10.228.141.158", 951, 32, 4);
            tconeskid.Text = operatePLC.getCharValue("10.228.141.158", 951, 240, 4);
            tconefis.Text = operatePLC.getCharValue("10.228.141.158", 951, 10, 8);
            #endregion


            #region 面漆一线下线车来车信息
            tconeoffbody.Text = operatePLC.getCharValue("10.228.141.98", 951, 18, 3);
            tconeoffcolor.Text = operatePLC.getCharValue("10.228.141.98", 951, 32, 4);
            tconeoffskid.Text = operatePLC.getCharValue("10.228.141.98", 951, 240, 4);
            tconeofffis.Text = operatePLC.getCharValue("10.228.141.98", 951, 10, 8);
            #endregion


        }
        //颜色编组站来车记录
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 10000;

            #region 颜色编组站一区来车信息记录到数据库

            if (bodySkid.Text == "....")
            {

            }
            else
            {
                string sqlstr = "insert into bodyColorSeq values('','" + bodyFis.Text + "','" + bodyColor.Text + "','" + bodySkid.Text + "','" + bodyType.Text + "','','') ";
                operateDatabase.OrcGetCom(sqlstr);
                timer3.Stop();
            }

            #endregion

          
        }

        //修饰来车记录
        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 10000;
            #region 修饰一线返修区域来车信息记录到数据库

            if (xiushioneskid.Text == "....")
            {

            }
            else
            {
                string sqlstr = "insert into XIUSHIONEREPAIRBODYINFO values('','','','" + xiushionebody.Text + "','" +xiushioneskid.Text + "','" + xiushionecolor.Text + "','" + xiushionefis.Text + "') ";
                operateDatabase.OrcGetCom(sqlstr);
                timer4.Stop();
            }

            #endregion

        }

        //面漆一线来车记录
        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Interval = 10000;
            #region 修饰一线返修区域来车信息记录到数据库

            if (tconeskid.Text == "....")
            {

            }
            else
            {
                string sqlstr = "insert into TCONEBODYINFO values('','','','" + tconefis.Text + "','" + tconecolor.Text + "','" + tconeskid.Text + "','" + tconebody.Text + "') ";
                operateDatabase.OrcGetCom(sqlstr);
                timer5.Stop();
            }

            #endregion
        }

        //面漆一线下线车来车记录
        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Interval = 10000;


            if (tconeoffskid.Text == "....")
            {

            }
            else
            {
                string sqlstr = "insert into XIUSHIONEREPAIRBODYINFO values('','','','" + tconeoffbody.Text + "','" + tconeoffskid.Text + "','" + tconeoffcolor.Text + "','" + tconeofffis.Text + "') ";
                operateDatabase.OrcGetCom(sqlstr);
                timer5.Stop();
            }
        }


        //颜色编组站来车
        private void bodySkid_TextChanged(object sender, EventArgs e)
        {
            timer3.Start();
        }

        //修饰来车
        private void xiushioneskid_TextChanged(object sender, EventArgs e)
        {
            timer4.Start();
        }


        //面漆一线来车

        private void tconeskid_TextChanged(object sender, EventArgs e)
        {
            timer5.Start();
        }


        //面漆一线下线车来车
        private void tconeoffskid_TextChanged(object sender, EventArgs e)
        {
            timer6.Start();
        }
    }
}
