using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace SuperheroAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 1, 5, 2, 8, 6 };
            Console.WriteLine(GetLast(intArray)); // 6

            double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
            Console.WriteLine(GetLast(doubleArray)); // 6.1111

            string[] stringArray = { "hello", "world", "it's", "northcoders!" };
            Console.WriteLine(GetLast(stringArray)); // "northcoders"

            Stack<string> books = new Stack<string>();
            books.Push("books1");
            books.Push("books2");
            books.Push("books3");
            var x = books.Pop();
            Console.WriteLine(x);
            Console.WriteLine(books.Count);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public static T GetLast<T>(T[] array) => array[^1]; 
    }
}
