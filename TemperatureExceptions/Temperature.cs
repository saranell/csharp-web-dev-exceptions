﻿using System;
namespace TemperatureExceptions
{
    public class Temperature
    {

        private double fahrenheit;
        public static double AbsoluteZeroFahrenheit { get; } = -459.67;

        //public Temperature(double fahrenheit)
        //{
        //    try
        //    {
        //        Fahrenheit = fahrenheit;
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        Fahrenheit = -459.67;
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Fahrenheit cannot be less than -459.67.");
        //    }
        //}

        public Temperature(double fahrenheit)
        {
            Fahrenheit = fahrenheit;
        }

        public double Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {

                if (value < AbsoluteZeroFahrenheit)
                {
                    throw new ArgumentOutOfRangeException("Value is below absolute zero");
                }

                fahrenheit = value;
            }

        }

    }
}
