using System;
using System.Windows.Forms;

namespace TryingGame
{
    public partial class Form1 : Form
    {

        string[] word =
        {
            "слово", "исрпо", "блендер", "кот", "ракета", "окно", "дом", "лом", "kotlin", "android", "кликер"
        };

        Random rand = new Random();

        private int correct = 0;
        private int wrong = 0;

        public void NewWord()
        {
            string words = word[rand.Next(word.Length)];
            label4.Text = words;
            textBox1.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            NewWord();
            textBox1.Focus();
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userWord = textBox1.Text.Trim().ToLower();
                string check = label4.Text.Trim().ToLower();

                if (userWord == check)
                {
                    correct++;
                    label1.Text = $"Правильных слов: {correct}";
                }
                else
                {
                    wrong++;
                    label2.Text = $"Неправильных слов: {wrong}";
                }
                NewWord();
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
