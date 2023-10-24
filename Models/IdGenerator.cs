using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class IdGenerator
    {
        private static int currentId = 1;

        public static int GenerateId()
        {
            return currentId++;
        }
    }
}