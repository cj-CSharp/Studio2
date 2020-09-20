using System;
using System.Collections.Generic;

namespace Studio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> letterDict = numOfEachChar(defaultString);
            foreach (KeyValuePair<char, int> letterValue in letterDict) 
            {
                Console.WriteLine(letterValue.Key + " : " + letterValue.Value);
            }
        }
        public static Dictionary<char, int> numOfEachChar (string s)
        {
            Dictionary<char, int> newDictionary = new Dictionary<char, int>();
            char[] charactersInString = s.ToCharArray();
            foreach(char letter in charactersInString)
            {
                if(newDictionary.ContainsKey(letter))
                {
                    newDictionary[letter]++;
                } else
                {
                    newDictionary.Add(letter, 1);
                }
            }
            return newDictionary;
        }
    }
}
