namespace bodyInfoServer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bodyFis = new System.Windows.Forms.TextBox();
            this.bodyColor = new System.Windows.Forms.TextBox();
            this.bodySkid = new System.Windows.Forms.TextBox();
            this.bodyType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xiushionebody = new System.Windows.Forms.TextBox();
            this.xiushionecolor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xiushionefis = new System.Windows.Forms.TextBox();
            this.xiushioneskid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tconebody = new System.Windows.Forms.TextBox();
            this.tconecolor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tconefis = new System.Windows.Forms.TextBox();
            this.tconeskid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tconeoffbody = new System.Windows.Forms.TextBox();
            this.tconeoffcolor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tconeofffis = new System.Windows.Forms.TextBox();
            this.tconeoffskid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.hideMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // showMenuItem
            // 
            this.showMenuItem.Name = "showMenuItem";
            this.showMenuItem.Size = new System.Drawing.Size(100, 22);
            this.showMenuItem.Text = "显示";
            this.showMenuItem.Click += new System.EventHandler(this.showMenuItem_Click);
            // 
            // hideMenuItem
            // 
            this.hideMenuItem.Name = "hideMenuItem";
            this.hideMenuItem.Size = new System.Drawing.Size(100, 22);
            this.hideMenuItem.Text = "隐藏";
            this.hideMenuItem.Click += new System.EventHandler(this.hideMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1322, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "面准来车服务器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // bodyFis
            // 
            this.bodyFis.Location = new System.Drawing.Point(395, 32);
            this.bodyFis.Name = "bodyFis";
            this.bodyFis.Size = new System.Drawing.Size(56, 20);
            this.bodyFis.TabIndex = 40;
            // 
            // bodyColor
            // 
            this.bodyColor.Location = new System.Drawing.Point(283, 32);
            this.bodyColor.Name = "bodyColor";
            this.bodyColor.Size = new System.Drawing.Size(56, 20);
            this.bodyColor.TabIndex = 39;
            // 
            // bodySkid
            // 
            this.bodySkid.Location = new System.Drawing.Point(183, 32);
            this.bodySkid.Name = "bodySkid";
            this.bodySkid.Size = new System.Drawing.Size(56, 20);
            this.bodySkid.TabIndex = 38;
            this.bodySkid.TextChanged += new System.EventHandler(this.bodySkid_TextChanged);
            // 
            // bodyType
            // 
            this.bodyType.Location = new System.Drawing.Point(69, 32);
            this.bodyType.Name = "bodyType";
            this.bodyType.Size = new System.Drawing.Size(56, 20);
            this.bodyType.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "FIS编码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "颜色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "滑橇号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "车型";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bodyType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bodyFis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bodyColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bodySkid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 72);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "颜色编组站一区来车信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xiushionebody);
            this.groupBox2.Controls.Add(this.xiushionecolor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.xiushionefis);
            this.groupBox2.Controls.Add(this.xiushioneskid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 79);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修饰一线反修车来车信息";
            // 
            // xiushionebody
            // 
            this.xiushionebody.Location = new System.Drawing.Point(69, 33);
            this.xiushionebody.Name = "xiushionebody";
            this.xiushionebody.Size = new System.Drawing.Size(56, 20);
            this.xiushionebody.TabIndex = 45;
            // 
            // xiushionecolor
            // 
            this.xiushionecolor.Location = new System.Drawing.Point(283, 33);
            this.xiushionecolor.Name = "xiushionecolor";
            this.xiushionecolor.Size = new System.Drawing.Size(56, 20);
            this.xiushionecolor.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "车型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "FIS编码";
            // 
            // xiushionefis
            // 
            this.xiushionefis.Location = new System.Drawing.Point(395, 33);
            this.xiushionefis.Name = "xiushionefis";
            this.xiushionefis.Size = new System.Drawing.Size(56, 20);
            this.xiushionefis.TabIndex = 48;
            // 
            // xiushioneskid
            // 
            this.xiushioneskid.Location = new System.Drawing.Point(183, 33);
            this.xiushioneskid.Name = "xiushioneskid";
            this.xiushioneskid.Size = new System.Drawing.Size(56, 20);
            this.xiushioneskid.TabIndex = 46;
            this.xiushioneskid.TextChanged += new System.EventHandler(this.xiushioneskid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "滑橇号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "颜色";
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tconebody);
            this.groupBox3.Controls.Add(this.tconecolor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tconefis);
            this.groupBox3.Controls.Add(this.tconeskid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(548, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 72);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "面漆一线来车信息";
            // 
            // tconebody
            // 
            this.tconebody.Location = new System.Drawing.Point(69, 33);
            this.tconebody.Name = "tconebody";
            this.tconebody.Size = new System.Drawing.Size(56, 20);
            this.tconebody.TabIndex = 45;
            // 
            // tconecolor
            // 
            this.tconecolor.Location = new System.Drawing.Point(283, 33);
            this.tconecolor.Name = "tconecolor";
            this.tconecolor.Size = new System.Drawing.Size(56, 20);
            this.tconecolor.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "车型";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "FIS编码";
            // 
            // tconefis
            // 
            this.tconefis.Location = new System.Drawing.Point(395, 33);
            this.tconefis.Name = "tconefis";
            this.tconefis.Size = new System.Drawing.Size(56, 20);
            this.tconefis.TabIndex = 48;
            // 
            // tconeskid
            // 
            this.tconeskid.Location = new System.Drawing.Point(183, 33);
            this.tconeskid.Name = "tconeskid";
            this.tconeskid.Size = new System.Drawing.Size(56, 20);
            this.tconeskid.TabIndex = 46;
            this.tconeskid.TextChanged += new System.EventHandler(this.tconeskid_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "滑橇号";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "颜色";
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tconeoffbody);
            this.groupBox4.Controls.Add(this.tconeoffcolor);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tconeofffis);
            this.groupBox4.Controls.Add(this.tconeoffskid);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(548, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(486, 79);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "面漆一线下线车来车信息";
            // 
            // tconeoffbody
            // 
            this.tconeoffbody.Location = new System.Drawing.Point(69, 33);
            this.tconeoffbody.Name = "tconeoffbody";
            this.tconeoffbody.Size = new System.Drawing.Size(56, 20);
            this.tconeoffbody.TabIndex = 45;
            // 
            // tconeoffcolor
            // 
            this.tconeoffcolor.Location = new System.Drawing.Point(283, 33);
            this.tconeoffcolor.Name = "tconeoffcolor";
            this.tconeoffcolor.Size = new System.Drawing.Size(56, 20);
            this.tconeoffcolor.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "车型";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(342, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "FIS编码";
            // 
            // tconeofffis
            // 
            this.tconeofffis.Location = new System.Drawing.Point(395, 33);
            this.tconeofffis.Name = "tconeofffis";
            this.tconeofffis.Size = new System.Drawing.Size(56, 20);
            this.tconeofffis.TabIndex = 48;
            // 
            // tconeoffskid
            // 
            this.tconeoffskid.Location = new System.Drawing.Point(183, 33);
            this.tconeoffskid.Name = "tconeoffskid";
            this.tconeoffskid.Size = new System.Drawing.Size(56, 20);
            this.tconeoffskid.TabIndex = 46;
            this.tconeoffskid.TextChanged += new System.EventHandler(this.tconeoffskid_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(134, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "滑橇号";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(246, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "颜色";
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "面准来车信息服务";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox bodyFis;
        private System.Windows.Forms.TextBox bodyColor;
        private System.Windows.Forms.TextBox bodySkid;
        private System.Windows.Forms.TextBox bodyType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox xiushionebody;
        private System.Windows.Forms.TextBox xiushionecolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xiushionefis;
        private System.Windows.Forms.TextBox xiushioneskid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tconebody;
        private System.Windows.Forms.TextBox tconecolor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tconefis;
        private System.Windows.Forms.TextBox tconeskid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tconeoffbody;
        private System.Windows.Forms.TextBox tconeoffcolor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tconeofffis;
        private System.Windows.Forms.TextBox tconeoffskid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer6;
    }
}

