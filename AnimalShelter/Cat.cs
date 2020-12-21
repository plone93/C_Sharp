using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat
    {
        public string Name; 
        public string Color;
        public string Gender;
        public string Note;

        public int MyProperty { get; set; }//게터세터

        public Cat(string name, string color, string gender, string note)
        {
            Name = name;
            Color = color;
            Gender = gender;
            Note = note;
        }

        public string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할퀴기";
        }
    }
}
