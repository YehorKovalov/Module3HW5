using System.IO;
using System.Threading.Tasks;

namespace AsyncAwaitPractice
{
    public class FileManager
    {
        public async Task<string> ReadAllText(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            return await File.ReadAllTextAsync(path);
        }
    }
}
