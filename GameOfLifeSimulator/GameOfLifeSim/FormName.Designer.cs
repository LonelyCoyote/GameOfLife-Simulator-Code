namespace GameOfLifeSim
{
  partial class FormName
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
      this.tbName = new System.Windows.Forms.TextBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbName
      // 
      this.tbName.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbName.Location = new System.Drawing.Point(12, 12);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(646, 31);
      this.tbName.TabIndex = 0;
      this.tbName.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Enabled = false;
      this.btnOK.Location = new System.Drawing.Point(583, 49);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // FormName
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.ClientSize = new System.Drawing.Size(681, 83);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.tbName);
      this.MaximumSize = new System.Drawing.Size(697, 122);
      this.MinimumSize = new System.Drawing.Size(697, 122);
      this.Name = "FormName";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Enter A Name For This Pattern";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.Button btnOK;
  }
}