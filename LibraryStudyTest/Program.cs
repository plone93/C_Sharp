using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryStudy.Tools;
using LibraryStudy.Extensions;

namespace LibraryStudyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager log = new LogManager(null, "_LibraryStudy");

            log.WriteLine("Processing Start");
            for (int i = 0; i < 10; i++)
            {
                log.WriteLine("Processing " + i);

                //DO
                System.Threading.Thread.Sleep(1000);

                log.WriteLine("Done : " + i);
            }
            log.WriteLine("Processing End");
            Console.Write(Application.Root);

            //확장메서드 사용
            //log.WriteConsole();

            string temp = "test";
            Console.WriteLine(temp.IsNumeric());
            Console.WriteLine(temp.IsDateTime());
        }
    }

    //확장메서드
    public static class ExtensionTest
    {
        //확장메서드는 static 클래스 안에 와야하며 static 선언이 되야함
        //인수란에 this 뒤에 확장할 메서드 작성
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
        }

    }
}
