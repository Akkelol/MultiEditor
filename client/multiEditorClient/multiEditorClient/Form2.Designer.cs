namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.revertToSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToSavedFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.testBeatmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAiModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadBeatmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractMapPackateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openSongFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openosuInNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openosbInNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton7 = new System.Windows.Forms.ToolStripDropDownButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "select osu! directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton6,
            this.toolStripDropDownButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openDifficultyToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.createANewDifficultyToolStripMenuItem,
            this.toolStripSeparator1,
            this.revertToSavedToolStripMenuItem,
            this.revertToSavedFullToolStripMenuItem,
            this.toolStripSeparator2,
            this.testBeatmapToolStripMenuItem,
            this.openAiModToolStripMenuItem,
            this.toolStripSeparator3,
            this.uploadBeatmapToolStripMenuItem,
            this.exportPackageToolStripMenuItem,
            this.extractMapPackateToolStripMenuItem,
            this.importFromToolStripMenuItem,
            this.toolStripSeparator4,
            this.openSongFolderToolStripMenuItem,
            this.openosuInNotepadToolStripMenuItem,
            this.openosbInNotepadToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem1.Text = "Clear All Notes";
            // 
            // openDifficultyToolStripMenuItem
            // 
            this.openDifficultyToolStripMenuItem.Name = "openDifficultyToolStripMenuItem";
            this.openDifficultyToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.openDifficultyToolStripMenuItem.Text = "Open Difficulty...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // createANewDifficultyToolStripMenuItem
            // 
            this.createANewDifficultyToolStripMenuItem.Name = "createANewDifficultyToolStripMenuItem";
            this.createANewDifficultyToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.createANewDifficultyToolStripMenuItem.Text = "Create a new Difficulty...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // revertToSavedToolStripMenuItem
            // 
            this.revertToSavedToolStripMenuItem.Name = "revertToSavedToolStripMenuItem";
            this.revertToSavedToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.revertToSavedToolStripMenuItem.Text = "Revert to Saved";
            // 
            // revertToSavedFullToolStripMenuItem
            // 
            this.revertToSavedFullToolStripMenuItem.Name = "revertToSavedFullToolStripMenuItem";
            this.revertToSavedFullToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.revertToSavedFullToolStripMenuItem.Text = "Revert to Saved (Full)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // testBeatmapToolStripMenuItem
            // 
            this.testBeatmapToolStripMenuItem.Name = "testBeatmapToolStripMenuItem";
            this.testBeatmapToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.testBeatmapToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.testBeatmapToolStripMenuItem.Text = "Test Beatmap";
            // 
            // openAiModToolStripMenuItem
            // 
            this.openAiModToolStripMenuItem.Name = "openAiModToolStripMenuItem";
            this.openAiModToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.openAiModToolStripMenuItem.Text = "Open AiMod";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
            // 
            // uploadBeatmapToolStripMenuItem
            // 
            this.uploadBeatmapToolStripMenuItem.Name = "uploadBeatmapToolStripMenuItem";
            this.uploadBeatmapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.uploadBeatmapToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.uploadBeatmapToolStripMenuItem.Text = "Upload Beatmap...";
            // 
            // exportPackageToolStripMenuItem
            // 
            this.exportPackageToolStripMenuItem.Name = "exportPackageToolStripMenuItem";
            this.exportPackageToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exportPackageToolStripMenuItem.Text = "Export Package";
            // 
            // extractMapPackateToolStripMenuItem
            // 
            this.extractMapPackateToolStripMenuItem.Name = "extractMapPackateToolStripMenuItem";
            this.extractMapPackateToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.extractMapPackateToolStripMenuItem.Text = "Extract Map Package";
            // 
            // importFromToolStripMenuItem
            // 
            this.importFromToolStripMenuItem.Name = "importFromToolStripMenuItem";
            this.importFromToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.importFromToolStripMenuItem.Text = "Import from...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(242, 6);
            // 
            // openSongFolderToolStripMenuItem
            // 
            this.openSongFolderToolStripMenuItem.Name = "openSongFolderToolStripMenuItem";
            this.openSongFolderToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.openSongFolderToolStripMenuItem.Text = "Open Song Folder";
            this.openSongFolderToolStripMenuItem.Click += new System.EventHandler(this.openSongFolderToolStripMenuItem_Click);
            // 
            // openosuInNotepadToolStripMenuItem
            // 
            this.openosuInNotepadToolStripMenuItem.Name = "openosuInNotepadToolStripMenuItem";
            this.openosuInNotepadToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.openosuInNotepadToolStripMenuItem.Text = "Open .osu in Notepad";
            // 
            // openosbInNotepadToolStripMenuItem
            // 
            this.openosbInNotepadToolStripMenuItem.Name = "openosbInNotepadToolStripMenuItem";
            this.openosbInNotepadToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.openosbInNotepadToolStripMenuItem.Text = "Open .osb in Notepad";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(242, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exitToolStripMenuItem.Text = "Exit...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton2.Text = "Edit";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton3.Text = "View";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(71, 22);
            this.toolStripDropDownButton4.Text = "Compose";
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(56, 22);
            this.toolStripDropDownButton5.Text = "Design";
            // 
            // toolStripDropDownButton6
            // 
            this.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton6.Image")));
            this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
            this.toolStripDropDownButton6.Size = new System.Drawing.Size(58, 22);
            this.toolStripDropDownButton6.Text = "Timing";
            // 
            // toolStripDropDownButton7
            // 
            this.toolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton7.Image")));
            this.toolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton7.Name = "toolStripDropDownButton7";
            this.toolStripDropDownButton7.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton7.Text = "Help";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Compose";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(178, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Design";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(356, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Timing";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(534, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Song Setup";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(237, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

			#endregion

			private System.Windows.Forms.Button button1;
			private System.Windows.Forms.OpenFileDialog openFileDialog1;
			private System.Windows.Forms.ToolStrip toolStrip1;
			private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
			private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
			private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
			private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
			private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
			private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton6;
			private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton7;
			private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
			private System.Windows.Forms.ToolStripMenuItem openDifficultyToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem createANewDifficultyToolStripMenuItem;
			private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
			private System.Windows.Forms.ToolStripMenuItem revertToSavedToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem revertToSavedFullToolStripMenuItem;
			private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
			private System.Windows.Forms.ToolStripMenuItem testBeatmapToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem openAiModToolStripMenuItem;
			private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
			private System.Windows.Forms.ToolStripMenuItem uploadBeatmapToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem exportPackageToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem extractMapPackateToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem importFromToolStripMenuItem;
			private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
			private System.Windows.Forms.ToolStripMenuItem openSongFolderToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem openosuInNotepadToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem openosbInNotepadToolStripMenuItem;
			private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
			private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
			private System.Windows.Forms.Button button2;
			private System.Windows.Forms.Button button3;
			private System.Windows.Forms.Button button4;
			private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}