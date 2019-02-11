using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleAppDatabase
{
    public static class FacadeStudent
    {
        //Quick way to write a connection string
        private static string conn = "Server=tcp:easjtestserver.database.windows.net,1433;Initial Catalog=EASJTestDB;Persist Security Info=False;User ID=funkmaster;Password=Pass1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


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
                    while (reader.Read())
                    {
                        int studentid = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int phone = reader.GetInt32(2);

                        var Student = new Student(studentid, name, phone)
                        {
                            StudentId = studentid,
                            Name = name,
                            Phone = phone
                        };
                        result.Add(Student);
                    }
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine("ID: " + item.StudentId);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Phone number: " + item.Phone);
            }
            return result;
        }

        public static 
    }
}
