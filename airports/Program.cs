using airports;
using Bogus;
using ConsoleTables;
List<Flight> flights = new List<Flight>(10);

Console.WriteLine("Choose operation\nAttantion, input a number!");
Console.WriteLine("1 - info table\n2 - editinh\n3 - search\n4 - nearest fly");
int operation = int.Parse(Console.ReadLine());
switch (operation)
{
    case 1:
        flights =  getflights();
        printlyfhts(flights);
        break;
    case 2:
        Console.WriteLine("what do you want to change? \n1 - arriving \n 2 - departures");
        int action = int.Parse(Console.ReadLine());
        if (action == 1)
        {
            Console.WriteLine("");
        }
        break;
    case 3:
        //"search":
        break;
    case 4:
        //"nearest fly"
        break;
    default:
        Console.WriteLine("Wrong number! Input the correct one!");
        break;
}
Console.SetCursorPosition(1, 45);
void printlyfhts(List<Flight> list)
{
    ConsoleTable
    .From(list)
    .Configure(o => o.NumberAlignment = Alignment.Right)
    .Write(Format.Alternative);
}

List<Flight> getflights()
{
    var terminals = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f' };
    var aviacompanys = new List<string>() { "MAY", "AZUR", "LUFHAHEN" };

    DateTime datefom = DateTime.Now.AddDays(-1);
    DateTime dategom = DateTime.Now.AddDays(+1);
    var flights = new Faker<Flight>()
        .RuleFor(x => x.date_time, x => x.Date.Between(datefom, dategom))
        .RuleFor(x => x.ID, x => x.Random.Int())
        .RuleFor(x => x.terminal, x => x.PickRandom(terminals))
        .RuleFor(x => x.aviacompany, x => x.PickRandom(aviacompanys))
        .RuleFor(x => x.gate, x => x.Random.Int(1, 20))
        .RuleFor(x => x.flight_Type, x => x.Random.Enum<Flight_Type>());
       
    return flights.Generate(10) ;
}