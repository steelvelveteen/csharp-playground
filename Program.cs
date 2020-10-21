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
                if (type.IsEnum)
                {
                    var fields = type.GetFields();
                    foreach (var field in fields)
                    {
                        Console.WriteLine($"\tField name: {field.Name} | Field type: {field.FieldType}");
                        if (field.FieldType.IsEnum)
                        {
                            Console.WriteLine($"enum field name: {field.Name}");
                            Console.WriteLine($"enum field value: {field.GetRawConstantValue()}");

                            // Get enum inner attributte by name

                            // Console.WriteLine(generalCode);
                        }
                    }
                }


                Console.WriteLine();
            }
            var sample = new Sample { Name = "Joey", age = 46 };

            var sampleType = sample.GetType();
            var fieldAge = sampleType.GetField("age");
            Console.WriteLine($"Field value by name(age): {fieldAge.GetValue(sample)}");

            var fieldName = sampleType.GetProperty("Name");
            Console.WriteLine($"Prop value by name(Name): {fieldName.GetValue(sample)}");

            var fieldEnum = sampleType.GetField("ErrorCodeReference");

        }
    }

    public class Sample
    {
        public string Name { get; set; }
        public int age = 45;
        public bool isOld = false;

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
