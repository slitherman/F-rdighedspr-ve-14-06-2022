using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Færdighedsprøve_14_06_2022
{
    class BadetidsPeriod
    {
       public Dictionary<string, Kreds> Kredsliste;
     
        public string Badning { get; set; }
        public DayOfWeek Ugedag { get; set; }
        public DateTime StartTidspunkt { get; set; }
        public DateTime  SlutTidspunkt { get; set; }
        public BadetidsPeriod(string _badning, DayOfWeek _ugedag, DateTime _start, DateTime _slut)
        {
            Badning = _badning;
            Ugedag = _ugedag;
            StartTidspunkt = _start;
            SlutTidspunkt = _slut;



            Kredsliste = new Dictionary<string, Kreds>();
            {

                Kredsliste.Add("1", new Kreds("111", "tha top malla", "houston", 40) { });
                Kredsliste.Add("2", new Kreds("232", "tha greatest thing eva made by god", "houston", 40) { });
                Kredsliste.Add("3", new Kreds("233", "you'll cowards dont even smoke crack", "houston", 40) { });
                Kredsliste.Add("4", new Kreds("233", "THA WORLD AINT REAL I BEND THE SPOON WIT MY MIND 3", "houston", 40) { });

            }





            {

              

                //if (StartTidspunkt> SlutTidspunkt)
                //{
                //    Console.WriteLine("error bad time input");
                //}
                //if (Badning.Length< 4)
                //{
                //    Console.WriteLine("error bad string");
                //}

                if (StartTidspunkt > SlutTidspunkt)
                {
                    throw new ArgumentException();
                }
                if (Badning.Length < 4)
                {
                    throw new ArgumentException();
                }
                
            };

        }

        public virtual void addKreds(Kreds k)
        {
            if(!Kredsliste.Keys.Contains(k.Id))
            {
                Kredsliste.Add(k.Id, k);
            }
        }
        public  virtual void removeKreds(string id)
        {
            Kredsliste.Remove(id);
        }

        //public void NameAndIdOnly()
        //{
        //    var idandname = from k in Kredsliste
        //                    select new
        //                    {
        //                        k.Value.Navn,
        //                        k.Value.Id
        //                    };

        //    var idandnameList = idandname.ToList();

        //    foreach (var item in idandnameList)
        //    {
        //        Console.WriteLine(idandname.ToString());
        //    }
        //}

        public void NameFiltering()
        {
            var sids = from id in Kredsliste
                       where id.Value.Navn.Length > 10 && id.Value.Navn.Length < 20
                       orderby id.Value.Navn ascending
                       select id;
            foreach (var i in sids)
            {
                Console.WriteLine(" kreds {0} has the id {1} ", i.Value.Navn, i.Value.Id);
            }

                    
        }
        public void UpdateKreds(Kreds k)
        {
            foreach (var i in Kredsliste.Values)
            {
                if (i.Id == k.Id)
                {
                    i.Id = k.Id;
                    i.Navn = k.Navn;
                    i.Adresse = k.Adresse;
                    i.AntalDeltagere = k.AntalDeltagere;
                        
                }
            }
        }

    

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($" Badning: {Badning} Dag: {Ugedag} Startstidspunkt: {StartTidspunkt} Slutstidspunkt: {SlutTidspunkt} ");
            return str.ToString();
        }
    }
}
