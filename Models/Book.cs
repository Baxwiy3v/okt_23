using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Book : Base
    {
        public string Author { get; private set; }
        public Category Category { get; private set; }

        public Book(string name, string author, Category category)
        {
            Id = IdGenerator.GenerateId();
            Name = name;
            Author = author;
            Category = category;
        }
    }
}