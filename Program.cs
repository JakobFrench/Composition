using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());
            Book myBook = new Book("12243 ", "My Book, Your Book ", myAuthor);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.GetAuthor().ToString());
            Book yourBook = new Book("4321 ", "The Phantom Book ", new Author("Jamie ", 'f', "jamie@mail.com"));
            myAuthor.SetEmail("jamie@crimson.ua.edu");
        }
    }
}
