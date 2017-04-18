using System;
using System.Collections.Generic;
using System.Linq;

namespace Extend
{
    public static class Strings
    {
        public static bool IsEmpty(this string text) => string.IsNullOrEmpty(text);

        public static bool IsEmptyOrWhitespace(this string text) => string.IsNullOrWhiteSpace(text);

        public static float CalculateSimilarity(this string text, string input)
        {
            var cleanText = text.ToLowerInvariant();
            var cleanInput = input.ToLowerInvariant();

            var matches = 0;
            for (int i = 0; i < cleanText.Length; i++)
            {
                if (i >= cleanInput.Length)
                    break;

                if (cleanText[i] == cleanInput[i])
                    matches++;
            }

            return (float)matches / cleanText.Length;
        }
    }
}