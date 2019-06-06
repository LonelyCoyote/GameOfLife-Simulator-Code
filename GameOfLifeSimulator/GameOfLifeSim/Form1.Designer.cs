namespace GameOfLifeSim
{
  partial class Form1
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
      if(disposing && (components != null))
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
      this.components = new System.ComponentModel.Container();
      this.pbWorld = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miLoad = new System.Windows.Forms.ToolStripMenuItem();
      this.miSave = new System.Windows.Forms.ToolStripMenuItem();
      this.miClearScreen = new System.Windows.Forms.ToolStripMenuItem();
      this.miFrameTime = new System.Windows.Forms.ToolStripMenuItem();
      this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miCreateWorld = new System.Windows.Forms.ToolStripMenuItem();
      this.miSimWorld = new System.Windows.Forms.ToolStripMenuItem();
      this.miPatterns = new System.Windows.Forms.ToolStripMenuItem();
      this.miRandomPattern = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tmrUpdateScreen = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pbWorld)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pbWorld
      // 
      this.pbWorld.BackColor = System.Drawing.Color.Black;
      this.pbWorld.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pbWorld.Location = new System.Drawing.Point(0, 24);
      this.pbWorld.Name = "pbWorld";
      this.pbWorld.Size = new System.Drawing.Size(961, 555);
      this.pbWorld.TabIndex = 0;
      this.pbWorld.TabStop = false;
      this.pbWorld.DoubleClick += new System.EventHandler(this.OnDoubleClick);
      this.pbWorld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnSingleClick);
      this.pbWorld.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseButtonDown);
      this.pbWorld.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.miPatterns,
            this.miRandomPattern,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(961, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoad,
            this.miSave,
            this.miClearScreen,
            this.miFrameTime});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // miLoad
      // 
      this.miLoad.Name = "miLoad";
      this.miLoad.Size = new System.Drawing.Size(139, 22);
      this.miLoad.Text = "Load";
      this.miLoad.Click += new System.EventHandler(this.OnLoadWorld);
      // 
      // miSave
      // 
      this.miSave.Name = "miSave";
      this.miSave.Size = new System.Drawing.Size(139, 22);
      this.miSave.Text = "Save";
      this.miSave.Click += new System.EventHandler(this.OnSaveWorld);
      // 
      // miClearScreen
      // 
      this.miClearScreen.Name = "miClearScreen";
      this.miClearScreen.Size = new System.Drawing.Size(139, 22);
      this.miClearScreen.Text = "Clear Screen";
      this.miClearScreen.Click += new System.EventHandler(this.OnClearScreen);
      // 
      // miFrameTime
      // 
      this.miFrameTime.Name = "miFrameTime";
      this.miFrameTime.Size = new System.Drawing.Size(139, 22);
      this.miFrameTime.Text = "Frame Time";
      this.miFrameTime.Click += new System.EventHandler(this.OnChangeFrameTime);
      // 
      // modeToolStripMenuItem
      // 
      this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateWorld,
            this.miSimWorld});
      this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
      this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.modeToolStripMenuItem.Text = "Mode";
      // 
      // miCreateWorld
      // 
      this.miCreateWorld.Name = "miCreateWorld";
      this.miCreateWorld.Size = new System.Drawing.Size(143, 22);
      this.miCreateWorld.Text = "Create World";
      this.miCreateWorld.Click += new System.EventHandler(this.OnCreateWorld);
      // 
      // miSimWorld
      // 
      this.miSimWorld.Name = "miSimWorld";
      this.miSimWorld.Size = new System.Drawing.Size(143, 22);
      this.miSimWorld.Text = "Sim World";
      this.miSimWorld.Click += new System.EventHandler(this.OnSimWorld);
      // 
      // miPatterns
      // 
      this.miPatterns.Name = "miPatterns";
      this.miPatterns.Size = new System.Drawing.Size(62, 20);
      this.miPatterns.Text = "Patterns";
      this.miPatterns.Click += new System.EventHandler(this.OnMenuPatterns);
      // 
      // miRandomPattern
      // 
      this.miRandomPattern.Name = "miRandomPattern";
      this.miRandomPattern.Size = new System.Drawing.Size(105, 20);
      this.miRandomPattern.Text = "Random Pattern";
      this.miRandomPattern.Click += new System.EventHandler(this.OnGenerateRandomPattern);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.instructionsToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnHelpAbout);
      // 
      // instructionsToolStripMenuItem
      // 
      this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
      this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.instructionsToolStripMenuItem.Text = "Instructions";
      this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.OnHelpIntructions);
      // 
      // tmrUpdateScreen
      // 
      this.tmrUpdateScreen.Interval = 20;
      this.tmrUpdateScreen.Tick += new System.EventHandler(this.OnUpdateScreen);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(961, 579);
      this.Controls.Add(this.pbWorld);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.ShowIcon = false;
      this.Text = "Game of Life Simulator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
      this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
      ((System.ComponentModel.ISupportInitialize)(this.pbWorld)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pbWorld;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem miLoad;
    private System.Windows.Forms.ToolStripMenuItem miSave;
    private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem miCreateWorld;
    private System.Windows.Forms.ToolStripMenuItem miSimWorld;
    private System.Windows.Forms.Timer tmrUpdateScreen;
    private System.Windows.Forms.ToolStripMenuItem miPatterns;
    private System.Windows.Forms.ToolStripMenuItem miClearScreen;
    private System.Windows.Forms.ToolStripMenuItem miRandomPattern;
    private System.Windows.Forms.ToolStripMenuItem miFrameTime;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
  }
}

