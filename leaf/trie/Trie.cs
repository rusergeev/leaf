namespace leaf.trie
{
    public class Trie
    {
        private readonly Trie[] Next = new Trie[26];
        private string Word;

        public Trie GetNext(char c)
        {
            return Next[c - 'a'];
        }

        public Trie SetNext(char c)
        {
            if (GetNext(c) == null) Next[c-'a'] = new Trie();
            return GetNext(c);
        }
        public void Add(string word)
        {
            var node = this;
            foreach (var c in word) node = node.SetNext(c);
            node.Word = word;
        }
        public void Add(string[] words)
        {
            foreach (var word in words) Add(word);
        }

        public bool IsWord()
        {
            return Word != null;
        }

        public string GetWord()
        {
            return Word;
        }
    }
}
