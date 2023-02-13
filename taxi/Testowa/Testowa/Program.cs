using Testowa.Obiekty;

var message = new Message();

var Taxi = new ODDB();


message.MainScreen();
while (true)
{ 
    var wybor= message.Show();

    if (wybor == 1) 
    {
        Console.Clear();
        Taxi.ListaTaksówek();
        message.MainScreen();
        
    }
    if (wybor == 2)
    {
        Console.Clear();
        Taxi.Zamowienie();

    }
    if (wybor == 3)
    {
        return;
    }

}