namespace fukuv0516
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 20;
            label1.Text = "��";
            label1.ForeColor = Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "�����i��";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 20;
            label1.Text = "��";
            label1.ForeColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 20;
            label1.Text = "�E";
            label1.ForeColor = Color.Purple;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 20;
            label1.Text = "��";
            label1.ForeColor = Color.Orange;
        }
    }
}
