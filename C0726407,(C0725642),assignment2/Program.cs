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


        }


    }
    public class DelegateExercises

    {
        public delegate int MyDelegate(int intValue);



        public int Method1(int intMethod1)

        {

            return intMethod1 * 2;

        }



        public int Method2(int intMethod2)

        {

            return intMethod2 * 10;

        }
        public void Method4(MyDelegate myDelegate)
        {
            int result = myDelegate(10);
            Console.WriteLine(result);
        }



        public void Method3()

        {

            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);

        }
    }
}