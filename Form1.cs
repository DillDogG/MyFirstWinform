using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstWinform;

public partial class Form1 : Form
{
    //public enum guessResult
    //{
    //    FAR,
    //    CLOSE,
    //    CORRECT
    //}
    Random rand = new Random();
    private int numberOne;
    private int numberTwo;
    private int numberThree;
    private int guessCount1;
    private int guessCount2;
    private int guessCount3;
    //private 
    private int[] lastGuesses1 = new int[2];
    private int[] lastGuesses2 = new int[2];
    private int[] lastGuesses3 = new int[2];
    private const int guessMax = 5;
    private StateKeeperImplementation stateKeeper = new StateKeeperImplementation();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        numberOne = rand.Next(10);
        numberTwo = rand.Next(10);
        numberThree = rand.Next(10);
        guessCount1 = 0;
        guessCount2 = 0;
        guessCount3 = 0;
        guessDisplay1.Text = "Guesses Left: " + guessMax;
        guessDisplay2.Text = "Guesses Left: " + guessMax;
        guessDisplay3.Text = "Guesses Left: " + guessMax;
        submit1.Enabled = true;
        submit2.Enabled = true;
        submit3.Enabled = true;
    }

    private void cheat_Click(object sender, EventArgs e)
    {
        answer.Text = numberOne + " " + numberTwo + " " + numberThree;
    }

    private void submit1_Click(object sender, EventArgs e)
    {
        guessCount1++;
        guessDisplay1.Text = "Guesses Left: " + (guessMax - guessCount1);

        lastGuesses1[1] = lastGuesses1[0];

        lastGuesses1[0] = (int)numericUpDown1.Value;
        check_guess(lastGuesses1[0], numberOne, 1);

        History1.Text = lastGuesses1[0] + " was " + stateKeeper.GetState(1) + "\r\n" + lastGuesses1[1] + " was " + stateKeeper.GetState(1, false);

        if (guessCount1 >= guessMax)
        {
            stateKeeper.SetLastGuessesState(false, true, 1);
            submit1.Enabled = false;
        }
        check_win();
        result1.Image = stateKeeper.GetImage(1);
    }

    private void submit2_Click(object sender, EventArgs e)
    {
        guessCount2++;
        guessDisplay2.Text = "Guesses Left: " + (guessMax - guessCount2);

        lastGuesses2[1] = lastGuesses2[0];

        lastGuesses2[0] = (int)numericUpDown2.Value;
        check_guess(lastGuesses2[0], numberTwo, 2);

        History2.Text = lastGuesses2[0] + " was " + stateKeeper.GetState(2) + "\r\n" + lastGuesses2[1] + " was " + stateKeeper.GetState(2, false);

        if (guessCount2 >= guessMax)
        {
            stateKeeper.SetLastGuessesState(false, true, 2);
            submit2.Enabled = false;
        }
        check_win();
        result2.Image = stateKeeper.GetImage(2);
    }

    private void submit3_Click(object sender, EventArgs e)
    {
        guessCount3++;
        guessDisplay3.Text = "Guesses Left: " + (guessMax - guessCount3);

        lastGuesses3[1] = lastGuesses3[0];

        lastGuesses3[0] = (int)numericUpDown3.Value;
        check_guess(lastGuesses3[0], numberThree, 3);

        History3.Text = lastGuesses3[0] + " was " + stateKeeper.GetState(3) + "\r\n" + lastGuesses3[1] + " was " + stateKeeper.GetState(3, false);

        if (guessCount3 >= guessMax)
        {
            stateKeeper.SetLastGuessesState(false, true, 3);
            submit3.Enabled = false;
        }
        check_win();
        result3.Image = stateKeeper.GetImage(3);
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        if (numericUpDown1.Value > 9) { numericUpDown1.Value = 0; }
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
        if (numericUpDown2.Value > 9) { numericUpDown2.Value = 0; }
    }

    private void numericUpDown3_ValueChanged(object sender, EventArgs e)
    {
        if (numericUpDown3.Value > 9) { numericUpDown3.Value = 0; }
    }

    private void reset_Click(object sender, EventArgs e)
    {
        numberOne = rand.Next(10);
        numberTwo = rand.Next(10);
        numberThree = rand.Next(10);
        guessCount1 = 0;
        guessCount2 = 0;
        guessCount3 = 0;
        guessDisplay1.Text = "Guesses Left: " + guessMax;
        guessDisplay2.Text = "Guesses Left: " + guessMax;
        guessDisplay3.Text = "Guesses Left: " + guessMax;
        History1.Text = "";
        History2.Text = "";
        History3.Text = "";
        answer.Text = "";
        lastGuesses1[0] = 0;
        lastGuesses1[1] = 0;
        lastGuesses2[0] = 0;
        lastGuesses2[1] = 0;
        lastGuesses3[0] = 0;
        lastGuesses3[1] = 0;
        stateKeeper.ResetKeeper();
        submit1.Enabled = true;
        submit2.Enabled = true;
        submit3.Enabled = true;
    }

    private void check_guess(decimal check, int answer, int section)
    {
        if (check == answer) stateKeeper.SetLastGuessesState(true, false, section);
        else if (check + 1 == answer || check - 1 == answer) stateKeeper.SetLastGuessesState(false, false, section, true);
        else stateKeeper.SetLastGuessesState(false, false, section);
    }

    private void check_win()
    {
        if (lastGuesses1[0] == numberOne && lastGuesses2[0] == numberTwo && lastGuesses3[0] == numberThree)
        {
            stateKeeper.SetLastGuessesState(true, true);
            submit1.Enabled = false;
            submit2.Enabled = false;
            submit3.Enabled = false;
            result1.Image = stateKeeper.GetImage(1);
            result2.Image = stateKeeper.GetImage(2);
            result3.Image = stateKeeper.GetImage(3);
        }
    }

    private void exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
