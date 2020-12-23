using System;
using System.Reflection;

public class Program
{
	public static void Main()
	{
		var ass = Assembly.GetExecutingAssembly();
		Type[] types = ass.GetTypes();
		foreach (var type in types)
			Console.WriteLine(type.FullName);

		/*foreach(var type in types)
		{
			Console.WriteLine(type.FullName);
		 MethodInfo[] methods = type.GetMethods();
			foreach(var method in methods)
			{
				Console.WriteLine(method.Name);
		} 
			
			}*/

		foreach (var type in types)
		{
			Console.WriteLine(type.FullName);
			MemberInfo[] members = type.GetMembers();
			foreach (var method in members)
			{
				if (method.MemberType == MemberTypes.Method)
				{
					Console.WriteLine("THESE ARE METHOD");

					//Console.WriteLine(method.Name);
                    Console.WriteLine("No of Methods are " + type.GetMethods().Length);
				}
				else if (method.MemberType == MemberTypes.Constructor)
				{
					Console.WriteLine("THESE ARE CONSTRUCTORS");

					//Console.WriteLine(method.Name);
					Console.WriteLine("No of constructors are " + type.GetConstructors().Length);
				}

			}

		}

		//write your code here
	}
}


namespace University
{

	public class Student
	{
		public string FullName { get; set; }

		public int Class { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string GetCharacteristics()
		{
			return "";
		}
	}

	namespace Department
	{

		public class Professor
		{

			public string FullName { get; set; }

		}
	}
}