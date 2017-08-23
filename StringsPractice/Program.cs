using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Brad";
            //string lastName = "Berger";
            //string fullName = firstName + "" + lastName;//Concatinate strings. This way to the left <--------
            //                                            //also works string fullName = string.Concat(firstName, "" , lastName);


            //Console.WriteLine(firstName.Length);
            //Console.WriteLine(lastName.Length);
            //Console.WriteLine(firstName[0]);
            //Console.WriteLine(firstName[firstName.Length - 1]);
            //Console.WriteLine(firstName.Equals(lastName));
            //Console.WriteLine(firstName == lastName);
            //Console.WriteLine("My favorite book is \"The Notebook\"");

            //substring()

            //string example = "oneTwoThree";
            ////substing takes a start, index 0, and a length, 6 indexes long
            //string sub = example.Substring(3, 8);
            //Console.WriteLine(sub);

            //.Length Property
            //tally the indexes in your first name and last name and print it out
            //string myFirstName = "Brad";
            //string myLastName = "Berger";
            //Console.WriteLine(myFirstName.Length);
            //Console.WriteLine(myLastName.Length);

            ////computer prints out a different message based on which name has more indexes
            //if (myFirstName.Length > myLastName.Length)
            //{
            //    Console.WriteLine("First is Longer");
            //}
            //else if(myFirstName.Length == myLastName.Length)
            //{
            //    Console.WriteLine("Samsis");
            //}
            //else
            //{
            //    Console.WriteLine("last must be longer!");
            //}

            ////Using escape character \n to print "Brad Berger" on a separate line from "My name is"
            //Console.WriteLine("My name is \nBrad Berger");

            //Concatenation 2 ways

            Console.WriteLine("What is your first name");
            string yourFirstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string yourLastName = Console.ReadLine();

            Console.WriteLine("OK. Your name is " + yourFirstName + " " + yourLastName);
            Console.WriteLine(your







                        

        }
    }
}
