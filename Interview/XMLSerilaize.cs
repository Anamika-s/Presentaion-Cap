using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interview1
{
    [Serializable]
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
    class XMLSerilaize
    {
        public static void Main()
        {
            Student student = new Student("Pawan", "Kumar");
            string filePath = "E:\\Trainings\\temp1.txt";
            FileStream fs = File.Create(filePath);
            XmlSerializer formatter = new XmlSerializer(typeof(Student));
            formatter.Serialize(fs, student);
            fs.Close();

            fs = File.OpenRead(filePath);
            Student student1 = new Student();
            student1 = formatter.Deserialize(fs) as Student;
            Console.WriteLine(student1.firstName);
            Console.WriteLine(student1.lastName);
            fs.Close();

        }
    }
}
