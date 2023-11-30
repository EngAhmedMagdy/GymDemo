using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
        public User(string name , string pass)
        {
            this.Username = name;
            this.Password = pass;
        }
    }
}
