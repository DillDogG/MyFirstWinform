using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstWinform;

public partial class Form1 : Form
{
    public enum guessResult
    {
        FAR,
        CLOSE,
        CORRECT
    }
    Random rand = new Random();
    private int numberOne;
    private int numberTwo;
    private int numberThree;
    private int guessCount;
    private int[,] lastGuesses1 = new int[2, 2];
    private int[,] lastGuesses2 = new int[2, 2];
    private int[,] lastGuesses3 = new int[2, 2];
    private const int guessMax = 5;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        numberOne = rand.Next(10);
        numberTwo = rand.Next(10);
        numberThree = rand.Next(10);
        guessCount = 0;
        guessDisplay.Text = "Guesses Left: " + guessMax;
        submit.Enabled = true;
    }

    private void cheat_Click(object sender, EventArgs e)
    {
        answer.Text = numberOne + " " + numberTwo + " " + numberThree;
    }

    private void submit_Click(object sender, EventArgs e)
    {
        guessCount++;
        guessDisplay.Text = "Guesses Left: " + (guessMax - guessCount);

        lastGuesses1[1, 0] = lastGuesses1[0, 0];
        lastGuesses1[1, 1] = lastGuesses1[0, 1];
        lastGuesses2[1, 0] = lastGuesses2[0, 0];
        lastGuesses2[1, 1] = lastGuesses2[0, 1];
        lastGuesses3[1, 0] = lastGuesses3[0, 0];
        lastGuesses3[1, 1] = lastGuesses3[0, 1];

        lastGuesses1[0, 0] = (int)numericUpDown1.Value;
        lastGuesses1[0, 1] = (int)check_guess(numericUpDown1.Value, numberOne);
        lastGuesses2[0, 0] = (int)numericUpDown2.Value;
        lastGuesses2[0, 1] = (int)check_guess(numericUpDown2.Value, numberTwo);
        lastGuesses3[0, 0] = (int)numericUpDown3.Value;
        lastGuesses3[0, 1] = (int)check_guess(numericUpDown3.Value, numberThree);

        History1.Text = lastGuesses1[0, 0] + " was " + (guessResult)lastGuesses1[0, 1] + "\r\n" + lastGuesses1[1, 0] + " was " + (guessResult)lastGuesses1[1, 1];
        History2.Text = lastGuesses2[0, 0] + " was " + (guessResult)lastGuesses2[0, 1] + "\r\n" + lastGuesses2[1, 0] + " was " + (guessResult)lastGuesses2[1, 1];
        History3.Text = lastGuesses3[0, 0] + " was " + (guessResult)lastGuesses3[0, 1] + "\r\n" + lastGuesses3[1, 0] + " was " + (guessResult)lastGuesses3[1, 1];

        if (lastGuesses1[0, 1] == 0) { result1.Image = Properties.Resources.Incorrect_Guess; }
        if (lastGuesses1[0, 1] == 1) { result1.Image = Properties.Resources.Close_Guess; }
        if (lastGuesses1[0, 1] == 2) { result1.Image = Properties.Resources.Correct_Guess; }
        if (lastGuesses2[0, 1] == 0) { result2.Image = Properties.Resources.Incorrect_Guess; }
        if (lastGuesses2[0, 1] == 1) { result2.Image = Properties.Resources.Close_Guess; }
        if (lastGuesses2[0, 1] == 2) { result2.Image = Properties.Resources.Correct_Guess; }
        if (lastGuesses3[0, 1] == 0) { result3.Image = Properties.Resources.Incorrect_Guess; }
        if (lastGuesses3[0, 1] == 1) { result3.Image = Properties.Resources.Close_Guess; }
        if (lastGuesses3[0, 1] == 2) { result3.Image = Properties.Resources.Correct_Guess; }

        if (lastGuesses1[0, 0] == numberOne && lastGuesses2[0, 0] == numberTwo && lastGuesses3[0, 0] == numberThree)
        {
            result1.Image = Properties.Resources.Player_Wins;
            result2.Image = Properties.Resources.Player_Wins;
            result3.Image = Properties.Resources.Player_Wins;
            submit.Enabled = false;
        }
        else if (guessCount >= guessMax)
        {
            result1.Image = Properties.Resources.Player_Loses;
            result2.Image = Properties.Resources.Player_Loses;
            result3.Image = Properties.Resources.Player_Loses;
            submit.Enabled = false;
        }
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
        guessCount = 0;
        guessDisplay.Text = "Guesses Left: " + guessMax;
        History1.Text = "";
        History2.Text = "";
        History3.Text = "";
        answer.Text = "";
        lastGuesses1[0, 0] = 0;
        lastGuesses1[1, 0] = 0;
        lastGuesses1[0, 1] = 0;
        lastGuesses1[1, 1] = 0;
        lastGuesses2[0, 0] = 0;
        lastGuesses2[1, 0] = 0;
        lastGuesses2[0, 1] = 0;
        lastGuesses2[1, 1] = 0;
        lastGuesses3[0, 0] = 0;
        lastGuesses3[1, 0] = 0;
        lastGuesses3[0, 1] = 0;
        lastGuesses3[1, 1] = 0;
        submit.Enabled = true;
    }

    private guessResult check_guess(decimal check, int answer)
    {
        if (check == answer) { return guessResult.CORRECT; }
        if (check + 1 == answer || check - 1 == answer) { return guessResult.CLOSE; }
        return guessResult.FAR;
    }

    private void exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
