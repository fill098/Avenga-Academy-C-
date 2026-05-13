using System.Text.RegularExpressions;

namespace Class02.Homework.Models
{
    public class WebPage
    {
        public string  Url { get; set; }

        public string Html { get; set; }

        public WebPage(string url, string html)
        {
            Url = url;
            Html = html;
        }


        public bool Search (string word)
        {
            string plainText = Regex.Replace(Html, "<.*?>", "");

            if (plainText.ToUpper().Contains(word.ToUpper()))
            {
                return true;
                
            }

            return false;
        }
    }
}
