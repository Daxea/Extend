using System;
using System.Collections.Generic;
using System.Linq;

namespace Extend
{
    public static class Randoms
    {
        private const string Consonants = "bcdfghjklmnpqrstvwxyz";
        private const string Vowels = "aeiouy";

        public static T From<T>(this Random random, params T[] array) => array[random.Next(0, array.Length)];

        public static string Word(this Random random, int minLength, int maxLength)
        {
            if (minLength > maxLength || maxLength < 2)
                return string.Empty;

            var positionA = (int)'a';
            var positionB = (int)'z';

            var length = random.Next(minLength, maxLength + 1);
            var word = string.Empty;
            for (int i = 0; i < length; i++)
                word += (char)random.Next(positionA, positionB);

            return word;
        }

        public static string Word(this Random random, string format)
        {
            if (format.IsEmptyOrWhitespace())
                return string.Empty;

            var word = string.Empty;
            foreach (var character in format)
            {
                if (character == 'C')
                    word += random.Consonant().ToUpperInvariant();
                else if (character == 'c')
                    word += random.Consonant();
                else if (character == 'V')
                    word += random.Vowel().ToUpperInvariant();
                else if (character == 'v')
                    word += random.Vowel();
                else
                    word += character;
            }

            return word;
        }

        public static string Consonant(this Random random) => Consonants[random.Next(Consonants.Length)].ToString();
        public static string Vowel(this Random random) => Vowels[random.Next(Vowels.Length)].ToString();
    }
}