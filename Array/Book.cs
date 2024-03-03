using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }

        public int Price { get; set; }
    }

    public class  B1
    {
        static void Main(string[] args)
        {
            Book[] list = new Book[6]
            {
              new Book {Name = "C#", AuthorName = "Rushi", Price= 500},
              new Book {Name = "Python", AuthorName = "Rajesh", Price= 500},
              new Book {Name = "java", AuthorName = "Vishal", Price= 500},
              new Book {Name = "C++", AuthorName = "Dhananjay", Price= 500},
              new Book {Name = "C", AuthorName = "Kunal", Price= 500},
              new Book {Name = "SQL", AuthorName = "Suraj", Price= 500}

            };
            foreach (Book B in list)
            {
                Console.WriteLine($"{B.Name}{B.AuthorName} {B.Price}");

            }
        }
       


    }
}
