using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {   //console is a reference to a system static class
            //static classes are used by typing the class name
            //static classes do not store variable data
            //static classes are used by everyone
            //methods of a static class will be placed after
            //  the object dot operator
            Console.WriteLine("hello world");

            //Create an instance of a non static class
            //If you createa  declarative using JUST the 
            //      class name then this is ONLY a pointer 
            //      that can hold instance of the class
            //      specified
            //Currrent value of aVariable is null

            myData aVariable=null;

            //if you use the new command with the class
            //      the new command will physically create
            //      an instance of the class
            myData anInstance = new myData();

            if (aVariable==null)
            {
                Console.WriteLine("aVariable has nothing in it");
            }
            if (anInstance==null)
            {
                Console.WriteLine("anInstance has nothing in it");
            }

        }//eom(end of method)

    }//eoc(end of class)

}//eon(end of namespace)
