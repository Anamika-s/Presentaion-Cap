using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Interview4
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

    class Json3
    {
        public static void Main()
        {
            Student student = new Student("Lalit", "Kumar");
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Student));
            string filePath = "E:\\Trainings\\temp4.txt";
            Console.WriteLine("Doing Serialization");
            FileStream fs;
            fs = File.Create(filePath);
            obj.WriteObject(fs, student);
            fs.Close();

            fs = File.OpenRead(filePath);
            Student student1= obj.ReadObject(fs) as Student;
            Console.WriteLine(student1.firstName);
            Console.WriteLine(student1.lastName);
            fs.Close();

        }
    }
}
