using វចនានុក្រម.Models;
namespace វចនានុក្រម
{
    public partial class Main : Form
    {
        
        public List<string> database_word = new List<string>()
            {
                "Apple",
                "Banana",
                "Bat",
                "Coconut",
                "Durian",
                "Elderberries",
                "Figs",
                "Grapes",
                "HoneyDewMelon",
                "JackFruit",
                "KiwiFruit",
                "Longan",
                "Mango",
                "Orange",
                "Peaches",
                "Pineapple"
            };
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


        private void database(string keyword)
        {
            switch (keyword)
            {
                case "Apple":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Apple ( n ) ផ្លែប៉ោម ");
                    break;
                case "Banana":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Banana ( n )  ផ្លែចេក ");
                    break;
                case "Bat":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Bat ( n )  សត្វប្រចៀវ ");
                    break;
                case "Coconut":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Coconut ( n )  ផ្លែដូង ");
                    break;
                case "Durian":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Durian ( n )  ផ្លែធូរ៉េន ");
                    break;
                case "Elderberries":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Elderberries ( n )  ផ្លែបីរី ");
                    break;
                case "Figs":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Figs ( n )  ផ្លែល្វា ");
                    break;
                case "Grapes":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Grapes ( n )  ផ្លែទំពាំងបាយជូរ ");
                    break;
                case "HoneyDewMelon":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("HoneyDewMelon ( n )  ផ្លែឪឡឹកទឹកឃ្មុំ ");
                    break;
                case "JackFruit":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("JackFruit ( n )  ផ្លែខ្នុល ");
                    break;
                case "KiwiFruit":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("KiwiFruit ( n )  ផ្លែគីវី ");
                    break;
                case "Longan":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Longan ( n )  ផ្លែមាន ");
                    break;
                case "Mango":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Mango ( n )  ផ្លែស្វាយ ");
                    break;
                case "Orange":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Orange ( n )  ផ្លែក្រូច ");
                    break;
                case "Peaches":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Peaches ( n )  ផ្លែប៉េស ");
                    break;
                case "Pineapple":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Pineapple ( n )  ផ្លែម្នាស់ ");
                    break;
            }
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

        private void btn_next_Click(object sender, EventArgs e)
        {
            string keyword = this.listbox_word.Text;
            database(keyword);
        }

        private void SearchWord(object sender, EventArgs e)
        {

            foreach (string word_input in this.database_word)
            {
                if (this.textBox_search.Text.ToLower() == word_input.ToLower())
                {
                    foreach (string data in this.database_word)
                    {
                        this.listbox_word.Items.Remove(data);
                    }
                    this.listbox_word.Items.Add(word_input);
                }
                else if (this.textBox_search.Text.ToLower() == "")
                {
                    foreach (string data in this.database_word)
                    {
                        this.listbox_word.Items.Remove(data);
                    }
                    foreach (string data in this.database_word)
                    {
                        this.listbox_word.Items.Add(data);
                    }
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
                //foreach (DBModel data in this.database_word2)
                //{
                //    this.database_word2.Remove(data);
                //    this.listbox_word.Items.Remove(data.word);
                //}
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
