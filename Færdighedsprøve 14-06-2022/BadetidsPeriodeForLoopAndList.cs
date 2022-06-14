using System;
using System.Collections.Generic;
using System.Text;

namespace Færdighedsprøve_14_06_2022
{
    class BadetidsPeriodeForLoopAndList: BadetidsPeriod
    {

        List<Kreds> KredsList;
        public BadetidsPeriodeForLoopAndList(string _badning, DayOfWeek _ugedag, DateTime _start, DateTime _slut)
            :base (_badning,  _ugedag, _start,  _slut)
        {
            KredsList = new List<Kreds>();
            {

                KredsList.Add(new Kreds("44", "kreds for voksne", "kbh", 10));

                KredsList.Add(new Kreds("33", "kreds for pensionister", "kbh", 22));
                KredsList.Add(new Kreds("33", "kreds for kvinder", "kbh", 11));

            }

        }

        public override void addKreds(Kreds k)
        {
            base.addKreds(k);
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(k.ToString());
            }
            
      

        }
        public override void removeKreds(string id)
        {
            base.removeKreds(id);
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(id.ToString());
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < KredsList.Count; i++)
            {
                str.AppendLine($"Badning: {Badning} Dag: {Ugedag} Startstidspunkt: {StartTidspunkt} Slutstidspunkt: {SlutTidspunkt}");
                Console.WriteLine(KredsList[i]);

            }
            return str.ToString();
                
        }
    }


  
}
