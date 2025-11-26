using System;
using System.IO;
using System.Windows.Forms;

namespace TrieAutocompleteWinForm
{
    public partial class Form1 : Form
    {
        private Trie trie = new Trie();

        public Form1()
        {
            InitializeComponent();
            LoadDictionaryFromFile("dictionary.txt");

            txtInput.TextChanged += TxtInput_TextChanged;
            btnAddWord.Click += BtnAddWord_Click;
        }

        private void LoadDictionaryFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file từ điển!");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string word = parts[0].Trim().ToLower();
                    if (int.TryParse(parts[1].Trim(), out int freq))
                    {
                        trie.Insert(word, freq);
                    }
                }
            }
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            lstSuggestions.Items.Clear();
            string prefix = txtInput.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(prefix))
            {
                var suggestions = trie.GetWordsWithPrefix(prefix, 10);
                foreach (var s in suggestions)
                {
                    lstSuggestions.Items.Add(s.word);
                }
                lstSuggestions.Refresh(); // đảm bảo cập nhật ngay
            }
        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(word))
            {
                trie.Insert(word, 1);
                MessageBox.Show($"Đã thêm từ '{word}' vào từ điển!");

                // Ghi thêm vào file dictionary.txt
                using (StreamWriter sw = new StreamWriter("dictionary.txt", true))
                {
                    sw.WriteLine($"{word},1");
                }

                txtWord.Clear();
            }
        }
    }
}
