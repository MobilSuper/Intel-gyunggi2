﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Linq.Expressions;

namespace Test01_Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program pgm = new Program();
            //int i = pgm.function();
            Test01 Sub = new Test01();
            Sub.MainFunc();
        }
        /*int function()
        {
            while (true)
            {

            }
            return 1;
        }*/
    }
    class Test01 // main class
    {
        public void MainFunc()
        {
            var v = 100;
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;
            object o = i + 1;
            WriteLine("Hello World({0}, {1}, {4}, {5})\nMain Function({2}, {3})", i, j, d, e, o, v); // printf와 동일
            o = d + 0.5;
            WriteLine("Hello World({0}, {1})\nMain Function({2}, {3}, {4})", i, j, d, e, o);
            while (true)
            {
                try
                {
                    WriteLine("두 개의 정수를 입력하세요 ");
                    string str = Console.ReadLine(); // str = "10 20"
                    i = int.Parse(str.Split(' ')[0]);
                    j = int.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"Hello World({i}, {j})\nMain Function({d}, {e})"); //보관문자열 사용

                    WriteLine("두 개의 실수를 입력하세요 ");
                    str = ReadLine(); // str = "10.5 20.1"
                    d = double.Parse(str.Split(' ')[0]);
                    e = double.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"Hello World({i}, {j})\nMain Function({d}, {e})");
                    /*string str = "STX" + i.ToString() + "ETX";
                    string st1 = $"STX{i,5}ETX";
                    WriteLine(str);
                    Console.WriteLine(st1);*/
                 }
                catch (Exception e1)
                {
                    WriteLine(e1.Message);
                }
            }
        }
    }
}
