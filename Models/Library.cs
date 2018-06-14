using System;
using System.Collections.Generic;

namespace console_library.Models
{
    public class Library
    {
        public string Name { get; set; }

        public string Location { get; set; }

        private List<Book> AvailableBooks { get; set; }

        private List<Book> CheckedOut { get; set; }


        //This method will print to the console the books currently in our book list
        public void PrintBooks()
        {
            Console.WriteLine(@"Please Choose From The Following Options
            ");
            Console.WriteLine("Available Books: ");
            for (int i = 0; i < AvailableBooks.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {AvailableBooks[i].Title} - {AvailableBooks[i].Author}");
            }

            Console.WriteLine(@"
Or type 'return' to return a book
");
        }

        public void PrintCheckedOut()
        {
            Console.WriteLine(@"Please Choose From The Following Options
            ");
            Console.WriteLine("Checked Out Books: ");
            for (int i = 0; i < CheckedOut.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {CheckedOut[i].Title} - {CheckedOut[i].Author}");
            }

            Console.WriteLine(@"
Or type 'available' to see available books
");
        }



        //This method is used to add a book to the Library
        public void AddBook(Book book)
        {
            AvailableBooks.Add(book);
        }

        //The checkout method removes a book from Books, marks it as no long available, and moves it to CheckedOut
        public void Checkout(string selection)
        {
            Book selectedBook = ValidateUserSelection(selection, AvailableBooks);

            if (selectedBook == null)
            {
                Console.Clear();
                System.Console.WriteLine(@"Invalid Selection
                        ");
                        return;
            }
            selectedBook.Available = false;
            CheckedOut.Add(selectedBook);
            AvailableBooks.Remove(selectedBook);
            Console.Clear();
            System.Console.WriteLine(@"Enjoy your Book!
                   ");
        }

        public void ReturnBook(string selection)
        {
            //checkout book
            Book selectedBook = ValidateUserSelection(selection, CheckedOut);

            if (selectedBook == null)
            {
                System.Console.WriteLine(@"Invalid Selection, please make a valid selection: 1
                ");
                return;
            }

            selectedBook.Available = true;
            AvailableBooks.Add(selectedBook);
            CheckedOut.Remove(selectedBook);
            Console.Clear();
            System.Console.WriteLine("Successfully Returned Book!");

        }




        private Book ValidateUserSelection(string selection, List<Book> bookList)
        {
            int bookIndex;
            bool valid = Int32.TryParse(selection, out bookIndex);
            if (!valid || bookIndex < 0 || bookIndex > bookList.Count)
            {
                return null;
            }
            return bookList[bookIndex-1];
        }


        //Library Constructor function
        public Library(string name, string location)
        {
            Name = name;
            Location = location;
            AvailableBooks = new List<Book>();
            CheckedOut = new List<Book>();
        }

    }
}