using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("y", "Y cannot have a value of zero.");
            }
            else
            {
            return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            /* Return an integer representing the number of points a student receives for properly submitting a file in C#.
                - If a student’s submitted file ends in .cs, they get 1 point.
                - If a student’s submitted file doesn’t end in .cs, they get 0 points.
                - If the file submitted is null or an empty string, an exception should be thrown.*/
            
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("fileName", "Student has not submitted any work.");
            }
            else
            {
                if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Divide(num1, num2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            CheckFileExtension("Carl");
        }
    }
}
