using System.Reflection;

namespace AdventOfCode_LensLibrary_Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay15.txt");


            var ciphers = FileReader.ReadFromFile(FILE_PATH);

            var sum = ciphers.Select(x => x.Value).Sum();
            Console.WriteLine($"{sum}");
        }
    }
}