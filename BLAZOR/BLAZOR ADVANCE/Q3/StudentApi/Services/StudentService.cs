using Microsoft.EntityFrameworkCore;
using StudentApi.Models;
using StudentApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Services
{
    public class StudentService : IStudent
    {
        BlazorDbContext context = new BlazorDbContext();

        public bool AddStudent(Students students)
        {
            try
            {
                context.Students.Add(students);
                context.SaveChanges();
                return true; 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteStudent(int id)
        {
            try
            {
                Students students;
                students=context.Students.Where(x => x.Id == id).FirstOrDefault();
                context.Students.Remove(students);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //public bool EditStudent(Students students)
        //{
        //    try
        //    {
        //        context.Entry(students).State = EntityState.Modified;
        //        context.SaveChanges();
        //        return true;

        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public bool EditStudent(Students students)
        {
            try
            {
                context.Students.Update(students);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Students> GetStudents()
        {
            try
            {
                return context.Students.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public Students GetStudentById(int id)
        {
            Students students = context.Students.FirstOrDefault(s => s.Id == id);
            return students;
        }
    }
}
