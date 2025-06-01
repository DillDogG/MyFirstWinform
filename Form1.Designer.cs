namespace MyFirstWinform;

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
        numericUpDown1 = new NumericUpDown();
        numericUpDown2 = new NumericUpDown();
        numericUpDown3 = new NumericUpDown();
        cheat = new Button();
        submit1 = new Button();
        submit2 = new Button();
        submit3 = new Button();
        result1 = new PictureBox();
        result2 = new PictureBox();
        result3 = new PictureBox();
        reset = new Button();
        answer = new TextBox();
        History1 = new TextBox();
        History2 = new TextBox();
        History3 = new TextBox();
        guessDisplay1 = new TextBox();
        guessDisplay2 = new TextBox();
        guessDisplay3 = new TextBox();
        exit = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)result1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)result2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)result3).BeginInit();
        SuspendLayout();
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(100, 99);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(180, 31);
        numericUpDown1.TabIndex = 1;
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new Point(400, 99);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(180, 31);
        numericUpDown2.TabIndex = 2;
        numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
        // 
        // numericUpDown3
        // 
        numericUpDown3.Location = new Point(700, 99);
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new Size(180, 31);
        numericUpDown3.TabIndex = 3;
        numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
        // 
        // cheat
        // 
        cheat.Location = new Point(250, 432);
        cheat.Name = "cheat";
        cheat.Size = new Size(112, 34);
        cheat.TabIndex = 4;
        cheat.Text = "Cheat";
        cheat.UseVisualStyleBackColor = true;
        cheat.Click += cheat_Click;
        // 
        // submit1
        // 
        submit1.Location = new Point(121, 335);
        submit1.Name = "submit1";
        submit1.Size = new Size(112, 34);
        submit1.TabIndex = 5;
        submit1.Text = "Submit";
        submit1.UseVisualStyleBackColor = true;
        submit1.Click += submit1_Click;
        // 
        // submit2
        // 
        submit2.Location = new Point(419, 335);
        submit2.Name = "submit2";
        submit2.Size = new Size(112, 34);
        submit2.TabIndex = 16;
        submit2.Text = "Submit";
        submit2.UseVisualStyleBackColor = true;
        submit2.Click += submit2_Click;
        // 
        // submit3
        // 
        submit3.Location = new Point(720, 335);
        submit3.Name = "submit3";
        submit3.Size = new Size(112, 34);
        submit3.TabIndex = 17;
        submit3.Text = "Submit";
        submit3.UseVisualStyleBackColor = true;
        submit3.Click += submit3_Click;
        // 
        // result1
        // 
        result1.Image = Properties.Resources.Incorrect_Guess;
        result1.Location = new Point(100, 174);
        result1.Name = "result1";
        result1.Size = new Size(150, 75);
        result1.SizeMode = PictureBoxSizeMode.StretchImage;
        result1.TabIndex = 7;
        result1.TabStop = false;
        // 
        // result2
        // 
        result2.Image = Properties.Resources.Incorrect_Guess;
        result2.Location = new Point(400, 174);
        result2.Name = "result2";
        result2.Size = new Size(150, 75);
        result2.SizeMode = PictureBoxSizeMode.StretchImage;
        result2.TabIndex = 6;
        result2.TabStop = false;
        // 
        // result3
        // 
        result3.Image = Properties.Resources.Incorrect_Guess;
        result3.Location = new Point(700, 174);
        result3.Name = "result3";
        result3.Size = new Size(150, 75);
        result3.SizeMode = PictureBoxSizeMode.StretchImage;
        result3.TabIndex = 8;
        result3.TabStop = false;
        // 
        // reset
        // 
        reset.Location = new Point(550, 502);
        reset.Name = "reset";
        reset.Size = new Size(112, 34);
        reset.TabIndex = 9;
        reset.Text = "Reset";
        reset.UseVisualStyleBackColor = true;
        reset.Click += reset_Click;
        // 
        // answer
        // 
        answer.Location = new Point(250, 505);
        answer.Name = "answer";
        answer.ReadOnly = true;
        answer.Size = new Size(150, 31);
        answer.TabIndex = 10;
        // 
        // History1
        // 
        History1.Location = new Point(100, 255);
        History1.Multiline = true;
        History1.Name = "History1";
        History1.ReadOnly = true;
        History1.Size = new Size(180, 62);
        History1.TabIndex = 11;
        // 
        // History2
        // 
        History2.Location = new Point(400, 255);
        History2.Multiline = true;
        History2.Name = "History2";
        History2.ReadOnly = true;
        History2.Size = new Size(180, 62);
        History2.TabIndex = 12;
        // 
        // History3
        // 
        History3.Location = new Point(700, 255);
        History3.Multiline = true;
        History3.Name = "History3";
        History3.ReadOnly = true;
        History3.Size = new Size(180, 62);
        History3.TabIndex = 13;
        // 
        // guessDisplay1
        // 
        guessDisplay1.Location = new Point(100, 44);
        guessDisplay1.Name = "guessDisplay1";
        guessDisplay1.ReadOnly = true;
        guessDisplay1.Size = new Size(150, 31);
        guessDisplay1.TabIndex = 14;
        // 
        // guessDisplay2
        // 
        guessDisplay2.Location = new Point(400, 44);
        guessDisplay2.Name = "guessDisplay2";
        guessDisplay2.ReadOnly = true;
        guessDisplay2.Size = new Size(150, 31);
        guessDisplay2.TabIndex = 18;
        // 
        // guessDisplay3
        // 
        guessDisplay3.Location = new Point(700, 44);
        guessDisplay3.Name = "guessDisplay3";
        guessDisplay3.ReadOnly = true;
        guessDisplay3.Size = new Size(150, 31);
        guessDisplay3.TabIndex = 19;
        // 
        // exit
        // 
        exit.Location = new Point(400, 465);
        exit.Name = "exit";
        exit.Size = new Size(112, 34);
        exit.TabIndex = 15;
        exit.Text = "Exit";
        exit.UseVisualStyleBackColor = true;
        exit.Click += exit_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(994, 645);
        Controls.Add(exit);
        Controls.Add(guessDisplay3);
        Controls.Add(guessDisplay2);
        Controls.Add(guessDisplay1);
        Controls.Add(History3);
        Controls.Add(History2);
        Controls.Add(History1);
        Controls.Add(answer);
        Controls.Add(reset);
        Controls.Add(result3);
        Controls.Add(result2);
        Controls.Add(result1);
        Controls.Add(submit3);
        Controls.Add(submit2);
        Controls.Add(submit1);
        Controls.Add(cheat);
        Controls.Add(numericUpDown3);
        Controls.Add(numericUpDown2);
        Controls.Add(numericUpDown1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
        ((System.ComponentModel.ISupportInitialize)result1).EndInit();
        ((System.ComponentModel.ISupportInitialize)result2).EndInit();
        ((System.ComponentModel.ISupportInitialize)result3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown3;
    private Button cheat;
    private Button submit1;
    private Button submit2;
    private Button submit3;
    private PictureBox result1;
    private PictureBox result2;
    private PictureBox result3;
    private Button reset;
    private TextBox answer;
    private TextBox History1;
    private TextBox History2;
    private TextBox History3;
    private TextBox guessDisplay1;
    private TextBox guessDisplay2;
    private TextBox guessDisplay3;
    private Button exit;
}
