namespace GameOfLifeSim
{
  partial class FormHelp
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
      this.txtboxHelp = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtboxHelp
      // 
      this.txtboxHelp.BackColor = System.Drawing.Color.Black;
      this.txtboxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtboxHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtboxHelp.ForeColor = System.Drawing.Color.Cyan;
      this.txtboxHelp.Location = new System.Drawing.Point(0, 0);
      this.txtboxHelp.Multiline = true;
      this.txtboxHelp.Name = "txtboxHelp";
      this.txtboxHelp.ReadOnly = true;
      this.txtboxHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtboxHelp.Size = new System.Drawing.Size(1043, 350);
      this.txtboxHelp.TabIndex = 1;
      this.txtboxHelp.TabStop = false;
      this.txtboxHelp.Text = resources.GetString("txtboxHelp.Text");
      // 
      // FormHelp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.ClientSize = new System.Drawing.Size(1043, 350);
      this.Controls.Add(this.txtboxHelp);
      this.Name = "FormHelp";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Help";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtboxHelp;
  }
}