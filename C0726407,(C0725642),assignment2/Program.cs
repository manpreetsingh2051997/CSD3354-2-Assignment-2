﻿using System;
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

    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();


        }
        public delegate void MyDelegate();

        public class DelegateExercises
        {




            void Method3()

            {


                System.Console.WriteLine(MyDelegate.ToString());


            }




        }
    }
}