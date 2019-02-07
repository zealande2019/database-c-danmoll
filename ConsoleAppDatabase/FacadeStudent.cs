using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleAppDatabase
{
    public static class FacadeStudent
    {
        //Quick way to write a connection string
        private static string conn = "";


        public static List<Student> GetAllStudents()
        {
            string sql = "select id, name, phone from student";

            var result = new List<Student>();

            using (var databaseConnection = new SqlConnection(conn))
            {
                databaseConnection.Open();

                using (var selectCommand = new SqlCommand(sql, databaseConnection))
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int studentid = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int phone = reader.GetInt32(2);

                            var Student = new Student()
                            {
                                StudentId = studentid,
                                Name = name,
                                Phone = phone
                            };
                            result.Add(Student);
                        }
                    }
                }
            }
                return result;
        }
        
    }
}
