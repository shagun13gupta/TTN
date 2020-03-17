using Jwt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt.Data
{
    public class StudentClass : IStudent
    {
        public bool DeleteData(int id)
        {
            var context = new LoginDBContext();
            try
            {
                var std = context.Student.Where(s => s.Id == id).FirstOrDefault();
                context.Remove(std);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

         
        }

        public IEnumerable<Student> GetData()
        {

            var context = new LoginDBContext();
            return context.Student.ToList();

        }

        public Student GetDataById(int id)
        {
            var context = new LoginDBContext();
            return context.Student.Where(s => s.Id == id).FirstOrDefault();
        }

        public bool InsertData(Student student)
        {
            var context = new LoginDBContext();
            try
            {              
               
                context.Add(student);
                context.SaveChanges();
                return true;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateData(int id, Student student)
        {
            var context = new LoginDBContext();
            try
            {
                var std = context.Student.FirstOrDefault(s => s.Id == id);              
                std.Id = student.Id;
                std.Name = student.Name;
                std.Marks = student.Marks;
              
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
        }

        
    }
}
