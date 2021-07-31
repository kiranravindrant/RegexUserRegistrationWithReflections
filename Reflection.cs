using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

        
namespace RegexUserRegistration
{
    class Reflection
    {
        public static void ReflectionTest()
        {

            Type type = Type.GetType("RegexUserRegistration.Program");
            Console.WriteLine("Full Name :{0}", type.FullName);
            Console.WriteLine("Class name is : {0}", type.Name);
            Console.WriteLine("Methods in Program class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("Properties in Program class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in Program class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

        }


    }
}
