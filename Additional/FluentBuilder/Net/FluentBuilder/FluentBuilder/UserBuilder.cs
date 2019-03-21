using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class UserBuilder
    {
        private User user;
        public UserBuilder()
        {
            user = new User();
        }
        public UserBuilder SetName(string name)
        {
            user.Name = name;
            return this;
        }
        public UserBuilder SetCompany(string company)
        {
            user.Company = company;
            return this;
        }
        public UserBuilder SetAge(int age)
        {
            user.Age = age > 0 ? age : 0;
            return this;
        }
        public UserBuilder IsMarried
        {
            get
            {
                user.IsMarried = true;
                return this;
            }
        }
        public User Build()
        {
            return user;
        }

        //C#
        /// <summary>
        /// После модификаторов public static идет ключевое слово 
        /// explicit (если преобразование явное, то есть нужна операция приведения типов)
        ///  или implicit (если преобразование неявное). Затем идет ключевое слово operator
        /// и далее возвращаемый тип, в который надо преобразовать объект. 
        /// В скобках в качестве параметра передается объект, который надо преобразовать.
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator User(UserBuilder builder)
        {
            return builder.user;
        }
    }
}
