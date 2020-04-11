using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repository
{
    public interface IStudent
    {
        public IEnumerable<Students> GetStudents();      
        public Students GetStudentById(int id);
        public bool AddStudent(Students students);
        public bool EditStudent(Students students);
        public bool DeleteStudent(Students students);
    }
}
