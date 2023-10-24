using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Category : Base
    {
        public Category(string name)
        {
            Name = name;
            Id = IdGenerator.GenerateId();
        }
    }
}