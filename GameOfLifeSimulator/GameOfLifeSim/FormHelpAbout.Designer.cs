namespace GameOfLifeSim
{
  partial class FormHelpAbout
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(12, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(689, 39);
      this.label1.TabIndex = 0;
      this.label1.Text = "GAME OF LIFE SIMULATOR VERSION 1";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(12, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(689, 74);
      this.label2.TabIndex = 1;
      this.label2.Text = "The Game of Life, also known simply as Life, is a cellular automaton devised by t" +
    "he British mathematician John Horton Conway in 1970";
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Aqua;
      this.label3.Location = new System.Drawing.Point(12, 123);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(689, 33);
      this.label3.TabIndex = 2;
      this.label3.Text = "For the rules check out Conways Game Of Life On the Internet";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Aqua;
      this.label4.Location = new System.Drawing.Point(95, 156);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(484, 27);
      this.label4.TabIndex = 3;
      this.label4.Text = "This software is open source (no copywrite)";
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Aqua;
      this.label5.Location = new System.Drawing.Point(204, 183);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(268, 27);
      this.label5.TabIndex = 4;
      this.label5.Text = "Author: Dennis Bingaman";
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Aqua;
      this.label6.Location = new System.Drawing.Point(95, 210);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(510, 51);
      this.label6.TabIndex = 5;
      this.label6.Text = "Feel Free to contact me: ddbtech@hughes.net";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(315, 250);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 6;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // FormHelpAbout
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.ClientSize = new System.Drawing.Size(702, 294);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(718, 333);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(718, 333);
      this.Name = "FormHelpAbout";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnOK;
  }
}