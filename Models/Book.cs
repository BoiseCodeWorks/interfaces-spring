using console_library.Interfaces;

namespace console_library.Models
{
  public class Book : ICheckout, IForSale
  {
    //Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }
    
    public decimal Price { get; set; }
    public string ISBN { get; set; }


    //Constructor Method
    public Book(string title, string author)
    {
      Title = title;
      Author = author;
      Available = true;
    }

    public bool isAvailable()
    {
      return Available;
    }

    public void Purchase()
    {
      System.Console.WriteLine("PURCHASED!");;
    }
  }
}