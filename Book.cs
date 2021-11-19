namespace Composition
{
    public class Book
    {
        private string isbn {get;set;}
        private string title {get;set;}
        private Author author;
        public Book(string isbn, string title, Author author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }

        public void SetAuthor(Author author)
        {
            this.author = author;
        }

        public Author GetAuthor()
        {
            return author;
        }
        public override string ToString()
        {
            return "isbn = " + isbn + ", title = " + title + ", author: " + author.ToString();
        }
    }
}