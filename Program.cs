using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
/**
Display the following using string interpolation:

From today’s date

1.January 22, 2019
2.2019.01.22
3.Day 22 of January, 2019
4.Year: 2019, Month: 01, Day: 22
5.            Tuesday (10 spaces)
6.     11:01 PM             Tuesday (3 spaces before, 10 spaces between)
7.h:11, m:01, s:27
8.2019.01.22.11.01.27
If you have PI (3.1415) - use var pi = Math.PI;
1. Output as currency
2. Output as right-aligned (10 spaces), number with 3 decimal places **/

        var date= DateTime.Now;
        var pi = Math.PI;
        
        

            Console.WriteLine($"1.{date:MMM dd, yyyy}");
            Console.WriteLine($"2.{date:yyy.MM.dd}");
             Console.WriteLine($"3.Day {date:dd} of {date:MMMM},{date:yyyy}");
             Console.WriteLine("4.Year:{0},Month:{1},Day:{2}",date.Year,date.Month, date.Day);
             Console.WriteLine($"5.{date.DayOfWeek,10}");
             Console.WriteLine($"6.{date:hh:mm tt}{date.DayOfWeek,10}"); //Tried spacing for time and it did not work
             Console.WriteLine($"7.h:{date:hh}, m:{date:mm}, s:{date:ss}"); 
             Console.WriteLine($"8.{date:yyyy.MM.dd.hh.mm.ss}");
             Console.WriteLine("1.{0:C}",pi);
             Console.WriteLine($"2.{pi,10}"); // Spacing not working 


        }
        }

}
