using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDemo.Models;
namespace GymDemo.Data
{
    public static class UserData
    {
        public static List<User> userlist = new List<User>()
        {
            new User("ahmed","123"),
            new User(){ Username = "ahmed",Password="123"},
            new User(){ Username = "ahmed",Password="123"},
            new User(){ Username = "ahmed",Password="123"}
        };
    }
}
