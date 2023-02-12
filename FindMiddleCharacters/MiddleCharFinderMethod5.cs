namespace ReturnMiddleCharacters
{
    internal class MiddleCharFinderMethod5 : IMiddleCharFinder
    {
        public string Find(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 3) return text;
            return (text.Length % 2) == 1 ? text.Substring(text.Length/2, 1) : text.Substring((text.Length-1)/2, 2);
        }
    }
}
