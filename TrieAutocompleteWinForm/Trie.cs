using System;
using System.Collections.Generic;

namespace TrieAutocompleteWinForm
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public bool IsWord = false;
        public int Frequency = 0;
    }

    public class Trie
    {
        private TrieNode root = new TrieNode();

        public void Insert(string word, int frequency = 1)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();
                node = node.Children[c];
            }
            node.IsWord = true;
            node.Frequency += frequency;
        }

        public List<(string word, int frequency)> GetWordsWithPrefix(string prefix, int N)
        {
            TrieNode node = root;
            foreach (char c in prefix)
            {
                if (!node.Children.ContainsKey(c))
                    return new List<(string, int)>();
                node = node.Children[c];
            }

            List<(string word, int frequency)> results = new List<(string, int)>();
            DFS(node, prefix, results);

            results.Sort((a, b) =>
            {
                int cmp = b.frequency.CompareTo(a.frequency);
                return cmp == 0 ? a.word.CompareTo(b.word) : cmp;
            });

            return results.GetRange(0, Math.Min(N, results.Count));
        }

        private void DFS(TrieNode node, string current, List<(string, int)> results)
        {
            if (node.IsWord)
                results.Add((current, node.Frequency));

            foreach (var kvp in node.Children)
            {
                DFS(kvp.Value, current + kvp.Key, results);
            }
        }
    }
}
