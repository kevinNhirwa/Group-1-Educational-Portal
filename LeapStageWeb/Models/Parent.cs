using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeapStageWeb.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        private Boolean isParent { get; set; }
    }
}
