using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Færdighedsprøve_14_06_2022
{
    class Kreds
    {
         [Key]
        public string Id { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int AntalDeltagere { get; set; }

        public Kreds(string _id, string _navn, string _Adresse, int _Antal)
        {
            Id = _id;
            Navn = _navn;
            Adresse = _Adresse;
            AntalDeltagere = _Antal;


            //if (AntalDeltagere < 4)
            //{
            //    Console.WriteLine("error not enough participants ");
            //}

            if (AntalDeltagere < 4)
            {
                throw new ArgumentException();
            }
        }



        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Id: {Id} Navn: {Navn} Adresse: {Adresse} AntalDeltagere: {AntalDeltagere}");
            return str.ToString();
        }
    }
}
