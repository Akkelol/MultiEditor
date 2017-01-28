﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        string opendPath;
        string songsDir;
        string skinDir;
        string songDirName;
        string skinDirName;
        string userName = Environment.UserName;
        string osucfgFile;
        bool fileSelected = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;                                     //gets size of screen and adjusts the form to fit
        }

        
        void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();                           //opens the file browser 
            fbd.Description = "Select your osu! folder, usually located in .appdata";      //sets fbd description
            if (fbd.ShowDialog() == DialogResult.OK);                                      //checks if the user clicked OK or exited out
            opendPath = fbd.SelectedPath;                                                  //stores folder path as string opendPath
            osucfgFile = opendPath + "\\osu!."+userName + ".cfg";                          //get song folder and skin name from text file
            //time to declare some paths



            var sectionName = "Skin = ";
            string[] items =
                File.ReadLines(osucfgFile)                           //read file lazily 
                    .SkipWhile(line => line != sectionName)        //search for header
                    .Skip(1)                                       //skip header
                    .TakeWhile(line => !string.IsNullOrEmpty(line))//take until next header
                    .ToArray();
            MessageBox.Show(osucfgFile);
            songsDir = "get songs dir, stupid";
            skinDir = "declare the skinDir, idiot";



            // to get a specific folder or file inside the osuDir use @"opendPath"+ @"\Archive\" where Archive is the file or folder you need
            //like this:
            //pictureBox1.ImageLocation = opendPath + "/Skins/Mashup/approachcircle.png";
            //if the skin is called Mashup
            pictureBox1.ImageLocation = opendPath + "/Skins/Mashup/approachcircle.png";

        }
        private void openSongFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", songsDir);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();                                                             //allows the user to quit the program
        }


    }
}
