using Class02.Homework.Interface;

namespace Class02.Homework.Models
{
    public class Document : ISearchable
    {
        public string Title { get; set; }

        public string Content { get; set; }



        public Document(string title, string content)
        {
            Title = title;
            Content = content;
            
        }


        public bool Search(string word)
        {
            if (Content.ToUpper().Contains(word.ToUpper()))
            {
                return true;
            }
            return false;
        }



    }
}
