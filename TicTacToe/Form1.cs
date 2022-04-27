using System;
using System.Windows.Forms;

namespace TicTacToe
{
  public enum GameStatus
  {
    OnGoing,
    PlayerAWin,
    PlayerBWin,
    Draw
  }

  public enum Turn
  {
    PlayerA,
    PlayerB
  }
  public partial class Form1 : Form
  {
    private Turn _turn = Turn.PlayerA;
    private GameStatus _gameStatus = GameStatus.OnGoing;
    public Form1()
    {
      InitializeComponent();
    }

    private void button00_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button00.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button00.Enabled = false;
        CheckWinner();
      }
      else
      {
        button00.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button00.Enabled = false;
        CheckWinner();
      }
    }

    private void SetLabelTurn(Turn nextTurn)
    {
      if (nextTurn == Turn.PlayerA)
      {
        turnStatus.Text = "Turn: Player A";
      }
      else
      {
        turnStatus.Text = "Turn: Player B";
      }
    }

    private void button01_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button01.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button01.Enabled = false;
        CheckWinner();

      }
      else
      {
        button01.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button01.Enabled = false;
        CheckWinner();

      }
    }

    private void button02_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button02.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button02.Enabled = false;
        CheckWinner();

      }
      else
      {
        button02.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button02.Enabled = false;
        CheckWinner();

      }
    }

    private void button10_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button10.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button10.Enabled = false;
        CheckWinner();

      }
      else
      {
        button10.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button10.Enabled = false;
        CheckWinner();

      }
    }

    private void button11_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button11.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button11.Enabled = false;
        CheckWinner();

      }
      else
      {
        button11.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button11.Enabled = false;
        CheckWinner();

      }
    }

    private void button12_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button12.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button12.Enabled = false;
        CheckWinner();

      }
      else
      {
        button12.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button12.Enabled = false;
        CheckWinner();

      }
    }

    private void button20_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button20.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button20.Enabled = false;
        CheckWinner();

      }
      else
      {
        button20.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button20.Enabled = false;
        CheckWinner();

      }
    }

    private void button21_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button21.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button21.Enabled = false;
        CheckWinner();

      }
      else
      {
        button21.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button21.Enabled = false;
        CheckWinner();

      }
    }

    private void button22_Click(object sender, EventArgs e)
    {
      if (_turn == Turn.PlayerA)
      {
        button22.Text = "X";
        _turn = Turn.PlayerB;
        SetLabelTurn(_turn);
        button22.Enabled = false;
        CheckWinner();

      }
      else
      {
        button22.Text = "O";
        _turn = Turn.PlayerA;
        SetLabelTurn(_turn);
        button22.Enabled = false;
        CheckWinner();

      }
    }

    private void CheckWinner()
    {
      // Check Player A Win
      if ((button00.Text == "X" && button01.Text == "X" && button02.Text == "X")
        || (button10.Text == "X" && button11.Text == "X" && button12.Text == "X")
        || (button20.Text == "X" && button21.Text == "X" && button22.Text == "X")
        || (button00.Text == "X" && button10.Text == "X" && button20.Text == "X")
        || (button01.Text == "X" && button11.Text == "X" && button21.Text == "X")
        || (button02.Text == "X" && button12.Text == "X" && button22.Text == "X")
        || (button00.Text == "X" && button11.Text == "X" && button22.Text == "X")
        || (button02.Text == "X" && button11.Text == "X" && button20.Text == "X")
        )
      {
        _gameStatus = GameStatus.PlayerAWin;
      }
      // Check PlayerB Win
      else if (
        (button00.Text == "O" && button01.Text == "O" && button02.Text == "O")
        || (button10.Text == "O" && button11.Text == "O" && button12.Text == "O")
        || (button20.Text == "O" && button21.Text == "O" && button22.Text == "O")
        || (button00.Text == "O" && button10.Text == "O" && button20.Text == "O")
        || (button01.Text == "O" && button11.Text == "O" && button21.Text == "O")
        || (button02.Text == "O" && button12.Text == "O" && button22.Text == "O")
        || (button00.Text == "O" && button11.Text == "O" && button22.Text == "O")
        || (button02.Text == "O" && button11.Text == "O" && button20.Text == "O")
        )
      {
        _gameStatus = GameStatus.PlayerBWin;
      }
      else if (button00.Text != ""
        && button01.Text != ""
        && button02.Text != ""
        && button10.Text != ""
        && button11.Text != ""
        && button12.Text != ""
        && button20.Text != ""
        && button21.Text != ""
        && button22.Text != ""
        )
      {
        _gameStatus = GameStatus.Draw;
      }
      else
      {
        _gameStatus |= GameStatus.OnGoing;
      }

      SetPlayersStatus(_gameStatus);
    }

    public void SetPlayersStatus(GameStatus status)
    {
      if (status == GameStatus.Draw)
      {
        statusPlayerA.Text = "Draw";
        statusPlayerB.Text = "Draw";
      }
      else if (status == GameStatus.PlayerAWin)
      {
        statusPlayerA.Text = "Win";
        statusPlayerB.Text = "Lose";
      }
      else if (status == GameStatus.PlayerBWin)
      {
        statusPlayerA.Text = "Lose";
        statusPlayerB.Text = "Win";
      }
      else
      {
        statusPlayerA.Text = "On Going";
        statusPlayerB.Text = "On Going";
      }
    }
  }
}
