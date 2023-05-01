using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeapStageWeb.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phoneNum { get; set; }
        private Boolean isStudent { get; set; }
    }
}
