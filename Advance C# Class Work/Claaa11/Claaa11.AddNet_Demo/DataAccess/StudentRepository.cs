using Claaa11.AddNet_Demo.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Claaa11.AddNet_Demo.DataAccess
{
    internal class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            // Conection to database

            //SqlConnection sglConnection = new SqlConnection(_connectionString);
            //sglConnection.Open();


            //sglConnection.Close();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString)) 
            { 
                sqlConnection.Open();

                // Write the SQL query


                string quwey = @"
                            SELECT 
	                            s.ID,
	                            s.FirstName,
	                            s.LastName,
	                            s.DateOfBirth,
	                            s.EnrolledDate,
	                            s.Gender,
	                            s.NationalIdNumber,
	                            s.StudentCardNumber
                            FROM dbo.Student s";
                // Create sql command

                using SqlCommand command = new SqlCommand (quwey, sqlConnection);

                // Exicute the sql command

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Reaf the date from the executed query
                    while (reader.Read())
                    {
                        Student student = new Student()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                            DateOfBirth = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                            EnrollDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                            Gender = reader.IsDBNull(5) ? null : reader.GetString(5)[0],
                            NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetInt64(6),
                            StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetString(7),

                        };

                        students.Add(student);
                    }
                }

            }

            return students;
        }
    }
}
