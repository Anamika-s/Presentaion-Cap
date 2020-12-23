using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Interview2
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
    class JSonSe
    {
       public static void Main()
        {
            Student student = new Student("Rajesh", "Kumar");
            string filePath = "E:\\Trainings\\temp2.txt";
            FileStream fs;
            fs = File.Create(filePath);
            JsonSerializer formatter = new JsonSerializer();
            StreamWriter sw = new StreamWriter(fs);
            JsonWriter writer = new JsonTextWriter(sw);
            formatter.Serialize(writer, student);
            sw.Close();
            writer.Close();
            fs.Close();

            fs = File.OpenRead(filePath);
            StreamReader sr = new StreamReader(fs);
            JsonReader reader = new JsonTextReader(sr);
            JObject obj = null;
            obj = formatter.Deserialize(reader) as JObject;
            Student student2 = obj.ToObject(typeof(Student)) as Student;
            Console.WriteLine(student2.firstName);
            Console.WriteLine(student2.lastName);
            sr.Close();
            reader.Close();
            fs.Close();
        }
    }
}
