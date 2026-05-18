namespace Class04.Extesion_Methods.Helpers
{
    public static class StringExtension
    {
        public static string Truncate(this string word, int length)
        {
            if (string.IsNullOrWhiteSpace(word) || word.Length <= length)
            {
                return word;
            }

            string result = word.Substring(0, length);

            return result + "...";



        }

        public static string Quoute(this string word)
        {
            return $@"""{word}""";
        }

    }
}
