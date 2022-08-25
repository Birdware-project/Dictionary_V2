using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class About : Form
    {
        public string value { get; set; }
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form3 FC = new Form3();
            //FC.value = textBox1.Text;
            //if (FC.ShowDialog()==DialogResult.OK)
            //{
            //    this.textBox1.Text = FC.value;
            //}
        }
    }
}
