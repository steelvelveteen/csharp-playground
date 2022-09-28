using System;

namespace csharp_playground
{
    public abstract class Shape
    {
        public string Name { get; set; } = "Default shape name";
        /*     
         Virtual methods have an implementation and provide the derived classes
         with the option of overriding it. Abstract methods do not provide an 
         implementation and force the derived classes to override the method. 
         So, abstract methods have no actual code in them, and (non-abstract) 
         subclasses HAVE TO override the method.
         */

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        public abstract double Area();
    }
}
