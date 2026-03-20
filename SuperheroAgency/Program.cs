using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace SuperheroAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] intArray = { 1, 5, 2, 8, 6 };
            //Console.WriteLine(GetLast(intArray)); // 6

            //double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
            //Console.WriteLine(GetLast(doubleArray)); // 6.1111

            //string[] stringArray = { "hello", "world", "it's", "northcoders!" };
            //Console.WriteLine(GetLast(stringArray)); // "northcoders"

            //Stack<string> books = new Stack<string>();
            //books.Push("books1");
            //books.Push("books2");
            //books.Push("books3");
            //var x = books.Pop();
            //Console.WriteLine(x);
            //Console.WriteLine(books.Count);
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}

            //var myBooks = new CustomStack<string>();

            //myBooks.Push("Book 1");
            //myBooks.Push("Book 2");
            //myBooks.Push("Book 3");

            //Console.WriteLine(myBooks.Pop()); // Book 3


            //
         



            //
            var strandedCat = new RescueMission<IFly>("tree", 50);
            var bugInMyCode = new RescueMission<ITech>("zoom", 1000);
            var armWrestlingCompetition = new CombatMission<IStrength>("beach", 20);


            var reyzhen = new Mystic("Michael", "Reyzhen", 7000, Alignment.GOOD);
            strandedCat.HeroesDeployed.Add(reyzhen); // All good
            //Testing 
            foreach(var  hero in strandedCat.HeroesDeployed)
            {
                var xHero = (Superhero)hero;
                Console.WriteLine(xHero.Alias);
            }
            //var rich = new Gadgeteer("Rich", "The Developer", 33, Alignment.EVIL);
            //strandedCat.HeroesDeployed.Add(rich); // Should provide a compile time error
        }

        //public static T GetLast<T>(T[] array) => array[^1]; 
    }
}
