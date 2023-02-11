using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowa.Obiekty;

namespace Testowa.Obiekty;
public class ODDB
{
    private readonly Db _db;
    public ODDB()
    {
        _db = new Db();
    }
        public class Taxi
        {
            public int id { get; set; }
            public string Samochód { get; set; }
            public string Status { get; set; }
            public string AktualnaDzielnica { get; set; }

           
        }

        public class District
        {
        private int ilosctaksowek;

        public int Numer { get; set; }
            public string Nazwa { get; set; }
            public int OdlegloscOdCentrum { get; set; }  
            public int Ilosctaksowek { get; set; }
       
        public void ListaTaksówek ()
        {
           foreach (var ataxi in _db.GetTaxi())
    {
        Console.WriteLine($"{ataxi.id} | {ataxi.Samochód} | {ataxi.Status} | {ataxi.AktualnaDzielnica}");
        Console.WriteLine();
    }
}

          
        }
}
