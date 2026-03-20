namespace SuperheroAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var list = new List<string>() { "hello", "world"};

            var dict = new Dictionary<int, string> // the key must be int, value must be string
            {
                {1, "a"},
                {2, "b"}
            };
        }
    }
}
