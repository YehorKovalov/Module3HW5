using System;
using System.Threading.Tasks;

namespace AsyncAwaitPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new Starter();
            starter?.Run();
        }
    }
}
