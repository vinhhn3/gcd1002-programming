namespace TicTacToe
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelPlayerA = new System.Windows.Forms.Label();
      this.labelPlayerB = new System.Windows.Forms.Label();
      this.statusPlayerA = new System.Windows.Forms.Label();
      this.statusPlayerB = new System.Windows.Forms.Label();
      this.button00 = new System.Windows.Forms.Button();
      this.button01 = new System.Windows.Forms.Button();
      this.button02 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      this.button11 = new System.Windows.Forms.Button();
      this.button12 = new System.Windows.Forms.Button();
      this.button20 = new System.Windows.Forms.Button();
      this.button21 = new System.Windows.Forms.Button();
      this.button22 = new System.Windows.Forms.Button();
      this.turnStatus = new System.Windows.Forms.Label();
      this.resetButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelPlayerA
      // 
      this.labelPlayerA.AutoSize = true;
      this.labelPlayerA.Location = new System.Drawing.Point(127, 49);
      this.labelPlayerA.Name = "labelPlayerA";
      this.labelPlayerA.Size = new System.Drawing.Size(63, 20);
      this.labelPlayerA.TabIndex = 0;
      this.labelPlayerA.Text = "Player A";
      // 
      // labelPlayerB
      // 
      this.labelPlayerB.AutoSize = true;
      this.labelPlayerB.Location = new System.Drawing.Point(527, 49);
      this.labelPlayerB.Name = "labelPlayerB";
      this.labelPlayerB.Size = new System.Drawing.Size(62, 20);
      this.labelPlayerB.TabIndex = 1;
      this.labelPlayerB.Text = "Player B";
      // 
      // statusPlayerA
      // 
      this.statusPlayerA.AutoSize = true;
      this.statusPlayerA.Location = new System.Drawing.Point(140, 80);
      this.statusPlayerA.Name = "statusPlayerA";
      this.statusPlayerA.Size = new System.Drawing.Size(36, 20);
      this.statusPlayerA.TabIndex = 2;
      this.statusPlayerA.Text = "N/A";
      // 
      // statusPlayerB
      // 
      this.statusPlayerB.AutoSize = true;
      this.statusPlayerB.Location = new System.Drawing.Point(542, 80);
      this.statusPlayerB.Name = "statusPlayerB";
      this.statusPlayerB.Size = new System.Drawing.Size(36, 20);
      this.statusPlayerB.TabIndex = 3;
      this.statusPlayerB.Text = "N/A";
      // 
      // button00
      // 
      this.button00.Location = new System.Drawing.Point(191, 138);
      this.button00.Name = "button00";
      this.button00.Size = new System.Drawing.Size(94, 29);
      this.button00.TabIndex = 4;
      this.button00.UseVisualStyleBackColor = true;
      this.button00.Click += new System.EventHandler(this.button00_Click);
      // 
      // button01
      // 
      this.button01.Location = new System.Drawing.Point(330, 138);
      this.button01.Name = "button01";
      this.button01.Size = new System.Drawing.Size(94, 29);
      this.button01.TabIndex = 5;
      this.button01.UseVisualStyleBackColor = true;
      this.button01.Click += new System.EventHandler(this.button01_Click);
      // 
      // button02
      // 
      this.button02.Location = new System.Drawing.Point(470, 138);
      this.button02.Name = "button02";
      this.button02.Size = new System.Drawing.Size(94, 29);
      this.button02.TabIndex = 6;
      this.button02.UseVisualStyleBackColor = true;
      this.button02.Click += new System.EventHandler(this.button02_Click);
      // 
      // button10
      // 
      this.button10.Location = new System.Drawing.Point(191, 187);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(94, 29);
      this.button10.TabIndex = 7;
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new System.EventHandler(this.button10_Click);
      // 
      // button11
      // 
      this.button11.Location = new System.Drawing.Point(330, 187);
      this.button11.Name = "button11";
      this.button11.Size = new System.Drawing.Size(94, 29);
      this.button11.TabIndex = 8;
      this.button11.UseVisualStyleBackColor = true;
      this.button11.Click += new System.EventHandler(this.button11_Click);
      // 
      // button12
      // 
      this.button12.Location = new System.Drawing.Point(470, 187);
      this.button12.Name = "button12";
      this.button12.Size = new System.Drawing.Size(94, 29);
      this.button12.TabIndex = 9;
      this.button12.UseVisualStyleBackColor = true;
      this.button12.Click += new System.EventHandler(this.button12_Click);
      // 
      // button20
      // 
      this.button20.Location = new System.Drawing.Point(191, 235);
      this.button20.Name = "button20";
      this.button20.Size = new System.Drawing.Size(94, 29);
      this.button20.TabIndex = 10;
      this.button20.UseVisualStyleBackColor = true;
      this.button20.Click += new System.EventHandler(this.button20_Click);
      // 
      // button21
      // 
      this.button21.Location = new System.Drawing.Point(330, 235);
      this.button21.Name = "button21";
      this.button21.Size = new System.Drawing.Size(94, 29);
      this.button21.TabIndex = 11;
      this.button21.UseVisualStyleBackColor = true;
      this.button21.Click += new System.EventHandler(this.button21_Click);
      // 
      // button22
      // 
      this.button22.Location = new System.Drawing.Point(470, 235);
      this.button22.Name = "button22";
      this.button22.Size = new System.Drawing.Size(94, 29);
      this.button22.TabIndex = 12;
      this.button22.UseVisualStyleBackColor = true;
      this.button22.Click += new System.EventHandler(this.button22_Click);
      // 
      // turnStatus
      // 
      this.turnStatus.AutoSize = true;
      this.turnStatus.Location = new System.Drawing.Point(325, 298);
      this.turnStatus.Name = "turnStatus";
      this.turnStatus.Size = new System.Drawing.Size(99, 20);
      this.turnStatus.TabIndex = 13;
      this.turnStatus.Text = "Turn: Player A";
      // 
      // resetButton
      // 
      this.resetButton.Location = new System.Drawing.Point(330, 339);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(94, 29);
      this.resetButton.TabIndex = 14;
      this.resetButton.Text = "Reset";
      this.resetButton.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.resetButton);
      this.Controls.Add(this.turnStatus);
      this.Controls.Add(this.button22);
      this.Controls.Add(this.button21);
      this.Controls.Add(this.button20);
      this.Controls.Add(this.button12);
      this.Controls.Add(this.button11);
      this.Controls.Add(this.button10);
      this.Controls.Add(this.button02);
      this.Controls.Add(this.button01);
      this.Controls.Add(this.button00);
      this.Controls.Add(this.statusPlayerB);
      this.Controls.Add(this.statusPlayerA);
      this.Controls.Add(this.labelPlayerB);
      this.Controls.Add(this.labelPlayerA);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelPlayerA;
    private System.Windows.Forms.Label labelPlayerB;
    private System.Windows.Forms.Label statusPlayerA;
    private System.Windows.Forms.Label statusPlayerB;
    private System.Windows.Forms.Button button00;
    private System.Windows.Forms.Button button01;
    private System.Windows.Forms.Button button02;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button11;
    private System.Windows.Forms.Button button12;
    private System.Windows.Forms.Button button20;
    private System.Windows.Forms.Button button21;
    private System.Windows.Forms.Button button22;
    private System.Windows.Forms.Label turnStatus;
    private System.Windows.Forms.Button resetButton;
  }
}
