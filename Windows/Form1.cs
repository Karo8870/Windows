namespace Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Convert.ToInt32(this.Location.X + 2), Convert.ToInt32(this.textBox1.Text + 2));
        }
    }
}
