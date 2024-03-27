namespace banansplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intersection
            string[] intersectionSet1 = { "a", "b", "c", "d", "e" };
            string[] intersectionSet2 = { "h", "d", "w", "s", "a" };
            Console.WriteLine("Demonstration av Intersection:");
            Console.WriteLine("Set 1: " + string.Join(",", intersectionSet1));
            Console.WriteLine("Set 2: " + string.Join(",", intersectionSet2));
            List<string> intersectionResult = Intersection(intersectionSet1, intersectionSet2);
            Console.WriteLine("Resultat: " + string.Join(",", intersectionResult));
            Console.WriteLine();

        }

        public static List<string> Intersection(string[] set1, string[] set2)
        {
            List<string> result = new List<string>();
            
            return result;
        }
    }
}