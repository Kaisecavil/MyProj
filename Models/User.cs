using System;

namespace MyProj.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public UserRoles Role { get; set; }

        public User(int id, string name, int age, string email, UserRoles role)
        {
            try
            {
                Id = id;
                Name = name;
                Age = age;
                Email = email;
                Role = role;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public User(string name, int age, string email, UserRoles role = UserRoles.Reader)
        {
            try
            {
                Name = name;
                Age = age;
                Email = email;
                Role = role;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
