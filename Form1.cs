namespace Lab11
{
    public partial class clearbtn : Form
    {
        public clearbtn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sumbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(operand1txtbox.Text);
                int number2 = int.Parse(operand2txtbox.Text);
                int sum = number1 + number2;

                resultbl.Text = sum.ToString();
            }
            catch (FormatException)
            {
                resultbl.Text = "That is not a number!";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            operand1txtbox.Text = "";
            operand2txtbox.Text = "";
            resultbl.Text = "";
        }

        private void operand1txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
