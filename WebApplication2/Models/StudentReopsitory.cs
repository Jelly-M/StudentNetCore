    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class StudentReopsitory : IStudentRepository
    {
        List<Student> students = null; 
        public StudentReopsitory()
        {
            students=  new List<Student>() {
            new Student() { Id = 1, Name = "张三", Email = "1111" },
            new Student() { Id = 2, Name = "李四", Email = "1111" },
            new Student() { Id = 3, Name = "xxx", Email = "1111" }
            };

        }

        public Student Add(Student student)
        {
            student.Id = students.Max(x => x.Id) + 1;
            students.Add(student);
            return student;
        }

        public Student Delete(int id)
        {
            Student student = students.FirstOrDefault(x => x.Id == id);
            if(student!=null)
            {
                students.Remove(student);
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(x=>x.Id==id);
        }

        public Student Update(Student student)
        {
            Student _student = students.FirstOrDefault(x => x.Id == student.Id);
            if (_student != null)
            {
                _student.Name = student.Name;
                _student.Email = student.Email;
            }
            return student;
        }
    }
}
