using System;
using System.Windows.Forms;

namespace BasicGUIApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      var firstNumberValue = int.Parse(firstNumberInput.Text);
      var secondNumberValue = int.Parse(secondNumberInput.Text);
      var result = firstNumberValue + secondNumberValue;
      calculationResult.Text = "" + result;
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      firstNumberInput.Text = String.Empty;
      secondNumberInput.Text = String.Empty;
      calculationResult.Text = "N/A";
    }
  }
}
