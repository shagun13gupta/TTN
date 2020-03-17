using Jwt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt.Data
{
    public interface IStudent
    {
        public IEnumerable<Student> GetData();        
        public Student GetDataById(int id);
        public bool InsertData(Student student);
        public bool UpdateData(int id,Student student);
        public bool DeleteData(int id);
        
    }
}
