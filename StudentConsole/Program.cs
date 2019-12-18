using Newtonsoft.Json;
using SharedClassLibrary;
using System;
using System.Net.Http;
using System.Text;

namespace StudentConsole
{
    // application/json
    // application/xml
    // image/jpg


    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            // Get studen 0 from the web service
            var str = client
                .GetStringAsync("http://localhost:63028/api/students/0")
                .Result;

            // We might not get a student back
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine(str);

                // Convert the JSON string into a Student object
                var student = JsonConvert.DeserializeObject<Student>(str);

                Console.WriteLine(student.Name);
            }

            // Create new student
            var newStudent = new Student("Fabrice", 29);
            // Serialize Student object into JSON string
            var jsonStudent = JsonConvert.SerializeObject(newStudent);

            // Describe the structure string as JSON in UTF/8 format 
            var content = new StringContent(jsonStudent, Encoding.UTF8, "application/json");

            // POST the JSON Student to the server
            var result = client.PostAsync("http://localhost:63028/api/students", content).Result;

            Console.WriteLine("Did we create the student " + result.IsSuccessStatusCode);

            Console.ReadKey();

        }
    }
}
