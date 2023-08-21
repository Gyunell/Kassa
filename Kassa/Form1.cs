namespace Kassa;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        button.Click += button_Click;
        button1.Click += button1_Click;
        button2.Click += button2_Click;
        button3.Click += button3_Click;
        button4.Click += button4_Click;
        button5.Click += button5_Click;
        button6.Click += button6_Click;
        button7.Click += button7_Click;
        button8.Click += button8_Click;
        button9.Click += button9_Click;
        button10.Click += button10_Click;
        button11.Click += button11_Click;
        button12.Click += button12_Click;
        button13.Click += button13_Click;
        button14.Click += button14_Click;
        
    }
    Product p = new Product();
    decimal result = 0;

    private void button14_Click(object sender, EventArgs e)
    {
        if (textbox1.Text == "200")
        {
            object[] list = new object[2] {p.Name = "Bread", p.Price = 1.00M};
            foreach (var item in list)
            {
                listbox1.Items.Add(item);
            }
            result = result + p.Price;
    
        }
        else if (textbox1.Text == "300")
        {
            object[] list = new object[2] {p.Name = "Lays", p.Price = 2.95M};
            foreach (var item in list)
            {
                listbox1.Items.Add(item);
            }
            result = result + p.Price;

        }
        else if (textbox1.Text == "400")
        {
            object[] list = new object[2] {p.Name = "Milk", p.Price = 3.55M};
            foreach (var item in list)
            {
                listbox1.Items.Add(item);
            }
            result = result + p.Price;

        }
        else 
        {
            MessageBox.Show("There is no code for this product");
        }
        label5.Text = result.ToString() + " " + "azn";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button2_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button3_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button4_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button5_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button6_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button7_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button8_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button9_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button13_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button12_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        textbox2.Text += b.Text;
    }
    private void button10_Click(object sender, EventArgs e)
    {
        textbox2.Clear();
    }
    private void button11_Click(object sender, EventArgs e)
    {
        decimal Paid = Convert.ToDecimal(textbox2.Text);
        if (Paid < result)
        {
            MessageBox.Show("The paid amount cannot be less than the total amount");
            label6.ForeColor = Color.Red;
            label6.Text = Paid.ToString() + " " + "azn";
        }
        else 
        {
            decimal returned = Paid - result;
            label7.Text = returned.ToString() + " " + "azn";
            label6.ForeColor = Color.White;
            label6.Text = Paid.ToString() + " " + "azn";
        }
    }
    private void button_Click(object sender, EventArgs e)
    {
       MessageBox.Show("200 : Bread \n 300 : Lays \n 400 : Milk");
    }
    

}
