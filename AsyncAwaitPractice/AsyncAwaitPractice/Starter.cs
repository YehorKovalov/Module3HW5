using System;
using System.Threading.Tasks;

namespace AsyncAwaitPractice
{
    public class Starter
    {
        private const string Path1 = "../../../Hello.txt";
        private const string Path2 = "../../../World.txt";

        public async Task Run()
        {
            var result = await GetAllTextFromFiles();
            Console.WriteLine(result);
        }

        public async Task<string> GetAllTextFromFiles()
        {
            var fileManager = new FileManager();
            var textFromFirstFile = await fileManager.ReadAllText(Path1);
            var textFromSecodFile = await fileManager.ReadAllText(Path2);
            return $"{textFromFirstFile} {textFromSecodFile}";
        }
    }
}