namespace GameOfLifeSim
{
  partial class FormPatterns
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
      this.lbPatterns = new System.Windows.Forms.ListBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addToWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbPatterns
      // 
      this.lbPatterns.BackColor = System.Drawing.Color.Black;
      this.lbPatterns.ContextMenuStrip = this.contextMenuStrip1;
      this.lbPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbPatterns.ForeColor = System.Drawing.Color.Lime;
      this.lbPatterns.FormattingEnabled = true;
      this.lbPatterns.Location = new System.Drawing.Point(0, 0);
      this.lbPatterns.Name = "lbPatterns";
      this.lbPatterns.Size = new System.Drawing.Size(378, 358);
      this.lbPatterns.TabIndex = 0;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToWorldToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(148, 70);
      // 
      // createNewToolStripMenuItem
      // 
      this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
      this.createNewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.createNewToolStripMenuItem.Text = "Create New";
      this.createNewToolStripMenuItem.Click += new System.EventHandler(this.OnCreateNew);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.deleteToolStripMenuItem.Text = "Delete";
      // 
      // addToWorldToolStripMenuItem
      // 
      this.addToWorldToolStripMenuItem.Name = "addToWorldToolStripMenuItem";
      this.addToWorldToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.addToWorldToolStripMenuItem.Text = "Add To World";
      this.addToWorldToolStripMenuItem.Click += new System.EventHandler(this.OnAddToWorld);
      // 
      // FormPatterns
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.ClientSize = new System.Drawing.Size(378, 358);
      this.Controls.Add(this.lbPatterns);
      this.Name = "FormPatterns";
      this.ShowIcon = false;
      this.Text = "Patterns";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lbPatterns;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToWorldToolStripMenuItem;
  }
}