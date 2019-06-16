using MPUCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DD监控室.UI
{
    public partial class LiveForm : Form
    {
        public static Size playWindowDefaultSize = new Size(720, 440);//播放窗口的默认大小
        public static Point WindowTopLeft = new Point(3, 3);
        public VLCPlayer player = null;

        private bool topMost = false;
        /// <summary>
        /// 窗口置顶
        /// </summary>
        public bool TopMost
        {
            get { return topMost; }
            set { topMost = value; }
        }

       
        private bool borderless = false;
        /// <summary>
        /// 无边框模式
        /// </summary>
        public bool Borderless
        {
            get { return borderless; }
            set { borderless = value; }
        }

        public LiveForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 直播窗口初始化
        /// </summary>
        public void InitLiveForm(int curWindowNum)
        {
            this.Size = LiveForm.playWindowDefaultSize;
            VLCContainer.Size = new Size(this.Width - WindowTopLeft.X - 20, this.Height - WindowTopLeft.Y - 42);
            VLCContainer.Location = WindowTopLeft;

            this.player = new VLCPlayer();

            this.Icon = new Icon("./DDTV.ico");
            this.Show();
            this.Name = (curWindowNum).ToString();
            this.KeyPreview = true;
            this.ResizeEnd += A_ResizeEnd;
            this.Activated += A_Activated;
            this.FormClosing += A_FormClosing;
            this.Move += A_Move;
            this.MouseWheel += A_MouseWheel;
            this.KeyDown += A_KeyDown;
            this.MouseMove += A_MouseMove;
        }

        public void Play(string streamData)
        {
            if(player != null)
                player.Play(streamData, VLCContainer.Handle);
        }

        #region Events
        /// <summary>
        /// 动态窗口焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_Activated(object sender, EventArgs e)
        {
            Form A = sender as Form;
            CurrentlyStream = int.Parse(A.Name);
            liveIndex.Text = (CurrentlyStream).ToString();
            TopInfo.Checked = MMPU.RoomInfo[CurrentlyStream].Top;
            if (MMPU.DanmakuEnabled)
            {
                try
                {
                    DmF[CurrentlyStream].Topmost = true;
                    DmF[CurrentlyStream].Topmost = false;
                }
                catch (Exception)
                {

                }

            }
        }

        /// <summary>
        /// 动态窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form F1 = sender as Form;
            int 标号 = int.Parse(F1.Name);
            if (VLC[标号].IsInitlized)
            {
                VLC[标号].Stop();
                VLC[标号].Dispose();
            }

            liveIndex.Items.Remove(标号.ToString());
            new Thread(new ThreadStart(delegate
            {
                MMPU.RoomInfo[标号].status = false;
                Thread.Sleep(1000);
                //Directory.Delete("./tmp/" + MMPU.RoomInfo[标号].RoomNumber);
                if (MMPU.DanmakuEnabled)
                {
                    try
                    {
                        this.DmF[标号].Dispatcher.Invoke(
                  new Action(
                    delegate
                    {
                        DmF[标号].Close();
                    }
                    ));
                    }
                    catch (Exception ex)
                    {
                        string asd = ex.ToString();
                    }
                }
            })).Start();

        }

        /// <summary>
        /// 动态窗口缩放事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_ResizeEnd(object sender, EventArgs e)
        {
            UpdatePlayerSize(sender);
            if (MMPU.DanmakuEnabled)
            {
                try
                {
                    DmF[CurrentlyStream].Width = FM[CurrentlyStream].Width - 20;
                    DmF[CurrentlyStream].Height = FM[CurrentlyStream].Height - 50;

                    DmF[CurrentlyStream].Top = FM[CurrentlyStream].Top + 30;
                    DmF[CurrentlyStream].Left = FM[CurrentlyStream].Left + 10;
                    DmF[CurrentlyStream].Topmost = true;
                    DmF[CurrentlyStream].Topmost = false;

                }
                catch (Exception)
                {
                }

            }
        }

        private void A_KeyDown(object sender, KeyEventArgs e)
        {
            Form F1 = sender as Form;
            if (e.KeyData == Keys.F5)
            {
                try
                {
                    int.Parse(MMPU.RoomInfo[CurrentlyStream].RoomNumber);
                    string roomId = MMPU.RoomInfo[int.Parse(F1.Name)].RoomNumber;
                    string VideoTitle = getUriSteam.GetUrlTitle(roomId, "bilibili");
                    string steamData = getUriSteam.getBiliRoomId(roomId, "bilibili");
                    T1.Text = steamData;
                    CurrentlyStream = int.Parse(F1.Name);
                    VLC[CurrentlyStream].Play(steamData, PBOX[CurrentlyStream].Handle);
                    MMPU.RoomInfo[CurrentlyStream] = (new Room.RoomInfo { Name = CurrentlyStream.ToString(), RoomNumber = roomId, steam = steamData, status = true, Text = VideoTitle });
                    EditTitleVolume(CurrentlyStream, trackBar1.Value);
                    if (VLC[CurrentlyStream].GetPlayerState() == -10)
                    {
                        UpdateLiveForm(CurrentlyStream, roomId);
                    }
                }
                catch (Exception)
                {
                    UpdateLiveForm(int.Parse(F1.Name), MMPU.RoomInfo[int.Parse(F1.Name)].RoomNumber);
                }

                //Console.WriteLine("按下了F5");
            }
        }

        /// <summary>
        /// 鼠标滚轮事件(修改音量)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_MouseWheel(object sender, MouseEventArgs e)
        {
            Form F1 = sender as Form;
            CurrentlyStream = int.Parse(F1.Name);
            liveIndex.Text = F1.Name;
            float addsd = 0.0f;
            if (e.Delta > 0)
                addsd -= 0.1f;
            else
                addsd += 0.1f;
            if (addsd >= 3)
                addsd = 3;
            if (addsd <= 1)
                addsd = 1f;

            int 当前音量 = VLC[CurrentlyStream].Volume;

            if (e.Delta > 0)//上
            {
                当前音量 += 5;
            }
            else if (e.Delta < 0)//下
            {
                当前音量 -= 5;
            }
            if (当前音量 > 100)
            {
                当前音量 = 100;
            }
            else if (当前音量 < 0)
            {
                当前音量 = 0;
            }
            VLC[CurrentlyStream].Volume = 当前音量;
            trackBar1.Value = 当前音量;
            EditTitleVolume(CurrentlyStream, 当前音量);
        }

        /// <summary>
        /// 动态窗口移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_Move(object sender, EventArgs e)
        {
            UpdatePlayerSize(sender);
            if (MMPU.DanmakuEnabled)
            {
                try
                {
                    DmF[CurrentlyStream].Width = FM[CurrentlyStream].Width - 20;
                    DmF[CurrentlyStream].Height = FM[CurrentlyStream].Height - 50;

                    DmF[CurrentlyStream].Top = FM[CurrentlyStream].Top + 30;
                    DmF[CurrentlyStream].Left = FM[CurrentlyStream].Left + 10;
                    DmF[CurrentlyStream].Topmost = true;
                    DmF[CurrentlyStream].Topmost = false;
                }
                catch (Exception)
                {
                }

            }
        }

        /// <summary>
        /// 鼠标移动到上面发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A_MouseMove(object sender, EventArgs e)
        {
            Form A = sender as Form;
            CurrentlyStream = int.Parse(A.Name);
            liveIndex.Text = (CurrentlyStream).ToString();
            TopInfo.Checked = MMPU.RoomInfo[CurrentlyStream].Top;
            if (MMPU.DanmakuEnabled)
            {
                try
                {
                    DmF[CurrentlyStream].Topmost = true;
                    DmF[CurrentlyStream].Topmost = false;
                }
                catch (Exception)
                {
                }

            }

        }
        private void UpdatePlayerSize(object sender)
        {
            Form F1 = sender as Form;
            CurrentlyStream = int.Parse(F1.Name);
            PBOX[CurrentlyStream].Size = new Size(LiveFormList[CurrentlyStream].Width - WindowTopLeft.X - 20, LiveFormList[CurrentlyStream].Height - WindowTopLeft.Y - 42);
            FSize[int.Parse(F1.Name)] = F1.Size;
        }
        #endregion
    }
}
