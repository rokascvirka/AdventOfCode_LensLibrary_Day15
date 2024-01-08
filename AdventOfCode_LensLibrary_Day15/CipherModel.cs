using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_LensLibrary_Day15
{
    public class CipherModel
    {
        public string Cipher { get; set; }
        public char[] Chars { get; set; }

        public List<int> AscciValues { get; set; }
        public long Value { get; set; }

        public CipherModel(string cipher)
        {
            Cipher = cipher;
            Chars = Cipher.ToCharArray();
            AscciValues = ConvertToAsciiValues(Chars);
            Value = CountValue(AscciValues);
        }


        private List<int> ConvertToAsciiValues(char[] chars)
        {
            List<int> result = new List<int>(); 
            foreach(var symbol in chars)
            {
                result.Add(Convert.ToByte(symbol));
            }

            return result;
        }

        private long CountValue(List<int> asciiValues)
        {
            var startNum = 0;
            foreach(var asciiValue in asciiValues)
            {
                var start = startNum + asciiValue;
                var multiplied = start * 17;
                var remainder = multiplied % 256;
                startNum = remainder;
            }
            return startNum;
        }
    }
}
