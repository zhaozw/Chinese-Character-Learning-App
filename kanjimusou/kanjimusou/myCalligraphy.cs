﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanjimusou
{
    public partial class myCalligraphy : Form
    {
        public myCalligraphy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas ACanvas = new canvas();
            ACanvas.Show();
            this.Close();
        }

       
    }
}
