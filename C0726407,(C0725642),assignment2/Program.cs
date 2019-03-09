using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726407__C0725642__assignment2
//Manpreet Singh Sidhu C0730484
//Ashwinder Singh C0725642
//Assigmnment 2 
//March 8,2019
//Csd3354-Assignment2
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1(int i)
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