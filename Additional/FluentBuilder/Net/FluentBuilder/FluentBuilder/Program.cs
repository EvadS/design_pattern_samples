using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new UserBuilder().SetName("Tom").SetCompany("Microsoft").SetAge(23).Build();
            User alice = User.CreateBuilder().SetName("Alice").IsMarried.SetAge(25).Build();

            User tom2 = new UserBuilder().SetName("Tom").SetCompany("Microsoft").SetAge(23);
            User alice2 = User.CreateBuilder().SetName("Alice").IsMarried.SetAge(25);

        }
    }
}
