using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class UsingDll
    {
        public static void Main()
        {
            Assembly ass = Assembly.LoadFrom(@"C:\Users\Anamika\source\repos\Interview\MyDll\bin\Debug\MyDll.dll");
            Type[] types = ass.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type);
                MethodInfo[] methods = type.GetMethods();
                foreach(var method in methods)
                {
                    Console.WriteLine(method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                   
                        object obj = Activator.CreateInstance(type, null);
                    if (parameters.Length == 0)
                    {
                        method.Invoke(obj, null);
                    }
                    if (parameters.Length ==2)
                    {

                        object[] mParam = new object[] { 5, 10 };
                        //invoke AddMethod, passing in two parameters
                        int res = (int)type.InvokeMember(method.Name, BindingFlags.InvokeMethod,
                                                           null, obj, mParam);
                        Console.Write("Result: {0} \n", res);
                    }
                }
                
            }




        }
    }
}
