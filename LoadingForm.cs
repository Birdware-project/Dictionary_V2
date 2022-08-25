namespace Dictionary
{
    public partial class LoadingForm : Form
    {
        int time2go = 0;
        public LoadingForm()
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
                LoginForm FC = new LoginForm();
                FC.ShowDialog();
                this.Close();
            }

        }
    }
}