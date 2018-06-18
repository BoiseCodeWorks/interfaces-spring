using console_library.Interfaces;

namespace console_library.Models
{
    public class Magazine : ICheckout
    {
        //Properties
        public string Title { get; set; }
        public string Publisher { get; set; }
        public bool Available { get; set; }
        public string ISBN { get; set; }


    //Constructor Method
    public Magazine(string title, string publisher) 
        {
            Title = title;
            Publisher = publisher;
            Available = true;
        }

    public bool isAvailable()
    {
      return Available;
    }
  }
}