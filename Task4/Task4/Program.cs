using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private bool IsAvailble { get; set; } 

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailble = true;
        }
        public void BorrowBook()
        {
             if(IsAvailble)
            {
                IsAvailble = false;
                Console.WriteLine($"You are Borrow the Book: Author: {Author} , Title: {Title}");
            }
            else
            {
                Console.WriteLine("This book already Borrow: ");
            }
        }
        public void ReturnBook()
        {

            if(IsAvailble == false)
            {
                IsAvailble = true;
                Console.WriteLine($"You are Return the Book: Author: {Author} , Title: {Title}");
            }
            else
            {
                Console.WriteLine("This book is not Borrow it is avalible:");
            }
        }
        public void Display()
        {
          if (IsAvailble)
            {
                Console.WriteLine($"Book-> {Title} by {Author} is avalible:");
            }
            else
            {
                Console.WriteLine($"Book-> {Title} by {Author} is not avalible:");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];
            books[0] = new Book("Shun U Katun", "Hovhannes Tumanyan");
            books[1] = new Book("Gevorg Marzpetuni" , "Muracan");
            books[2] = new Book( "Spanvac Axavni", "Nar Dos");
            Console.WriteLine("This Is All Our Avalibel Books Righte Now\n");
            foreach(Book book in books)
            {
                book.Display();
            }
            Console.WriteLine();
            bool x = true;
            while (x)
            {
                Console.WriteLine("Please chuse\n for BorrowBook 1\n for  ReturnBook 2\n for Display availble book 3\n for Exit 4\n");
                string chose = Console.ReadLine();
                switch( chose )
                {
                    case "1":
                        Console.WriteLine("Please enther the book name:");
                        string name = Console.ReadLine();
                        for(int i = 0; i < books.Length; i++)
                        {
                            if (books[i].Title.Equals(name, StringComparison.OrdinalIgnoreCase))
                            {
                                books[i].BorrowBook();
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Please enther the book name:");
                        name = Console.ReadLine();
                        for (int i = 0;i < books.Length; i++)
                        {
                            if (books[i].Title.Equals(name, StringComparison.OrdinalIgnoreCase))
                            {
                                books[i].ReturnBook();
                            }
                        }
                        break;
                    case "3":
                        for (int i = 0; i <= books.Length; i++)
                        {
                            books[i].Display();
                        }
                        break;
                    case "4":
                        Console.WriteLine("Exit:");
                        x = false;
                        break;
                     default:
                        Console.WriteLine("You enther the envalid chose:");
                        break;
                }
            }
            Console.WriteLine("Thank you for Using our Book Libery:");
             
        }
    }
}
