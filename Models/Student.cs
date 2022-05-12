using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace oneToMeny.Models
{
    public class Student
    {
        [Key]
        public int StudentId {get;set;}
        [Required]
        public string Name {get;set;}

        public int TeacherId {get;set;}
        public Teacher MyTeacher {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}