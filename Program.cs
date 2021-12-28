using System;

namespace HashTableProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");
            Console.WriteLine();

            //UC1
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "to");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            //string hash5 = hash.Get("5");
            //Console.WriteLine("5th index value: " + hash5);
            ////hash.Remove("2");

            //string hash2 = hash.Get("2");
            //Console.WriteLine("2th index value: " + hash2);

            Console.WriteLine("Frequency of word \'to\' is : " + hash.GetFrequencyOfWords("to"));
            Console.WriteLine("Frequency of word \'be\' is : " + hash.GetFrequencyOfWords("be"));
            Console.WriteLine("Frequency of word \'or\' is : " + hash.GetFrequencyOfWords("or"));
            Console.WriteLine("Frequency of word \'not\' is : " + hash.GetFrequencyOfWords("not"));
        }
    }
}
