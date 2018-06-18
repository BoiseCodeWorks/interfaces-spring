using System;
using console_library.Models;

namespace console_library
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialize Library
            Library myLibrary = new Library("CodeWorks Library", "Boise, ID");

            //Initialize Books
            Book WTSE = new Book("Shel Silverstein", "Where the Sidewalk Ends");
            Book TheHobbit = new Book("J.R.R. Tolkien", "The Hobbit");
            Book LWW = new Book("C.S. Lewis", "The Lion, The Witch, and the Wardrobe");
            Book HPSS = new Book("J.K. Rowling", "Harry Potter and the Sorcerer's Stone");
            Magazine time = new Magazine("Person of the Year", "Time");
            Newspaper IDs = new Newspaper("Sunday Edition", "Idaho Statesman");

            //Add Books to library
            myLibrary.AddBook(WTSE);
            myLibrary.AddBook(TheHobbit);
            myLibrary.AddBook(LWW);
            myLibrary.AddBook(HPSS);
            myLibrary.AddBook(time);

            //set starting menu
            Enum activeMenu = Menus.CheckoutBook;

            //Greet and print Book Selections
            bool inLibrary = true;
            Console.Clear();
            Console.WriteLine(@"Welcome to The Library!
            ");


            #region IN LIBRARY

            while (inLibrary)
            {
                //Print Active Menu
                switch (activeMenu)
                {
                    case Menus.CheckoutBook:
                        myLibrary.PrintBooks();
                        break;
                    case Menus.ReturnBook:
                        myLibrary.PrintCheckedOut();
                        break;
                }

                //Take in user selection
                string selection = Console.ReadLine();

                //Validate Selection
                switch (selection)
                {
                    case "return":
                        Console.Clear();
                        activeMenu = Menus.ReturnBook;
                        break;
                    case "available":
                        Console.Clear();
                        activeMenu = Menus.CheckoutBook;
                        break;
                    default:
                        if (activeMenu.Equals(Menus.CheckoutBook))
                        {
                            myLibrary.Checkout(selection);
                        }
                        else
                        {
                            myLibrary.ReturnBook(selection);
                        }
                        break;
                }

            }
            #endregion

        }
        public enum Menus
        {
            CheckoutBook,
            ReturnBook

        }
    }
}
