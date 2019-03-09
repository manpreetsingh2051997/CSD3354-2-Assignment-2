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
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();


        }


    }
    public delegate void MyDelegate();
    public class DelegateExercises

    {

        void Method1()

        {

            System.Console.WriteLine("Method1");

        }



        public void Method3()

        {

            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();


        }




    }
}



