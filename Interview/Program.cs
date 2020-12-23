using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    [Serializable]
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student("Deepak", "Sood");
            string filePath = "E:\\Trainings\\temp.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            Console.WriteLine("Doing Serialization");

            FileStream fs;
            fs = File.Create(filePath);
            formatter.Serialize(fs, student);
            fs.Close();

            Console.WriteLine("Doing Deserialization");
            fs = File.OpenRead(filePath);
            Student obj = null;
            obj=formatter.Deserialize(fs) as Student;
            Console.WriteLine(obj.firstName);
            Console.WriteLine(obj.lastName);

        }
    }
}
