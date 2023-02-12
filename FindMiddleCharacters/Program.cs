using System.Diagnostics;

namespace ReturnMiddleCharacters
{
    /*
     Create a function that takes a string and returns the middle character(s).
     If the word's length is odd, return the middle character.
     If the word's length is even, return the middle two characters.
        Notes: All test cases contain a single word (as a string).
    */
    internal class Program
    {
        public static string[] TestCases =
        {
            null,
            "",
            "a",
            "ab",
            "abc",
            "abcd",
            "abcde",
            "abcdef",
            "abcdefg",
            "abcdefgh",
            "abcdefghi",
        };


        static void Main(string[] args)
        {
            foreach (string t in TestCases)
            {
                Console.WriteLine($"'{t}' middle '{MidChars(t)}'");
            }
        }

        public static string MidChars(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 3) return text;
            return (text.Length % 2) == 1 ? text.Substring(text.Length / 2, 1) : text.Substring((text.Length - 1) / 2, 2);
        }


#if false
        // Some experimentation I did.
        //
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Method 1 - Substring");
            IMiddleCharFinder finder = new MiddleCharFinderMethod1();
            stopwatch.Start();
            foreach (string t in TestCases)
            {
                Console.WriteLine($"'{t}' middle '{finder.Find(t)}'");
            }
            stopwatch.Stop();
            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds}ms, average {(float)stopwatch.ElapsedMilliseconds / TestCases.Length}");

            Console.WriteLine("Method 2 - Indexers");
            finder = new MiddleCharFinderMethod2();
            stopwatch.Start();
            foreach (string t in TestCases)
            {
                Console.WriteLine($"'{t}' middle '{finder.Find(t)}'");
            }
            stopwatch.Stop();
            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds}ms, average {(float)stopwatch.ElapsedMilliseconds / TestCases.Length}");

            Console.WriteLine("Method 3 - Span");
            finder = new MiddleCharFinderMethod3();
            stopwatch.Start();
            foreach (string t in TestCases)
            {
                Console.WriteLine($"'{t}' middle '{finder.Find(t)}'");
            }
            stopwatch.Stop();
            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds}ms, average {(float)stopwatch.ElapsedMilliseconds / TestCases.Length}");

            Console.WriteLine("Method 4 - Extension");
            finder = new MiddleCharFinderMethod4();
            stopwatch.Start();
            foreach (string t in TestCases)
            {
                Console.WriteLine($"'{t}' middle '{finder.Find(t)}'");
            }
            stopwatch.Stop();
            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds}ms, average {(float)stopwatch.ElapsedMilliseconds / TestCases.Length}");

            Console.WriteLine("Method 5 - Compact");
            finder = new MiddleCharFinderMethod5();
            stopwatch.Start();
            foreach (string t in TestCases)
            {
                Console.WriteLine($"'{t}' middle '{finder.Find(t)}'");
            }
            stopwatch.Stop();
            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds}ms, average {(float)stopwatch.ElapsedMilliseconds / TestCases.Length}");
        }
#endif

    }
}