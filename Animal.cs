using System;
using System.Linq;

namespace csharp_playground
{
    public class Animal
    {
        private string name;
        protected string sound;
        protected AnimalIdInfo animalIDInfo = new AnimalIdInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public Animal() : this("No Name", "No Sound")
        {

        }
        public Animal(string name) : this(name, "No Sound")
        {
        }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is ownded by {animalIDInfo.Owner}");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
    }
}