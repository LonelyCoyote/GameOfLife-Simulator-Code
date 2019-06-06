namespace GameOfLifeSim
{
  partial class FormRandomPatternGenerator
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
      this.ncLength = new System.Windows.Forms.NumericUpDown();
      this.ncWidth = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.ncPercentProbability = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.ncLength)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ncWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ncPercentProbability)).BeginInit();
      this.SuspendLayout();
      // 
      // ncLength
      // 
      this.ncLength.Location = new System.Drawing.Point(12, 12);
      this.ncLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.ncLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.ncLength.Name = "ncLength";
      this.ncLength.Size = new System.Drawing.Size(63, 20);
      this.ncLength.TabIndex = 0;
      this.ncLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // ncWidth
      // 
      this.ncWidth.Location = new System.Drawing.Point(12, 38);
      this.ncWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.ncWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.ncWidth.Name = "ncWidth";
      this.ncWidth.Size = new System.Drawing.Size(63, 20);
      this.ncWidth.TabIndex = 1;
      this.ncWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(81, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(659, 21);
      this.label1.TabIndex = 2;
      this.label1.Text = "ENTER THE LENGTH OF THE BOUNDING RECTANNGLE FOR THE PATTERN";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(81, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(648, 21);
      this.label2.TabIndex = 3;
      this.label2.Text = "ENTER THE WIDTH OF THE BOUNDING RECTANNGLE FOR THE PATTERN";
      // 
      // ncPercentProbability
      // 
      this.ncPercentProbability.Location = new System.Drawing.Point(12, 64);
      this.ncPercentProbability.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
      this.ncPercentProbability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.ncPercentProbability.Name = "ncPercentProbability";
      this.ncPercentProbability.Size = new System.Drawing.Size(63, 20);
      this.ncPercentProbability.TabIndex = 4;
      this.ncPercentProbability.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(81, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(516, 21);
      this.label3.TabIndex = 5;
      this.label3.Text = "ENTER THE PROBABILITY OF EACH CELL BEING ALIVE";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(679, 105);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 6;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.OnOK);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(598, 105);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // FormRandomPatternGenerator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Navy;
      this.ClientSize = new System.Drawing.Size(766, 142);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.ncPercentProbability);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ncWidth);
      this.Controls.Add(this.ncLength);
      this.Name = "FormRandomPatternGenerator";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Random Pattern Generator";
      ((System.ComponentModel.ISupportInitialize)(this.ncLength)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ncWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ncPercentProbability)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown ncLength;
    private System.Windows.Forms.NumericUpDown ncWidth;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown ncPercentProbability;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}