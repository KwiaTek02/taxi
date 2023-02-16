using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowa.Obiekty;
using static Testowa.Obiekty.ODDB;

namespace Testowa.Obiekty
{
    public class Db
    {
        private readonly List<Taxi> taxi = new()
        {
             new Taxi
             {
                 id = 1,
                 Samochód = "Ford Mondeo",
                 Status = "wolny",
                 AktualnaDzielnica="Retkinia"
             },

             new Taxi
             {
                 id = 2,
                 Samochód = "Dacia Logan",
                 Status = "wolny",
                 AktualnaDzielnica="Łódź Kaliska"
             },

             new Taxi
             {
                 id = 3,
                 Samochód = "Toyota Avensis",
                 Status = "wolny",
                 AktualnaDzielnica="Śródmieście"
             },

             new Taxi
             {
                 id = 4,
                 Samochód = "Mercedes E220",
                 Status = "wolny",
                 AktualnaDzielnica="Widzew"
             },

             new Taxi
             {
                 id = 5,
                 Samochód = "Huindai Lantra",
                 Status = "wolny",
                 AktualnaDzielnica="Janów"
             }
        };
        public List<Taxi> GetTaxi() => taxi;

        private readonly List<District> district = new()
        {
           new District
           {
               Numer=1,
               Nazwa="Retkinia",
               OdlegloscOdCentrum=-2,
               Ilosctaksowek=1
           },

           new District
           {
               Numer=2,
               Nazwa="Łódź Kaliska",
               OdlegloscOdCentrum=-1,
               Ilosctaksowek=1
           },

           new District
           {
               Numer=3,
               Nazwa="Śródmieście",
               OdlegloscOdCentrum=0,
               Ilosctaksowek=1
           },

           new District
           {
               Numer=4,
               Nazwa="Widzew",
               OdlegloscOdCentrum=1,
               Ilosctaksowek=1
           },

           new District
           {
               Numer=5,
               Nazwa="Janów",
               OdlegloscOdCentrum=3,
               Ilosctaksowek=1
           }
        };
        public List<District> GetDistrict() => district;
        public District GetDisById(int id) => district.First(x => x.Numer == id);
    }
    
}