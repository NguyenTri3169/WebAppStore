using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Student")]
    public class Student
    {
        //constructor 
        //public Student(string name, string email, string password)
        //{
        //    Name = name;
        //    Email = email;
        //    Password = password;

        //}
        //public Student(string password)
        //{
        //    Password = password;
        //}

        [Column("StudentId")]
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!; // chỉ được gán không đc lấy { private get; set; }
        public bool Gender { get; set; } // chỉ được lấy ko đc gán { get; private set; }
        public DateTime DateOfBirth { get; set; }
    }
}
