using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726407__C0725642__assignment2
//Manpreet Singh Sidhu C0726407
//Ashwinder Singh C0725642
//Assigmnment 2 
//March 8,2019
//Csd3354-Assignment2
{

    delegate void ExampleDelegate(string xyz);
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();

            delegateExercises.Method3();

            Console.ReadLine();


        }
        public delegate int MyDelegate(out int i);



        public class DelegateExercises

        {

            int Method1(out int i)

            {

                System.Console.WriteLine("Method1");

                i = 10;

                return 0;

            }



            public void Method3()

            {

                MyDelegate myDelegate = new MyDelegate(Method1);

                MyDelegate myDelegate1 = new MyDelegate(Method1);

                MyDelegate myDelegate2 = myDelegate + myDelegate1;

                int intValue;

                myDelegate2(out intValue);



            }
        }
    }
}