using System;
using System.Collections.Generic;
using Study3;

namespace Study1
{
    abstract class Animal
    {
        public virtual void Speak1()//정의 후 내용 작성
        {
            Console.WriteLine("입력해주세요");
        }
        public abstract void Speak2();//정의만 가능
    }
    class Dog : Animal
    {
        public override void Speak1()
        {
            Console.WriteLine("멍멍");
        }

        public override void Speak2()//abstract는 반드시 재정의 해야함
        {
            Console.WriteLine("왈왈");
        }
    }

    interface Test1
    {
        public virtual void Eat()
        {
            Console.WriteLine("냠냠");
        }
        public abstract void Run();
    
    }
    interface Test2
    {
        public void Angry();
    }

    class Cat : Test1, Test2
    {
        public void Run()
        {
            Console.WriteLine("달린다냥");
        }

        public void Angry()
        {
            Console.WriteLine("화낸다냥");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            //cat.Eat();
            //cat.Run();
            cat.Angry();

            Study2.Cat cat2 = new Study2.Cat();



        }
    }
}
