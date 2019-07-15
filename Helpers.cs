using System;
using System.Collections.Generic;

namespace MusikiPlayer
{
    public static class Helpers
    {
        public static string FileNameCorrecter(string original)
        {
            string corrected = String.Empty;

            char[] chars = original.ToCharArray();

            List<int> illegalCharIndexes = new List<int>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '<')
                    illegalCharIndexes.Add(i);
                if (chars[i] == '>')
                    illegalCharIndexes.Add(i);
                if (chars[i] == ':')
                    illegalCharIndexes.Add(i);
                if (chars[i] == '"')
                    illegalCharIndexes.Add(i);
                if (chars[i] == '/')
                    illegalCharIndexes.Add(i);
                //if (chars[i] == '\')
                //    illegalCharIndexes.Add(i);
                if (chars[i] == '|')
                    illegalCharIndexes.Add(i);
                if (chars[i] == '?')
                    illegalCharIndexes.Add(i);
                if (chars[i] == '*')
                    illegalCharIndexes.Add(i);
            }

            foreach (var index in illegalCharIndexes)
            {
                chars[index] = ' ';
            }

            corrected = new string(chars);

            return corrected;
        }

    }
}
