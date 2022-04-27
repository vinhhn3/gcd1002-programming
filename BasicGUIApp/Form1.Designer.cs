namespace BasicGUIApp
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
      this.labelFirstNumber = new System.Windows.Forms.Label();
      this.firstNumberInput = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.secondNumberInput = new System.Windows.Forms.TextBox();
      this.addButton = new System.Windows.Forms.Button();
      this.resultLabel = new System.Windows.Forms.Label();
      this.calculationResult = new System.Windows.Forms.Label();
      this.clearButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelFirstNumber
      // 
      this.labelFirstNumber.AutoSize = true;
      this.labelFirstNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.labelFirstNumber.Location = new System.Drawing.Point(105, 57);
      this.labelFirstNumber.Name = "labelFirstNumber";
      this.labelFirstNumber.Size = new System.Drawing.Size(160, 35);
      this.labelFirstNumber.TabIndex = 0;
      this.labelFirstNumber.Text = "First Number";
      // 
      // firstNumberInput
      // 
      this.firstNumberInput.Location = new System.Drawing.Point(105, 108);
      this.firstNumberInput.Name = "firstNumberInput";
      this.firstNumberInput.Size = new System.Drawing.Size(157, 27);
      this.firstNumberInput.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(322, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(196, 35);
      this.label1.TabIndex = 2;
      this.label1.Text = "Second Number";
      // 
      // secondNumberInput
      // 
      this.secondNumberInput.Location = new System.Drawing.Point(322, 108);
      this.secondNumberInput.Name = "secondNumberInput";
      this.secondNumberInput.Size = new System.Drawing.Size(196, 27);
      this.secondNumberInput.TabIndex = 3;
      // 
      // addButton
      // 
      this.addButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.addButton.Location = new System.Drawing.Point(259, 159);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(63, 52);
      this.addButton.TabIndex = 4;
      this.addButton.Text = "+";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // resultLabel
      // 
      this.resultLabel.AutoSize = true;
      this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.resultLabel.Location = new System.Drawing.Point(566, 57);
      this.resultLabel.Name = "resultLabel";
      this.resultLabel.Size = new System.Drawing.Size(139, 35);
      this.resultLabel.TabIndex = 5;
      this.resultLabel.Text = "Final Result";
      // 
      // calculationResult
      // 
      this.calculationResult.AutoSize = true;
      this.calculationResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.calculationResult.Location = new System.Drawing.Point(589, 108);
      this.calculationResult.Name = "calculationResult";
      this.calculationResult.Size = new System.Drawing.Size(80, 46);
      this.calculationResult.TabIndex = 6;
      this.calculationResult.Text = "N/A";
      // 
      // clearButton
      // 
      this.clearButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.clearButton.Location = new System.Drawing.Point(344, 159);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(94, 52);
      this.clearButton.TabIndex = 7;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.calculationResult);
      this.Controls.Add(this.resultLabel);
      this.Controls.Add(this.addButton);
      this.Controls.Add(this.secondNumberInput);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.firstNumberInput);
      this.Controls.Add(this.labelFirstNumber);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelFirstNumber;
    private System.Windows.Forms.TextBox firstNumberInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox secondNumberInput;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Label resultLabel;
    private System.Windows.Forms.Label calculationResult;
    private System.Windows.Forms.Button clearButton;
  }
}
