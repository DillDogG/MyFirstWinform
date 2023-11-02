namespace MyFirstWinform;

public partial class Form1 : Form
{
    Random rand = new Random();
    private int numberOne;
    private int numberTwo;
    private int numberThree;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        numberOne = rand.Next(10);
        numberTwo = rand.Next(10);
        numberThree = rand.Next(10);
    }

    private void cheat_Click(object sender, EventArgs e)
    {
        numericUpDown1.Value = numberOne;
        numericUpDown2.Value = numberTwo;
        numericUpDown3.Value = numberThree;
    }

    private void submit_Click(object sender, EventArgs e)
    {

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
    }
}
