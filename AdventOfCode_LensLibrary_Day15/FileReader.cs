using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_LensLibrary_Day15
{
    public static class FileReader
    {
        public static List<CipherModel> ReadFromFile(string filePath) 
        { 
            List<CipherModel> ciphers =  new List<CipherModel>();
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                var cipherList = streamReader.ReadToEnd().Split(",");

                foreach (var cipher in cipherList)
                {
                    ciphers.Add(new CipherModel(cipher));
                }
            }
            return ciphers;
        }
    }
}
