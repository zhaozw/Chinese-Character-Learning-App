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
    public partial class welcome : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;
        User Auser;

        public welcome()
        {
            InitializeComponent();
        }
        public welcome(User A):this()
        {
            Auser = A;
            this.userName.Text = Auser.Username;
        }

        private void start_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            learn Learn = new learn(Auser);
            Learn.Show();
            this.Close();
        }

        private void information_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            achievement Achievement = new achievement(Auser);
            Achievement.Show();
            this.Close();
        }

        private void welcome_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            prompt Apro = new prompt(this,Auser);
            Apro.Show();
        }


    }
}
