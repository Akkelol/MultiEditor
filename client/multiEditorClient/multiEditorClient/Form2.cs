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
        string fileContent;
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

        }
        private void openSongFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();                                                             //allows the user to quit the program
        }


    }
}
