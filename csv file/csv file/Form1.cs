namespace csv_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string family = textBox2.Text;
            string phone = textBox3.Text;
            string final = name + '-' + family + '-' + phone + '\n';
            var fs = File.Create("data.csv");
            fs.Close();
            File.WriteAllText("data.csv", final);
            File.AppendAllText("data.csv",final);
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
    }
}
