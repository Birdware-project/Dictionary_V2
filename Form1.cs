namespace Dictionary
{
    public partial class Form1 : Form
    {
        int time2go = 0;
        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.time2go += 1;
            if (this.time2go==2)
            {
                this.Hide();
                timer1.Stop();
                Main FC = new Main();
                FC.ShowDialog();
                this.Close();
            }

        }
    }
}