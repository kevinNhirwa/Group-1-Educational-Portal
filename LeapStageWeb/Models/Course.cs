using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LeapStageWeb.Models
{
    public class Course
    {
        
        public int Id{ get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public string description { get; set; }
        public int teacherID { get; set; }
    }
}
