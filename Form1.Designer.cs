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
        submit = new Button();
        result2 = new PictureBox();
        result1 = new PictureBox();
        result3 = new PictureBox();
        reset = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)result2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)result1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)result3).BeginInit();
        SuspendLayout();
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(101, 99);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(180, 31);
        numericUpDown1.TabIndex = 1;
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new Point(382, 99);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(180, 31);
        numericUpDown2.TabIndex = 2;
        numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
        // 
        // numericUpDown3
        // 
        numericUpDown3.Location = new Point(665, 99);
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new Size(180, 31);
        numericUpDown3.TabIndex = 3;
        numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
        // 
        // cheat
        // 
        cheat.Location = new Point(281, 340);
        cheat.Name = "cheat";
        cheat.Size = new Size(112, 34);
        cheat.TabIndex = 4;
        cheat.Text = "Cheat";
        cheat.UseVisualStyleBackColor = true;
        cheat.Click += cheat_Click;
        // 
        // submit
        // 
        submit.Location = new Point(567, 340);
        submit.Name = "submit";
        submit.Size = new Size(112, 34);
        submit.TabIndex = 5;
        submit.Text = "Submit";
        submit.UseVisualStyleBackColor = true;
        submit.Click += submit_Click;
        // 
        // result2
        // 
        result2.Location = new Point(399, 174);
        result2.Name = "result2";
        result2.Size = new Size(150, 75);
        result2.TabIndex = 6;
        result2.TabStop = false;
        // 
        // result1
        // 
        result1.Location = new Point(116, 174);
        result1.Name = "result1";
        result1.Size = new Size(150, 75);
        result1.TabIndex = 7;
        result1.TabStop = false;
        // 
        // result3
        // 
        result3.Location = new Point(684, 174);
        result3.Name = "result3";
        result3.Size = new Size(150, 75);
        result3.TabIndex = 8;
        result3.TabStop = false;
        // 
        // button1
        // 
        reset.Location = new Point(419, 410);
        reset.Name = "reset";
        reset.Size = new Size(112, 34);
        reset.TabIndex = 9;
        reset.Text = "Reset";
        reset.UseVisualStyleBackColor = true;
        reset.Click += reset_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(994, 499);
        Controls.Add(reset);
        Controls.Add(result3);
        Controls.Add(result1);
        Controls.Add(result2);
        Controls.Add(submit);
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
        ((System.ComponentModel.ISupportInitialize)result2).EndInit();
        ((System.ComponentModel.ISupportInitialize)result1).EndInit();
        ((System.ComponentModel.ISupportInitialize)result3).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown3;
    private Button cheat;
    private Button submit;
    private PictureBox result2;
    private PictureBox result1;
    private PictureBox result3;
    private Button reset;
}
