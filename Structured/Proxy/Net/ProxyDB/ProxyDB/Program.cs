﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IBook book = new BookStoreProxy())
            {
                // читаем первую страницу
                Page page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
                // читаем вторую страницу
                Page page2 = book.GetPage(2);
                Console.WriteLine(page2.Text);
                // возвращаемся на первую страницу    
                page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
            }

            Console.Read();
        }
    }
}

