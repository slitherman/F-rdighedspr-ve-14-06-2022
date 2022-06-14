using System;
using System.Collections.Generic;

namespace Færdighedsprøve_14_06_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime d1 = new DateTime();
            //DateTime d2 = new DateTime();

        


            BadetidsPeriod b1 = new BadetidsPeriod("Aftensbadning", DayOfWeek.Monday, new DateTime().AddHours(4).AddMinutes(30), new DateTime().AddHours(5).AddMinutes(10));
            Console.WriteLine( b1.ToString() );

            Kreds k1 = new Kreds("12", "kredsen", "kbh", 24);
            Console.WriteLine(k1.ToString());
            b1.removeKreds("1");
            b1.addKreds(k1);
            Console.WriteLine(b1.ToString());

            //b1.NameAndIdOnly();
            b1.NameFiltering();
            //BadetidsPeriod b2 = new BadetidsPeriod("asd", DayOfWeek.Monday, new DateTime(2022, 10, 15, 17, 0, 0), new DateTime(2022, 10, 15, 20, 0, 0));

            //BadetidsPeriod b3 = new BadetidsPeriod("asddd", DayOfWeek.Monday, new DateTime(2022, 11, 15, 17, 0, 0), new DateTime(2022, 10, 15, 20, 0, 0));
            //Kreds k2 = new Kreds("12", "kredsen", "kbh", 0);
            Console.WriteLine(b1.ToString());
            BadetidsPeriodeForLoopAndList kk1 = new BadetidsPeriodeForLoopAndList("natbad", DayOfWeek.Friday, new DateTime().AddHours(4).AddMinutes(10), new DateTime().AddHours(5).AddMinutes(30));

            Console.WriteLine(kk1.ToString());

            //    kk1.addKreds(k1);
            //kk1.removeKreds("12");



            //try
            //{

            //    BadetidsPeriod b2 = new BadetidsPeriod("asd", DayOfWeek.Monday, new DateTime(2022, 10, 15, 17, 0, 0), new DateTime(2022, 10, 15, 20, 0, 0));

            //    BadetidsPeriod b3 = new BadetidsPeriod("asddd", DayOfWeek.Monday, new DateTime(2022, 11, 15, 17, 0, 0), new DateTime(2022, 10, 15, 20, 0, 0));
            //    Kreds k2 = new Kreds("12", "kredsen", "kbh", 0);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

         

           

        }
    }
}
