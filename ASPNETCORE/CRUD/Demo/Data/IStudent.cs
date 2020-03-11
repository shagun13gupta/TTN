using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models;
using System.Data;

namespace Demo.Data
{
    public interface IStudent
    {
        DataSet GetData();
        DataSet GetDataId(int id);
        bool InsertData(Student student);
        bool UpdateData(int id,Student student);
        bool DeleteData(int id);

    }
}
