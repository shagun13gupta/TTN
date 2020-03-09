using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CRUD.Models;
using System.Configuration;
using System.Data.SqlClient;


namespace CRUD.DATA
{
    public class StudentData
    {
        Models.Student student = new Models.Student();
        string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public DataSet GetData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("select * from student", sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }
        }

        public DataSet GetData(int id)
        {
            Student student = new Student();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("select * from student where ROLL_No=" + id + " ", sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }
        }

        public bool InsertDAta(Student student)
        {
            try
            {


                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into student(ROLL_NO,NAME,MARKS) values(@roll,@name,@marks)", sqlConnection);
                command.Parameters.AddWithValue("@roll", student.Roll_No);
                command.Parameters.AddWithValue("@name", student.NAME);
                command.Parameters.AddWithValue("@marks", student.MARKS);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {

            }
        }

        public bool UpdateData(int id, Student student)
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("update student set NAME=@name where ROLL_NO="+id, sqlConnection);
                command.Parameters.AddWithValue("@id", student.Roll_No);
                command.Parameters.AddWithValue("@name", student.NAME);
                //command.Parameters.AddWithValue("@marks",student.MARKS);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool DeleteData(int id)
        {
            try
            {
                Student student = new Student();
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("delete from student where Roll_No=" + id + " ", sqlConnection);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}