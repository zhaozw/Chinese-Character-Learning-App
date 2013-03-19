﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Kanjimusou.Lib;

namespace Kanjimusou
{
    public partial class DL : Form
    {


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;



        public static User Auser;
        public static int counts = 0;
        //计数判断窗体个数

        private bool showing = true;



        public DL()
        {
            InitializeComponent();
             Opacity = 0.0;      //窗体透明度为0
            Atimer.Start(); //计时开始

        }

       

        



        private void log_on_Click(object sender, EventArgs e)
        {
            ZC Logon = new ZC();
            Logon.Show();
        }

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.30;
            if (showing)
            {
                if (Opacity + d >= 0.9)
                {
                    Opacity = 0.85;
                    Atimer.Stop();
                }
                else
                {
                    Opacity += d;
                }
            }
            else
            {
                
                if (Opacity - d <= 0.9)
                {
                    Opacity = 0.0;
                    Atimer.Stop();
                }
                else
                {
                    Opacity -= d;
                }
            }
        }

        private void closethis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }


        private void dlu_Click(object sender, EventArgs e)
        {
            welcome Welcome = new welcome();
            Welcome.Show();
        }


        //如何返回此参数

        

        

        
    }
}