using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        public Student()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date),
         DisplayFormat(DataFormatString = "{0:dd/MM/yy}",
         ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; } // Navigation Property  

        //[NotMapped]
        //public string CourseName { get; set; }

    }

    public class Course
    {
        public Course()
        {

        }
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public List<Student> Students { get; set; } // Navigation property  
    }


}