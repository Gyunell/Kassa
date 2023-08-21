namespace Kassa;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(898, 543);
        this.Text = "Form1";
        this.BackColor = Color.DarkGreen;

        label1=new Label();
        label1.Location=new Point(40,30);
        label1.Name="label1";
        label1.ForeColor=Color.White;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Height = 30;
        label1.Text="Code";
        this.Controls.Add(label1);

        textbox1 = new TextBox();
        textbox1.Location = new Point(40,80);
        textbox1.Name = "textbox1";
        textbox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.Controls.Add(textbox1);

        button = new Button();
        button.Location = new Point(160,30);
        button.Name = "button1";
        button.Width = 140;
        button.Height = 40;
        button.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button.BackColor = Color.Gray;
        button.Text = "Code list";
        this.Controls.Add(button);

        button14 = new Button();
        button14.Location = new Point(160,76);
        button14.Name = "button14";
        button14.Width = 140;
        button14.Height = 40;
        button14.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button14.BackColor = Color.Gray;
        button14.Text = "Add";
        this.Controls.Add(button14);

        label2=new Label();
        label2.Location=new Point(600,25);
        label2.Name="label2";
        label2.ForeColor=Color.White;
        label2.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Height = 30;
        label2.Width = 140;
        label2.Text="Total amount";
        this.Controls.Add(label2);

        label3=new Label();
        label3.Location=new Point(600,65);
        label3.Name="label3";
        label3.ForeColor=Color.White;
        label3.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Height = 30;
        label3.Width = 140;
        label3.Text="Paid amount";
        this.Controls.Add(label3);
        
        label4=new Label();
        label4.Location=new Point(600,105);
        label4.Name="label4";
        label4.ForeColor=Color.White;
        label4.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Height = 30;
        label4.Width = 140;
        label4.Text="Returned amount";
        this.Controls.Add(label4);

        label5=new Label();
        label5.Location=new Point(770,25);
        label5.Name="label5";
        label5.ForeColor=Color.White;
        label5.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Height = 30;
        label5.Text="0.00 azn";
        this.Controls.Add(label5);

        label6=new Label();
        label6.Location=new Point(770,65);
        label6.Name="label6";
        label6.ForeColor=Color.White;
        label6.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        label6.Height = 30;
        label6.Text="0.00 azn";
        this.Controls.Add(label6);

        label7=new Label();
        label7.Location=new Point(770,105);
        label7.Name="label7";
        label7.ForeColor=Color.White;
        label7.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        label7.Height = 30;
        label7.Text="0.00 azn";
        this.Controls.Add(label7);

        textbox2 = new TextBox();
        textbox2.Location = new Point(70,210);
        textbox2.Name = "textbox2";
        textbox2.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold, GraphicsUnit.Point);
        textbox2.Width = 190;
        this.Controls.Add(textbox2);

        button1 = new Button();
        button1.Location = new Point(70,270);
        button1.Name = "button1";
        button1.Width = 50;
        button1.Height = 50;
        button1.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button1.BackColor = Color.Gray;
        button1.Text = "1";
        this.Controls.Add(button1);

        button2 = new Button();
        button2.Location = new Point(140,270);
        button2.Name = "button2";
        button2.Width = 50;
        button2.Height = 50;
        button2.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button2.BackColor = Color.Gray;
        button2.Text = "2";
        this.Controls.Add(button2);

        button3 = new Button();
        button3.Location = new Point(210,270);
        button3.Name = "button3";
        button3.Width = 50;
        button3.Height = 50;
        button3.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button3.BackColor = Color.Gray;
        button3.Text = "3";
        this.Controls.Add(button3);

        button4 = new Button();
        button4.Location = new Point(70,340);
        button4.Name = "button4";
        button4.Width = 50;
        button4.Height = 50;
        button4.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button4.BackColor = Color.Gray;
        button4.Text = "4";
        this.Controls.Add(button4);

        button5 = new Button();
        button5.Location = new Point(140,340);
        button5.Name = "button5";
        button5.Width = 50;
        button5.Height = 50;
        button5.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button5.BackColor = Color.Gray;
        button5.Text = "5";
        this.Controls.Add(button5);

        button6 = new Button();
        button6.Location = new Point(210,340);
        button6.Name = "button6";
        button6.Width = 50;
        button6.Height = 50;
        button6.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button6.BackColor = Color.Gray;
        button6.Text = "6";
        this.Controls.Add(button6);

        button7 = new Button();
        button7.Location = new Point(70,410);
        button7.Name = "button7";
        button7.Width = 50;
        button7.Height = 50;
        button7.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button7.BackColor = Color.Gray;
        button7.Text = "7";
        this.Controls.Add(button7);

        button8 = new Button();
        button8.Location = new Point(140,410);
        button8.Name = "button8";
        button8.Width = 50;
        button8.Height = 50;
        button8.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button8.BackColor = Color.Gray;
        button8.Text = "8";
        this.Controls.Add(button8);

        button9 = new Button();
        button9.Location = new Point(210,410);
        button9.Name = "button9";
        button9.Width = 50;
        button9.Height = 50;
        button9.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button9.BackColor = Color.Gray;
        button9.Text = "9";
        this.Controls.Add(button9);

        button10 = new Button();
        button10.Location = new Point(290,210);
        button10.Name = "button10";
        button10.Width = 50;
        button10.Height = 50;
        button10.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button10.BackColor = Color.Gray;
        button10.Text = "X";
        this.Controls.Add(button10);

        button11 = new Button();
        button11.Location = new Point(290,270);
        button11.Name = "button11";
        button11.Width = 50;
        button11.Height = 50;
        button11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        button11.BackColor = Color.Gray;
        button11.Text = "Enter";
        this.Controls.Add(button11);

        button12 = new Button();
        button12.Location = new Point(290,340);
        button12.Name = "button12";
        button12.Width = 50;
        button12.Height = 50;
        button12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        button12.BackColor = Color.Gray;
        button12.Text = ".";
        this.Controls.Add(button12);

        button13 = new Button();
        button13.Location = new Point(290,410);
        button13.Name = "button13";
        button13.Width = 50;
        button13.Height = 50;
        button13.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button13.BackColor = Color.Gray;
        button13.Text = "0";
        this.Controls.Add(button13);
        
        listbox1 = new ListBox();
        listbox1.Location = new Point(450,210);
        listbox1.Name = "listbox1";
        listbox1.Width = 410;
        listbox1.Height = 270;
        listbox1.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.Controls.Add(listbox1);

        label8=new Label();
        label8.Location=new Point(70,175);
        label8.Name="label8";
        label8.ForeColor=Color.White;
        label8.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold, GraphicsUnit.Point);
        label8.Height = 30;
        label8.Width = 185;
        label8.Text="Enter Paid Amount";
        this.Controls.Add(label8);
        
        groupbox1 = new GroupBox();
        groupbox1.Location = new Point(45,180);
        groupbox1.Name = "groupbox1";
        groupbox1.Width = 320;
        groupbox1.Height = 300;
        groupbox1.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.Controls.Add(groupbox1);
    }
    
    private Label label1;
    private TextBox textbox1;
    private Button button;
    private Button button14;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private TextBox textbox2;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Button button11;
    private Button button12;
    private Button button13;
    private ListBox listbox1;
    private GroupBox groupbox1;
    #endregion
}
