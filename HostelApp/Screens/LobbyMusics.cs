﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HostelApp
{
    public partial class LobbyMusics : Form
    {
        public LobbyMusics()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"File Path";
            axWindowsMediaPlayer1.Ctlcontrols.play(); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"File Path";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"File_Path";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainScreen frm = new MainScreen();
            frm.Show();
            this.Close();
        }
    }
}
