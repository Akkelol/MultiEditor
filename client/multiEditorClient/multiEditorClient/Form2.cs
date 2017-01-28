using System;
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
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
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
            //time to declare some paths
WHY DOES IT ADD /2 IN FRONT OF THE USERNAME ? !? !? this.wasAllGoingSoWell until(this) happened!
            osucfgFile = opendPath + "\\osu!."+userName + ".cfg";                    //get song folder and skin name from text file
            /*int startLine = 1;
            int lineCount = 10;
            var fileLines = File.ReadAllLines(osucfgFile)
                            .Skip((startLine - 1))
                            .Take(lineCount);*/
            MessageBox.Show(osucfgFile);
            songsDir = "pull a line from the array, stupid";
            skinDir = "pull a line from the array, idiot";
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
