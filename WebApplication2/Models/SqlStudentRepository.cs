using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly AppContext _appContext;

        public SqlStudentRepository(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Student Add(Student student)
        {
          _appContext.students.Add(student);
            _appContext.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            Student student = _appContext.students.Find(id);
            if(student!=null)
            {
                _appContext.students.Remove(student);
                _appContext.SaveChanges();
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _appContext.students;
        }

        public Student GetStudent(int id)
        {
            return _appContext.students.Find(id);
        }

        public Student Update(Student _student)
        {
            var student = _appContext.students.Attach(_student);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appContext.SaveChanges();
            return _student;
        }
    }
}
