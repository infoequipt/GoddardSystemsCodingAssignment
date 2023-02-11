namespace ReturnMiddleCharacters
{
    internal class MiddleCharFinderMethod4 : IMiddleCharFinder
    {
        public string Find(string text)
        {
            return text?.MidChars();
        }
    }
}
