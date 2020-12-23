//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Reflection;

//namespace ReflectionTest
//{
//    class Program
//    {
//        private static int a = 5, b = 10, c = 20;

//        static void Main(string[] args)
//        {
//            Console.WriteLine("a + b + c = " + (a + b + c));
//            Console.WriteLine("Please enter the name of the variable that you wish to change:");
//            string varName = Console.ReadLine();
//            Type t = typeof(Program);
//            FieldInfo fieldInfo = t.GetField(varName, BindingFlags.NonPublic | BindingFlags.Static);
//            if (fieldInfo != null)
//            {
//                Console.WriteLine("The current value of " + fieldInfo.Name + " is " + fieldInfo.GetValue(null) + ". You may enter a new value now:");
//                string newValue = Console.ReadLine();
//                int newInt;
//                if (int.TryParse(newValue, out newInt))
//                {
//                    fieldInfo.SetValue(null, newInt);
//                    Console.WriteLine("a + b + c = " + (a + b + c));
//                }
//                Console.ReadKey();
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] assemblyTypes = assembly.GetTypes();
            foreach (Type t in assemblyTypes)
                Console.WriteLine(t.Name);
            Console.ReadKey();
        }
    }

    class DummyClass
    {
        //Just here to make the output a tad less boring :)
    }
}

