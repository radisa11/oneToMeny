using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;



namespace oneToMeny.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Course {get;set;}
        public List<Student> MyStudent {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

}