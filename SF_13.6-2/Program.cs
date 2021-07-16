using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SF_13._6_2
{
    class Program
    {
        static TextWorker TextWorker = new TextWorker(@"C:/Users/Savinykh/Desktop/С/Text1.txt");


        static void Main(string[] args)
        {

            TextWorker.GetTextToString();
            TextWorker.PutUniqueWordsToDictionary(3); // аргументом отсекаем предлоги, местоимения, наречия по длине слова (о - учитывает всё)
           
            CountWords();

            PrintResult(TextWorker.UniqueWordDictionary.OrderBy(x => -x.Value).ToDictionary(x => x.Key, x => x.Value));


            Console.ReadKey();
        }


        static void CountWords()
        {
            foreach (var word in TextWorker.EntireText)
                if (TextWorker.UniqueWordDictionary.ContainsKey(word)) TextWorker.UniqueWordDictionary[word]++;
        }


        static void PrintResult(Dictionary<string,int> FrequentWord)
        {
            int i = 0;
            foreach (var word in FrequentWord)
            {
                Console.WriteLine("Слово -{0}- встречается {1} раз", word.Key, word.Value);
                i++;
                if (i == 4) break;
            }
        }
    }
}
