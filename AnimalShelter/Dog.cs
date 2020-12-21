using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum DogBread {Mixed, Bulldog, Jindo, Yorkshire }//개 품종

    public class Dog
    {
        public string Name;
        public string Color;
        public string Gender;
        public string Note;
        public DogBread Bread;

        public Dog(string name, string color, string gender, string note, DogBread bread)
        {
            Name = name;
            Color = color;
            Gender = gender;
            Note = note;
            Bread = bread;
        }

        public string MakeSound()
        {
            return "뭉멍";
        }

        public string Bite()
        {
            return "물어뜯기";
        }
    }
}
