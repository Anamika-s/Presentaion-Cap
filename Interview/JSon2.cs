using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview3
{

    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Student()
        {

        }
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }
    }

    class JSon2
    {
        public static void Main()
        {
            Student student = new Student("Kapil", "Kumar");
            string str = JsonConvert.SerializeObject(student);
            Console.WriteLine(str);

            Student student1 =  JsonConvert.DeserializeObject<Student>(str) as Student;
            Console.WriteLine(student1.firstName);
            Console.WriteLine(student1.lastName);
        }
    }
}
