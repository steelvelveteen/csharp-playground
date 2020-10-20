using System;
using System.Reflection;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working on reflections");
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine($"Assembly full name: {assembly.FullName}");

            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                // The enum inside the class is a type just like the class itself
                Console.WriteLine($"Type: {type.Name} | Base type: {type.BaseType}");
                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine($"\tProp name: {prop.Name} | Prop type: {prop.PropertyType}");
                }

                var fields = type.GetFields();
                // var underlyingType = type.GetEnumValues("ErrorCode");
                // Console.WriteLine($"\t\tUnderlying enum type: { underlyingType}");
                foreach (var field in fields)
                {
                    var attributes = field.GetCustomAttributes();
                    foreach (var attr in attributes)
                    {
                        Console.WriteLine($"Field Attr: {attr.GetType().Name}");
                    }
                    Console.WriteLine($"\tField name: {field.Name} | Field type: {field.FieldType}");
                }

                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine($"\tMethod: {method.Name}");
                }

                Console.WriteLine();
            }
            var sample = new Sample { Name = "Joey", age = 46 };
            // two different ways to get the type
            Console.WriteLine($"sample type 01: {sample.GetType()}");
            Console.WriteLine($"sample type 02: {typeof(Sample)}");

            var sampleType = sample.GetType();
            var propertyName = sampleType.GetProperty("Name");
            Console.WriteLine($"Prop by name: { propertyName.GetValue(sample) }");

            var fieldName = sampleType.GetField("age");
            Console.WriteLine($"Field by name: {fieldName.GetValue(sample)}");

            var methodName = sampleType.GetMethod("GetName");
            Console.WriteLine($"Method by name: {methodName}");
            // Call that method
            methodName.Invoke(sample, null);

            // Digging into Attributes


        }
    }

    public class Sample
    {
        public string Name { get; set; }
        public int age = 45;
        public bool isOld = false;
        // enum ErrorCode
        // {
        //     General = 1001,
        //     Unexpected = 1002,
        //     Specific = 3003
        // }

        public string GetName()
        {
            Console.WriteLine($"Invoked method GetName result: {Name}");
            return Name;
        }
        public int GetAge()
        {
            return age;
        }
    }

    public enum ErrorCodeReference
    {
        [ErrorCode(Code = "1001", ErrorMessage = "General error")]
        General = 1001,
        Unexpected = 1002,
        Specific = 3003
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class ErrorCodeAttribute : Attribute
    {
        public string Code { get; set; }
        public string ErrorMessage { get; set; }
        public ErrorCodeAttribute() { }
        public ErrorCodeAttribute(string code, string message)
        {
            ErrorMessage = message;
            Code = code;
        }
    }
}
