﻿namespace DD监控室
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.流 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.修改分辨率 = new System.Windows.Forms.Button();
            this.窗口高 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.窗口宽 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.liveIndex = new System.Windows.Forms.ComboBox();
            this.TopInfo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.Resolution = new System.Windows.Forms.ComboBox();
            this.YTBRoomID = new System.Windows.Forms.TextBox();
            this.vsavgsdbgfdbd = new System.Windows.Forms.Label();
            this.DMNF = new System.Windows.Forms.CheckBox();
            this.btn_Goto = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_RefreshLiveList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomNametext = new System.Windows.Forms.TextBox();
            this.btn_DeleteLive = new System.Windows.Forms.Button();
            this.btn_AddLive = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_TempListen = new System.Windows.Forms.Button();
            this.biliRoomId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.DDTV = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 183);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(201, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(574, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "更新流";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T1
            // 
            this.T1.Enabled = false;
            this.T1.Location = new System.Drawing.Point(617, 6);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(151, 21);
            this.T1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.liveIndex);
            this.groupBox1.Controls.Add(this.TopInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(290, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.流);
            this.groupBox3.Location = new System.Drawing.Point(11, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 55);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilibili";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "流选择";
            // 
            // 流
            // 
            this.流.FormattingEnabled = true;
            this.流.Items.AddRange(new object[] {
            "主线",
            "备线1",
            "备线2",
            "备线3"});
            this.流.Location = new System.Drawing.Point(67, 23);
            this.流.Name = "流";
            this.流.Size = new System.Drawing.Size(121, 20);
            this.流.TabIndex = 19;
            this.流.Text = "主线";
            this.流.SelectedIndexChanged += new System.EventHandler(this.流_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.修改分辨率);
            this.groupBox2.Controls.Add(this.窗口高);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.窗口宽);
            this.groupBox2.Location = new System.Drawing.Point(11, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 60);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 统一修改窗口大小";
            // 
            // 修改分辨率
            // 
            this.修改分辨率.Location = new System.Drawing.Point(132, 23);
            this.修改分辨率.Name = "修改分辨率";
            this.修改分辨率.Size = new System.Drawing.Size(56, 23);
            this.修改分辨率.TabIndex = 23;
            this.修改分辨率.Text = "修改";
            this.修改分辨率.UseVisualStyleBackColor = true;
            this.修改分辨率.Click += new System.EventHandler(this.修改分辨率_Click);
            // 
            // 窗口高
            // 
            this.窗口高.Location = new System.Drawing.Point(72, 24);
            this.窗口高.Name = "窗口高";
            this.窗口高.Size = new System.Drawing.Size(45, 21);
            this.窗口高.TabIndex = 24;
            this.窗口高.Text = "440";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "X";
            // 
            // 窗口宽
            // 
            this.窗口宽.Location = new System.Drawing.Point(9, 24);
            this.窗口宽.Name = "窗口宽";
            this.窗口宽.Size = new System.Drawing.Size(45, 21);
            this.窗口宽.TabIndex = 23;
            this.窗口宽.Text = "720";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(18, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "在窗口标题滚动鼠标也能修改音量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(73, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "1.0.2.0";
            // 
            // liveIndex
            // 
            this.liveIndex.FormattingEnabled = true;
            this.liveIndex.Location = new System.Drawing.Point(74, 152);
            this.liveIndex.Name = "liveIndex";
            this.liveIndex.Size = new System.Drawing.Size(46, 20);
            this.liveIndex.TabIndex = 4;
            this.liveIndex.SelectedIndexChanged += new System.EventHandler(this.选择直播_SelectedIndexChanged);
            // 
            // TopInfo
            // 
            this.TopInfo.AutoSize = true;
            this.TopInfo.BackColor = System.Drawing.Color.White;
            this.TopInfo.Location = new System.Drawing.Point(135, 154);
            this.TopInfo.Name = "TopInfo";
            this.TopInfo.Size = new System.Drawing.Size(84, 16);
            this.TopInfo.TabIndex = 25;
            this.TopInfo.Text = "锁定在最前";
            this.TopInfo.UseVisualStyleBackColor = false;
            this.TopInfo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择直播";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.Controls.Add(this.Resolution);
            this.groupBox5.Controls.Add(this.YTBRoomID);
            this.groupBox5.Controls.Add(this.vsavgsdbgfdbd);
            this.groupBox5.Location = new System.Drawing.Point(12, 419);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(502, 48);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "youtube下载流(请确保能连接到油管，并且带宽能流畅播放的分辨率，否则会出错)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "分辨率";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(418, 15);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(67, 23);
            this.button13.TabIndex = 32;
            this.button13.Text = "开始录制";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Resolution
            // 
            this.Resolution.FormattingEnabled = true;
            this.Resolution.Items.AddRange(new object[] {
            "256x144 ",
            "426x240",
            "640x360",
            "854x480",
            "1280x720",
            "1920x1080"});
            this.Resolution.Location = new System.Drawing.Point(324, 17);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(88, 20);
            this.Resolution.TabIndex = 19;
            this.Resolution.Text = "640x360";
            this.Resolution.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // YTBRoomID
            // 
            this.YTBRoomID.Location = new System.Drawing.Point(61, 17);
            this.YTBRoomID.Name = "YTBRoomID";
            this.YTBRoomID.Size = new System.Drawing.Size(214, 21);
            this.YTBRoomID.TabIndex = 32;
            // 
            // vsavgsdbgfdbd
            // 
            this.vsavgsdbgfdbd.AutoSize = true;
            this.vsavgsdbgfdbd.Location = new System.Drawing.Point(7, 22);
            this.vsavgsdbgfdbd.Name = "vsavgsdbgfdbd";
            this.vsavgsdbgfdbd.Size = new System.Drawing.Size(41, 12);
            this.vsavgsdbgfdbd.TabIndex = 33;
            this.vsavgsdbgfdbd.Text = "频道号";
            // 
            // DMNF
            // 
            this.DMNF.AutoSize = true;
            this.DMNF.BackColor = System.Drawing.Color.White;
            this.DMNF.Checked = true;
            this.DMNF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DMNF.Location = new System.Drawing.Point(12, 473);
            this.DMNF.Name = "DMNF";
            this.DMNF.Size = new System.Drawing.Size(510, 16);
            this.DMNF.TabIndex = 30;
            this.DMNF.Text = "打开弹幕(测试功能!,有硬件需求,部分硬件会失败)和锁定窗口置顶冲突，需先勾选再开视频";
            this.DMNF.UseVisualStyleBackColor = false;
            this.DMNF.CheckedChanged += new System.EventHandler(this.DMNF_CheckedChanged);
            // 
            // btn_Goto
            // 
            this.btn_Goto.Location = new System.Drawing.Point(224, -1);
            this.btn_Goto.Name = "btn_Goto";
            this.btn_Goto.Size = new System.Drawing.Size(43, 23);
            this.btn_Goto.TabIndex = 30;
            this.btn_Goto.Text = "跳转";
            this.btn_Goto.UseVisualStyleBackColor = true;
            this.btn_Goto.Click += new System.EventHandler(this.btn_GoTo_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(114, 23);
            this.button11.TabIndex = 29;
            this.button11.Text = "现在录制该房间";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 51);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(114, 23);
            this.button10.TabIndex = 27;
            this.button10.Text = "设置开播自动录像";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "查看录制";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_RefreshLiveList
            // 
            this.btn_RefreshLiveList.Location = new System.Drawing.Point(174, 260);
            this.btn_RefreshLiveList.Name = "btn_RefreshLiveList";
            this.btn_RefreshLiveList.Size = new System.Drawing.Size(92, 23);
            this.btn_RefreshLiveList.TabIndex = 18;
            this.btn_RefreshLiveList.Text = "刷新";
            this.btn_RefreshLiveList.UseVisualStyleBackColor = true;
            this.btn_RefreshLiveList.Click += new System.EventHandler(this.btn_RefreshLiveList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "房间名";
            // 
            // RoomNametext
            // 
            this.RoomNametext.Location = new System.Drawing.Point(53, 287);
            this.RoomNametext.Name = "RoomNametext";
            this.RoomNametext.Size = new System.Drawing.Size(115, 21);
            this.RoomNametext.TabIndex = 16;
            // 
            // btn_DeleteLive
            // 
            this.btn_DeleteLive.Location = new System.Drawing.Point(223, 283);
            this.btn_DeleteLive.Name = "btn_DeleteLive";
            this.btn_DeleteLive.Size = new System.Drawing.Size(43, 23);
            this.btn_DeleteLive.TabIndex = 15;
            this.btn_DeleteLive.Text = "删除";
            this.btn_DeleteLive.UseVisualStyleBackColor = true;
            this.btn_DeleteLive.Click += new System.EventHandler(this.btn_DeleteLive_Click);
            // 
            // btn_AddLive
            // 
            this.btn_AddLive.Location = new System.Drawing.Point(174, 283);
            this.btn_AddLive.Name = "btn_AddLive";
            this.btn_AddLive.Size = new System.Drawing.Size(43, 23);
            this.btn_AddLive.TabIndex = 14;
            this.btn_AddLive.Text = "添加";
            this.btn_AddLive.UseVisualStyleBackColor = true;
            this.btn_AddLive.Click += new System.EventHandler(this.btn_AddLive_Click_1);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.Font = new System.Drawing.Font("宋体", 10F);
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "启动后第一次加载检测房间列表中......"});
            this.listBox.Location = new System.Drawing.Point(6, 20);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(260, 238);
            this.listBox.TabIndex = 13;
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseClick);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btn_TempListen
            // 
            this.btn_TempListen.Location = new System.Drawing.Point(6, 314);
            this.btn_TempListen.Name = "btn_TempListen";
            this.btn_TempListen.Size = new System.Drawing.Size(260, 23);
            this.btn_TempListen.TabIndex = 11;
            this.btn_TempListen.Text = "不添加到列表,临时监听(名单也可以双击)";
            this.btn_TempListen.UseVisualStyleBackColor = true;
            this.btn_TempListen.Click += new System.EventHandler(this.btn_TempListen_Click);
            // 
            // biliRoomId
            // 
            this.biliRoomId.Location = new System.Drawing.Point(53, 260);
            this.biliRoomId.Name = "biliRoomId";
            this.biliRoomId.Size = new System.Drawing.Size(115, 21);
            this.biliRoomId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "房间号";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(805, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 44);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "youtube";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(558, 57);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 28;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(570, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "直播流";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(645, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "停止流";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(714, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "关于";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // DDTV
            // 
            this.DDTV.ContextMenuStrip = this.contextMenuStrip1;
            this.DDTV.Icon = ((System.Drawing.Icon)(resources.GetObject("DDTV.Icon")));
            this.DDTV.Text = "DDTV";
            this.DDTV.Visible = true;
            this.DDTV.BalloonTipShown += new System.EventHandler(this.DDTV_BalloonTipShown);
            this.DDTV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.Location = new System.Drawing.Point(421, 64);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 29;
            this.button14.Text = "关于/帮助";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.listBox);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btn_AddLive);
            this.groupBox6.Controls.Add(this.btn_DeleteLive);
            this.groupBox6.Controls.Add(this.btn_Goto);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.biliRoomId);
            this.groupBox6.Controls.Add(this.RoomNametext);
            this.groupBox6.Controls.Add(this.btn_TempListen);
            this.groupBox6.Controls.Add(this.btn_RefreshLiveList);
            this.groupBox6.Location = new System.Drawing.Point(12, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 343);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "房间";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.button10);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Location = new System.Drawing.Point(290, 333);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(224, 80);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "房间列表下载";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 496);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DMNF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Text = "DD导播中心(多路直播监控)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox liveIndex;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btn_TempListen;
        private System.Windows.Forms.TextBox biliRoomId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RoomNametext;
        private System.Windows.Forms.Button btn_DeleteLive;
        private System.Windows.Forms.Button btn_AddLive;
        private System.Windows.Forms.Button btn_RefreshLiveList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox 流;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button 修改分辨率;
        private System.Windows.Forms.TextBox 窗口高;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox 窗口宽;
        private System.Windows.Forms.CheckBox TopInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Resolution;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.CheckBox DMNF;
        private System.Windows.Forms.Button btn_Goto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label vsavgsdbgfdbd;
        private System.Windows.Forms.TextBox YTBRoomID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon DDTV;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

