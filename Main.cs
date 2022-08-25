using Dictionary.Models;
namespace Dictionary
{
    public partial class Main : Form
    {
        
        public List<DBModel> database_word2 = new List<DBModel>()
        {
            new DBModel() { word = "Apple",description="Apple ( n ) ផ្លែប៉ោម" },
            new DBModel() { word = "Banana",description="Banana ( n )  ផ្លែចេក" },
            new DBModel() { word = "Bat",description="Bat ( n )  សត្វប្រចៀវ " },
            new DBModel() { word = "Coconut",description="Coconut ( n )  ផ្លែដូង " },
            new DBModel() { word = "Durian",description="Durian ( n )  ផ្លែធូរ៉េន " },
            new DBModel() { word = "Elderberries",description="Elderberries ( n )  ផ្លែប៊ឺរី " },
            new DBModel() { word = "Figs",description="Figs ( n )  ផ្លែល្វា " },
            new DBModel() { word = "Grapes",description="Grapes ( n )  ផ្លែទំពាំងបាយជូ " },
            new DBModel() { word = "HoneyDewMelon",description="HoneyDewMelon ( n )  ផ្លែត្រសក " },
            new DBModel() { word = "JackFruit",description="JackFruit ( n )  ផ្លែខ្នុរ " },
            new DBModel() { word = "Longan",description="Longan ( n )  ផ្លែមៀន " },
            new DBModel() { word = "Mango",description="Mango ( n )  ផ្លែស្វាយ " },
            new DBModel() { word = "Orange",description="Orange ( n )  ផ្លែក្រុច " },
            new DBModel() { word = "Peaches",description="Peaches ( n )  ផ្លែប៉េះ " },
            new DBModel() { word = "Pineapple",description="Pineapple ( n )  ផ្លែម្នាស់ " },
        };
        public Main()
        {
            InitializeComponent();

            foreach (DBModel data in this.database_word2)
            {
                this.listbox_word.Items.Add(data.word);
            }
            this.listbox_word.Sorted = true;

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void database2(string keyword)
        {
            foreach(var data in this.database_word2)
            {
                if (keyword == data.word)
                {
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText(data.description);
                }
            }
        }

        private void SearchWord2(object sender, EventArgs e)
        {
            foreach (DBModel word_input in this.database_word2)
            {
                //
                if (word_input.word.ToLower().Contains(this.textBox_search.Text.ToLower()))
                {
                    foreach (DBModel data in this.database_word2)
                    {
                        if (!data.word.ToLower().Contains(this.textBox_search.Text.ToLower()))
                        {
                            this.listbox_word.Items.Remove(data.word);
                        }else if (!listbox_word.Items.Contains(data.word))
                        {
                            this.listbox_word.Items.Add(data.word);
                        }
                        
                    }
                    
                }
                
            }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void ToolStripMenuItemDoc_Click(object sender, EventArgs e)
        {
            Doc doc = new Doc();
            doc.ShowDialog();
        }

        private void InsertDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(database_word2);
            
            if (form3.ShowDialog() == DialogResult.OK)
            {
                List<DBModel> db = form3.DB2;
                this.listbox_word.Items.Clear();
                this.database_word2.Clear();

                foreach (var data in db)
                {
                    this.database_word2.Add(data);
                    this.listbox_word.Items.Add(data.word);
                }
            }
        }

        private void listbox_word_Click(object sender, EventArgs e)
        {
            string keyword = this.listbox_word.Text;
            database2(keyword);
        }
    }
}
