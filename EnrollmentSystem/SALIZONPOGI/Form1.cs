namespace SALIZONPOGI

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (user == "student" && pass == "123")
            {
                MessageBox.Show("Log In Successful");
                Form2 baho = new Form2();
                baho.Show();
                this.Hide();
            }
            else if (user == "admin" && pass == "123")
            {
                MessageBox.Show("Log In Successful");
                Form4 humot = new Form4();
                humot.Show();
                this.Hide();
            }
            else if (user == "faculty" && pass == "123")
            {
                MessageBox.Show("Log In Successful");
                Form3 ambot = new Form3();
                ambot.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if fields are empty
            if (textBox4.Text == "" ||
                textBox3.Text == "" ||
                textBox5.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if passwords match
            if (textBox3.Text != textBox5.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Demo success message
            MessageBox.Show("Account created successfully!");

            // Optional: clear textboxes
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
