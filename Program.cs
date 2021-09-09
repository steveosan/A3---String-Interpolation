﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime today = DateTime.Now;


            Console.WriteLine($"1. {today:MMMM} {today:dd},{today:yyyy}");
            Console.WriteLine($"2. {today:yyyy}.{today:MM}.{today:dd}");
            Console.WriteLine($"3. Day {today:dd} of {today:MMMM}, {today:yyyy}");
            Console.WriteLine($"4. Year:{today:yyyy},Month:{today:MM},Day:{today:dd}");
            Console.WriteLine($"5.           {today:dddd}");
            Console.WriteLine($"6.    {today:hh}:{today:mm} {today:tt}          {today:dddd}");
            Console.WriteLine($"7. h:{today:hh},m:{today:mm},s:{today:ss}");
            Console.WriteLine($"8. {today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");

            var pi = Math.PI;
            string name = "-------------------------------------------------";

            // Composite formatting:
            Console.WriteLine($"{name}");


            Console.WriteLine($"1. {pi.ToString("C")}");
            Console.WriteLine(String.Format("{0,18}" , $"2. {pi.ToString("F3")}"));



        }
    }
}
