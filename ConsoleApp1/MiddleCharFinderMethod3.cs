namespace ReturnMiddleCharacters
{
    // This method uses span
    internal class MiddleCharFinderMethod3 : IMiddleCharFinder
    {
        public string Find(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 3)
                return text;

            Span<char> buffer = new(text.ToCharArray());

            // Odd, so return middle character
            if ((text.Length % 2) == 1)
                return buffer[text.Length / 2].ToString();

            // Even, so middle 2 chars
            int first = (text.Length - 1) / 2;
            return buffer[first].ToString() + buffer[first + 1].ToString();
        }
    }
}
