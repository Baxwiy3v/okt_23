using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Library : Base
    {
        public List<Book> _books;
        public Library(string name)
        {
            Name = name;
            Id = IdGenerator.GenerateId();
        }

        public void AddBook(Book book)
        {
            if (_books.Contains(book))
            {
                throw new InvalidOperationException("Bu kitab artıq kitabxanada var.");
            }

            _books.Add(book);
        }

        public void ListAllbooks()
        {
            Console.WriteLine($"Kitabxana: {Name}");
            foreach (var book in _books)
            {
                Console.WriteLine($"Kitab adı: {book.Name}, Müəllif: {book.Author}, Kateqoriya: {book.Category.Name}");
            }
        }
    }
}