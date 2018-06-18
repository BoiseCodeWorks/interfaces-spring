namespace console_library.Models
{
    public class Newspaper
    {
        //Properties
        public string Publisher { get; set; }
        public string Title { get; set; }


        //Constructor Method
        public Newspaper(string title, string publisher) 
        {
            Title = title;
            Publisher = publisher;
        }
    }
}