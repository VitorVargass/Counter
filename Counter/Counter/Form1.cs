namespace Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(counter.Text);
            value++;
            counter.Text = value.ToString();

            Add.Text = "+";
        }
        private void counter_Click (object sender, EventArgs e)
        {

        }
        private void Sub_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(counter.Text);
            value--;
            counter.Text = value.ToString();
            if (value < 0)
            {
                counter.Text = "0"; 
            }
            Reset.Text = "RESET";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            counter.Text = "0";
            Add.Text = "Clique Aqui";
        }   
    }
}