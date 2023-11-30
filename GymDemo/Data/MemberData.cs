using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymDemo.Models;
namespace GymDemo.Data
{
    public static class MemberData
    {
        public static List<Member> members = new List<Member>()
        {
            new Member(){ Name = "ahmed",Age = 1 },
            new Member(){ Name = "saaed",Age = 1 },
            new Member(){ Name = "ibrahim",Age = 1 },
            new Member(){ Name = "abdallah",Age = 1 }

        };
    }
}
