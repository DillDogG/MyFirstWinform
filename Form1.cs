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
    private sectionGuessContext[] lastGuessesState1 = new sectionGuessContext[2];
    private int[] lastGuesses2 = new int[2];
    private sectionGuessContext[] lastGuessesState2 = new sectionGuessContext[2];
    private int[] lastGuesses3 = new int[2];
    private sectionGuessContext[] lastGuessesState3 = new sectionGuessContext[2];
    private const int guessMax = 5;

    // making all the states to save on memory
    private NoState noState = new NoState();
    private IncorrectState incorrectState = new IncorrectState();
    private CloseState closeState = new CloseState();
    private CorrectState correctState = new CorrectState();
    private WinState winState = new WinState();
    private OutOfGuessesState outOfGuessesState = new OutOfGuessesState();
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
        lastGuessesState1[0] = new sectionGuessContext();
        lastGuessesState1[1] = new sectionGuessContext();
        lastGuessesState1[0].setState(noState);
        lastGuessesState2[0] = new sectionGuessContext();
        lastGuessesState2[1] = new sectionGuessContext();
        lastGuessesState2[0].setState(noState);
        lastGuessesState3[0] = new sectionGuessContext();
        lastGuessesState3[1] = new sectionGuessContext();
        lastGuessesState3[0].setState(noState);
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
        lastGuessesState1[1].setState(check_guess(lastGuesses1[1], numberOne));

        lastGuesses1[0] = (int)numericUpDown1.Value;
        lastGuessesState1[0].setState(check_guess(numericUpDown1.Value, numberOne));

        History1.Text = lastGuesses1[0] + " was " + lastGuessesState1[0].request() + "\r\n" + lastGuesses1[1] + " was " + lastGuessesState1[1].request();

        if (guessCount1 >= guessMax)
        {
            lastGuessesState1[0].setState(outOfGuessesState);
            submit1.Enabled = false;
        }
        check_win();
        result1.Image = lastGuessesState1[0].getImage();
    }

    private void submit2_Click(object sender, EventArgs e)
    {
        guessCount2++;
        guessDisplay2.Text = "Guesses Left: " + (guessMax - guessCount2);

        lastGuesses2[1] = lastGuesses2[0];
        lastGuessesState2[1].setState(check_guess(lastGuesses2[1], numberTwo));

        lastGuesses2[0] = (int)numericUpDown2.Value;
        lastGuessesState2[0].setState(check_guess(numericUpDown2.Value, numberTwo));

        History2.Text = lastGuesses2[0] + " was " + lastGuessesState2[0].request() + "\r\n" + lastGuesses2[1] + " was " + lastGuessesState2[1].request();

        if (guessCount2 >= guessMax)
        {
            lastGuessesState2[0].setState(outOfGuessesState);
            submit2.Enabled = false;
        }
        check_win();
        result2.Image = lastGuessesState2[0].getImage();
    }

    private void submit3_Click(object sender, EventArgs e)
    {
        guessCount3++;
        guessDisplay3.Text = "Guesses Left: " + (guessMax - guessCount3);

        lastGuesses3[1] = lastGuesses3[0];
        lastGuessesState3[1].setState(check_guess(lastGuesses3[1], numberThree));

        lastGuesses3[0] = (int)numericUpDown3.Value;
        lastGuessesState3[0].setState(check_guess(numericUpDown3.Value, numberThree));

        History3.Text = lastGuesses3[0] + " was " + lastGuessesState3[0].request() + "\r\n" + lastGuesses3[1] + " was " + lastGuessesState3[1].request();

        if (guessCount3 >= guessMax)
        {
            lastGuessesState3[0].setState(outOfGuessesState);
            submit3.Enabled = false;
        }
        check_win();
        result3.Image = lastGuessesState3[0].getImage();
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
        lastGuessesState1[0].setState(noState);
        lastGuessesState1[1].setState(noState);
        lastGuesses2[0] = 0;
        lastGuesses2[1] = 0;
        lastGuessesState2[0].setState(noState);
        lastGuessesState2[1].setState(noState);
        lastGuesses3[0] = 0;
        lastGuesses3[1] = 0;
        lastGuessesState3[0].setState(noState);
        lastGuessesState3[1].setState(noState);
        submit1.Enabled = true;
        submit2.Enabled = true;
        submit3.Enabled = true;
    }

    private sectionGuessState check_guess(decimal check, int answer)
    {
        if (check == answer) { return correctState; }
        if (check + 1 == answer || check - 1 == answer) { return closeState; }
        return incorrectState;
    }

    private void check_win()
    {
        if (lastGuesses1[0] == numberOne && lastGuesses2[0] == numberTwo && lastGuesses3[0] == numberThree)
        {
            lastGuessesState1[0].setState(winState);
            lastGuessesState2[0].setState(winState);
            lastGuessesState3[0].setState(winState);
            submit1.Enabled = false;
            submit2.Enabled = false;
            submit3.Enabled = false;
            result1.Image = lastGuessesState1[0].getImage();
            result2.Image = lastGuessesState2[0].getImage();
            result3.Image = lastGuessesState3[0].getImage();
        }
    }

    private void exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
