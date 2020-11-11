using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class StudentReopsitory : IStudentRepository
    {
        List<Student> students = new List<Student>();
        public StudentReopsitory()
        {
            students.Add(new Student() { Id = 1, Name = "张三", Email = "1111" });
            students.Add(new Student() { Id = 2, Name = "张1三", Email = "1111" });

            students.Add(new Student() { Id = 3, Name = "张1三", Email = "1111" });

        }

        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(x=>x.Id==id);
        }
    }
}
