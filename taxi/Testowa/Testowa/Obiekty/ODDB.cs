using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Testowa.Obiekty;
using static Testowa.Obiekty.ODDB;

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
        public int CzasDojazdu { get; set; }
    }

    public class District
    {
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
        for (int i = 0; i < 100; i++)
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


            void ShowTaxiData(District Disa)
            {
                Console.Clear();
                foreach (var Taxia in _db.GetTaxi())
                {
                    foreach (var adisctrict in _db.GetDistrict())
                    {
                        if (Taxia.Status=="wolny")
                        { 
                            if (Disa.Numer == 1)
                            {
                                if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + (adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + (adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                }
                                if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                }
                            }
                            if (Disa.Numer == 2)
                            {
                                if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                }
                                if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                }
                            }
                            if (Disa.Numer == 3)
                            {
                                if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                }
                                if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                }
                            }
                            if (Disa.Numer == 4)
                            {
                                if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                }
                                if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 - adisctrict.OdlegloscOdCentrum * 5;
                                }
                            }
                            if (Disa.Numer == 5)
                            {
                                if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                }
                                if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 - adisctrict.OdlegloscOdCentrum * 5;
                                }
                                if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                {
                                    Taxia.CzasDojazdu = Math.Abs(Disa.OdlegloscOdCentrum) * 5 - adisctrict.OdlegloscOdCentrum * 5;
                                }
                            }
                            if (Disa.Nazwa == Taxia.AktualnaDzielnica)
                            {
                                Taxia.CzasDojazdu = 20;
                            }
                        }
                        else
                        {
                            if (Taxia.Status == "zajęta")
                            {
                                if (Disa.Numer == 1)
                                {
                                    if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + (adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + (adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                    if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                }
                                if (Disa.Numer == 2)
                                {
                                    if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                    if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                }
                                if (Disa.Numer == 3)
                                {
                                    if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                    if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                }
                                if (Disa.Numer == 4)
                                {
                                    if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                    if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 - adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                }
                                if (Disa.Numer == 5)
                                {
                                    if (adisctrict.Numer == 1 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 2 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += (Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 3 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 + Math.Abs(adisctrict.OdlegloscOdCentrum) * 5;
                                    }
                                    if (adisctrict.Numer == 4 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 - adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                    if (adisctrict.Numer == 5 && Taxia.AktualnaDzielnica == adisctrict.Nazwa)
                                    {
                                        Taxia.CzasDojazdu += Math.Abs(Disa.OdlegloscOdCentrum) * 5 - adisctrict.OdlegloscOdCentrum * 5;
                                    }
                                }
                            }
                            if (Disa.Nazwa == Taxia.AktualnaDzielnica)
                            {
                                Taxia.CzasDojazdu += 20;
                            }
                        }
                    }
                }
                foreach (var atax in _db.GetTaxi())
                {
                    foreach (var adis in _db.GetDistrict())
                    {
                        if (Math.Min(atax.CzasDojazdu, 9999999) < 999999 & atax.AktualnaDzielnica == Disa.Nazwa & adis.Nazwa == atax.AktualnaDzielnica)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"ZLECENIE REALIZUJE: {atax.Samochód}");
                            Console.WriteLine($"CZAS DOJAZDU: {atax.CzasDojazdu} min.");
                            Console.ForegroundColor = ConsoleColor.White;
                            atax.AktualnaDzielnica = Disa.Nazwa;
                            atax.Status = "zajęta";
                            Disa.Ilosctaksowek += 1;
                            adis.Ilosctaksowek -= 1;
                            break;
                        }
                    }
                }

                Console.WriteLine("LISTA DZIELNIC");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
                foreach (var adisctrict in _db.GetDistrict())
                {
                    Console.WriteLine($"{adisctrict.Numer} | {adisctrict.Nazwa} | {adisctrict.Ilosctaksowek}");
                    Console.WriteLine();
                }

                Console.WriteLine("LISTA TAKSÓWEK");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA | CZAS DOJAZDU");
                foreach (var ataxi in _db.GetTaxi())
                {
                    Console.WriteLine($"{ataxi.Samochód} | {ataxi.Status} | {ataxi.AktualnaDzielnica} | ({Math.Abs(ataxi.CzasDojazdu)} min.)");
                    Console.WriteLine();
                }

            }
        }
    }
}