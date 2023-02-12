namespace ReturnMiddleCharacters
{
    // This method uses substring
    internal class MiddleCharFinderMethod1 : IMiddleCharFinder
    {
        public string Find(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 3)
                return text;

            // Odd, so return middle character
            if ((text.Length % 2) == 1)
                return text.Substring(text.Length/2,1);

            // Even, so middle 2 chars
            return text.Substring((text.Length-1)/2,2);
        }
    }
}
