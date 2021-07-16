using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SF_13._6_2
{
    class TextWorker
    {
        public string[] EntireText;
        string path;
        public Dictionary<string, int> UniqueWordDictionary;

        public TextWorker( string path)
        {
            this.path = path;
        }

         public void GetTextToString()
        {
            string str = File.ReadAllText(path);
            char[] delimeters = { ' ', '\r', '\n', '–' };
            EntireText = str.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
        }


         public void PutUniqueWordsToDictionary(int cutter)
        {
            var UniqueWordlist = new HashSet<string>();
            UniqueWordDictionary = new Dictionary<string, int>();

            foreach (var word in EntireText)
                UniqueWordlist.Add(word);

            foreach (var word in UniqueWordlist)
            {
                if (word.Length > cutter)
                    UniqueWordDictionary.Add(word, 0);
            }
        }
    }
}
