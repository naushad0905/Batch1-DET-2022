﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Books
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public Author author { get; set; }  //containment

        public override string ToString()
        {
            return $"Book[name={Name},Author={this.author.ToString()},price={Price},qty={Qty}";
        }
    }

    public class TestBook
    {
        public static void Main()
        {
            Books b = new Books
            {
                Name = "Mastering C#",
                author = new Author { Name = "Mary", EMail = "mary.s", Gender = 'f' },
                Price = 500,
                Qty = 45
            };

            Author alex = new Author { Name = "Roja", EMail = "roja.p", Gender = 'f' };
            Books dummyBook = new Books { Name = "C#", author = alex, Price = 19, Qty = 99 };
        }
    }
}