using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    public class Cat
    {
        public String Name;
        public int Age;

        private int Happiness = 50;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void getBored()
        {
            Happiness = Happiness - 10;

            if (Happiness < 0)
            {
                Happiness = 0;
            }
        }

        public void Play()
        {
            Happiness = Happiness + 10;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public void Eat()
        {
            Happiness = Happiness + 20;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public string Express()
        {
            String message = "";

            if (Happiness >= 80)
            {
                message = "Im happy";
            }
            else if (Happiness >= 60)
            {
                message = "Im soso";
            }
            else if (Happiness >= 20)
            {
                message = "Im gloomy";
            }
            else
            {
                message = "Im sad";
            }

            return this.Name + ": " + message;
        }

    }
}
