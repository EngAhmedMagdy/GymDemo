using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDemo.Models
{
    public class Member
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Age { get; set; }
        public bool Gender { get; set; }
        public DateTime Created { get; set; }
        public string Barcode { get; set; }
    }
}
