﻿namespace GameOfLifeSim
{
  partial class FormFrameTime
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
      this.ncFrameTime = new System.Windows.Forms.NumericUpDown();
      this.btnOK = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ncFrameTime)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(589, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "THE FRAME TIME IS THE TIME BETWEEN SCREEN UPDATES FOR EACH CLOCK TICK OF THE CELL" +
    "ULAR WORLD";
      // 
      // ncFrameTime
      // 
      this.ncFrameTime.Location = new System.Drawing.Point(472, 25);
      this.ncFrameTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.ncFrameTime.Name = "ncFrameTime";
      this.ncFrameTime.Size = new System.Drawing.Size(120, 20);
      this.ncFrameTime.TabIndex = 1;
      this.ncFrameTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(517, 51);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(270, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(196, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "FRAME INTERVAL IN MILLISECONDS";
      // 
      // FormFrameTime
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.ClientSize = new System.Drawing.Size(599, 82);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.ncFrameTime);
      this.Controls.Add(this.label1);
      this.Name = "FormFrameTime";
      this.ShowIcon = false;
      this.Text = "Frame Time";
      ((System.ComponentModel.ISupportInitialize)(this.ncFrameTime)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown ncFrameTime;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label2;
  }
}