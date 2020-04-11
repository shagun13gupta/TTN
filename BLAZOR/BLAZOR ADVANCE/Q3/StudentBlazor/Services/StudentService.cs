using Newtonsoft.Json;
using StudentApi.Models;
using StudentApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Services
{
    public class StudentService : IStudent
    {
        private readonly HttpClient _client;
        public StudentService(HttpClient client)
        {
            _client = client;
        }

        BlazorDbContext context = new BlazorDbContext();

        public IEnumerable<Students> GetStudents()
        {
            try
            {
                var jsonData = _client.GetStringAsync("Student/GetData");
                return JsonConvert.DeserializeObject<IEnumerable<Students>>(jsonData.Result);

            }
            catch (Exception ex)
            {
                //logogg
                throw ex;
            }
        }

        public bool AddStudent(Students students)
        {
            try
            {
                var jsonData = _client.PostAsync("Student/InsertData", getStringContentFromObject(students));
                return JsonConvert.DeserializeObject<bool>(jsonData.Result.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

        public bool DeleteStudent(Students students)
        {
            try
            {
               
                context.Students.Remove(students);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public Students GetStudentById(int id)
        //{
        //    try
        //    {
        //        var jsonData = _client.GetStringAsync("Student/GetDataById");
        //        return JsonConvert.DeserializeObject<Students>(jsonData.Result);

        //    }
        //    catch (Exception ex)
        //    {
        //        //logogg
        //        throw ex;
        //    }
        //}
        //public bool EditStudent(Students students)
        //{
        //    try
        //    {
        //        var jsonData = _client.PostAsync("Student/UpdateData", getStringContentFromObject(students));
        //        return JsonConvert.DeserializeObject<bool>(jsonData.Result.Content.ReadAsStringAsync().Result);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public Students GetStudentById(int id)
        {
            Students students = context.Students.FirstOrDefault(s => s.Id == id);
            return students;
        }

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



    }
}
