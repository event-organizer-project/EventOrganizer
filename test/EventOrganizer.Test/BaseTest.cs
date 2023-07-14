using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Moq;

namespace EventOrganizer.Test
{
    public class BaseTest<T> where T : class
    {
        /*
        public BaseTest()
        {
            Type myType = typeof(T);

            foreach (ConstructorInfo ctor in myType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                string modificator = "";

                // получаем модификатор доступа
                if (ctor.IsPublic)
                    modificator += "public";
                else if (ctor.IsPrivate)
                    modificator += "private";
                else if (ctor.IsAssembly)
                    modificator += "internal";
                else if (ctor.IsFamily)
                    modificator += "protected";
                else if (ctor.IsFamilyAndAssembly)
                    modificator += "private protected";
                else if (ctor.IsFamilyOrAssembly)
                    modificator += "protected internal";

                Console.Write($"{modificator} {myType.Name}(");
                // получаем параметры конструктора
                ParameterInfo[] parameters = ctor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];
                    Console.Write($"{param.ParameterType.Name} {param.Name}");
                    var type = param.ParameterType;

                    var a = new Mock<typeof(type) >();

                    if (i < parameters.Length - 1) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }*/
    }
}
