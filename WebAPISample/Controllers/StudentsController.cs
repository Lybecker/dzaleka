using Newtonsoft.Json;
using SharedClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPISample.Controllers
{
    public class StudentsController : ApiController
    {
        // Using below method to store Students in memory doesn't really work, 
        // as ASP.NET recreates a new instance of the StudentsController for each HTTP request
        // Therefore you should store your data in a database and not a simple file as showed here

        //List<Student> studentList = new List<Student>();

        //public StudentsController()
        //{
        //    var s1 = new Student();
        //    s1.Name = "Anders";
        //    s1.Age = 42;
        //    s1.Children.Add(new Child { Name = "Sophia" });
        //    s1.Children.Add(new Child { Name = "Victoria" });
        //    studentList.Add(s1);

        //    var s2 = new Student("Remy", 27);
        //    studentList.Add(s2);

        //    // Object initializers
        //    var s3 = new Student
        //    {
        //        Name = "Thomas",
        //        Age = 57
        //    };
        //    studentList.Add(s3);
        //}

        // GET api/values
        public IEnumerable<Student> Get()
        {
            return ReadStudentsFromFile();
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            // Input validation
            if (id < 0)
                return this.BadRequest("Hey! We do not accept negative numbers!");

            var list = ReadStudentsFromFile();

            // Make sure that the Student number exists
            if (list.Count < id)
                return this.Ok(list[id]);
            else
                return this.NotFound();
        }

        // POST api/values
        public void Post([FromBody]Student student)
        {
            // Input validation
            if (student == null)
                return;
            if (string.IsNullOrEmpty(student.Name))
                return;

            StoreNewStudent(student);
        }

        private void StoreNewStudent(Student newStudent)
        {
            // Read the entire file
            var students = ReadStudentsFromFile();
            // Add the new student
            students.Add(newStudent);
            // Write the entire file
            WriteStudentsToFile(students);
        }

        // The location of the file with all the Students in JSON format
        private const string FilePath = @"C:\Users\Student 09\Desktop\students.json";

        private List<Student> ReadStudentsFromFile()
        {
            // Make sure the Student JSON file exists before reading it
            if (!System.IO.File.Exists(FilePath))
            {
                return new List<Student>();
            }

            // Read the entire file
            var dataJson = System.IO.File.ReadAllText(FilePath);
            // Deserialize the JSON into Student objects
            return JsonConvert.DeserializeObject<List<Student>>(dataJson);
        }

        private void WriteStudentsToFile(List<Student> students)
        {
            var studentsData = JsonConvert.SerializeObject(students);

            System.IO.File.WriteAllText(FilePath, studentsData);
        }
    }
}