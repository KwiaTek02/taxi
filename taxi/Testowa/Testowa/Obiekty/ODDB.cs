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
    }
    public void ListaTaksówek()
    {
        Console.WriteLine("LISTA TAKSÓWEK");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA");
        foreach (var ataxi in _db.GetTaxi())
        {
            Console.WriteLine($"{ataxi.Samochód} | {ataxi.Status} | {ataxi.AktualnaDzielnica}");
            Console.WriteLine();
        }
        Console.WriteLine("LISTA DZIELNIC");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
        foreach (var adisctrict in _db.GetDistrict())
        {
            Console.WriteLine($"{adisctrict.Numer} | {adisctrict.Nazwa} | {adisctrict.Ilosctaksowek}");
            Console.WriteLine();
        }

    }

    public void Zamowienie()
    {

        Console.WriteLine("PROSZĘ PODAĆ NUMER DZIELNICY DO KTÓREJ CHCESZ WEZWAĆ TAKSÓWKĘ:");
        var wyborz = int.Parse(Console.ReadLine() ?? "0");
        if (wyborz == 0) return;
        try
        {
            var Disa = _db.GetDisById(wyborz);
            ShowTaxiData(Disa);
        }
        catch (Exception e)
        {
            Zamowienie();
        }

    }
    public void ShowTaxiData(District Disa)
    {
        Console.Clear();
        foreach (var Taxia in _db.GetTaxi())
        {
            if (Taxia.AktualnaDzielnica == Disa.Nazwa)
            {
                Taxia.CzasDojazdu = 4;
            }
            else
            {
                Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5;
            }
            Console.WriteLine(Taxia.CzasDojazdu);
        }

        //if ()
        // {
        /*Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WriteLine($"ZLECENIE REALIZUJE: {Taxia.Samochód} ");
        int a = 4;
        Console.WriteLine($"CZAS DOJAZDU:  {a} min");
        }
     // else
        {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine($"ZLECENIE REALIZUJE: {Taxia.Samochód} ");
        int a = (Math.Abs(Disa.OdlegloscOdCentrum) + 0) * 5;
        Console.WriteLine($"CZAS DOJAZDU:  {a} min");
        }



        //if(Taxia. == null)
        //int CzasDojazdu = Math.Abs(Taxia.OdlegloscOdCentrum) * 5;
        //Taxia.Status
        */
    }

}
