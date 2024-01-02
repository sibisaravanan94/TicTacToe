using System;

namespace TicTacToe.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }

        private User()
        {

        }

        public static UserBuilder GetUserBuilder()
        {
            return new UserBuilder();
        }
        public class UserBuilder
        {
            private User reference;
            public UserBuilder()
            {
                reference = new User();
            }

            public UserBuilder withName(string name)
            {
                reference.Name = name;
                return this;
            }

            public UserBuilder ofAge(int age)
            {
                reference.Age = age;
                return this;
            }

            public UserBuilder email(string email)
            {
                reference.Email = email;
                return this;
            }

            public UserBuilder photo(string photo)
            {
                reference.Photo = photo;
                return this;
            }

            public User build()
            {
                try
                {
                    User user = new User();
                    if (isValid(reference))
                    {
                        user.Name = reference.Name;
                        user.Age = reference.Age;
                        user.Email = reference.Email;
                        user.Photo = reference.Photo;
                    }
                    return user;
                }
                finally
                {
                    // Clear
                    reference = null;
                }
            }

            private bool isValid(User reference)
            {
                return true;
            }
        }
    }
}