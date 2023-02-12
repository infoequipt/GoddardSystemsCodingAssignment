namespace ReturnMiddleCharacters
{
    // This method uses indexers
    internal class MiddleCharFinderMethod2 : IMiddleCharFinder
    {
        public string Find(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 3)
                return text;

            // Odd, so return middle character
            if ((text.Length % 2) == 1)
                return text[text.Length / 2].ToString();

            // Even, so middle 2 chars
            int first = (text.Length - 1) / 2;
            return text[first].ToString() + text[first+1].ToString();
        }
    }
}
