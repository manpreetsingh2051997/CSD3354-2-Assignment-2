using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 { 
namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class DelegateExercises
    {
        // Student ID:Manpreet singh sidhu Singh Sidhu Student ID:C0726407
        //Student ID:Ashwinder Singh Student ID:C0725642
        // Assignment 2
        //March 7, 2019
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }
    }
}