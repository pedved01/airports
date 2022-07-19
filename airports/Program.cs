using airports;
using Bogus;
using ConsoleTables;
List<Flight> flights = new List<Flight>(10);
flights = getflights();
Console.WriteLine("Choose operation\nAttantion, input a number!");
Console.WriteLine("1 - editinh\n2 - search\n3 - nearest fly");
int operation = int.Parse(Console.ReadLine());
switch (operation)
{
    case 1:

        printlifhts(flights);
        Console.WriteLine("what do you want to change? \n1 - date_time\n2 - ID\n3 - terminal\n4 - aviacompany\n5 - gate");
        int action = int.Parse(Console.ReadLine());
        Console.WriteLine("Which line do you want to change?");
        int line = int.Parse(Console.ReadLine());
        Console.WriteLine("Input new data");
        var new_element = Console.ReadLine();
        switch (action)
        {
            case 1:
                flights.
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
        break;
    case 2:
        //"search":
        break;
    case 3:
        //"nearest fly"
        break;
    default:
        Console.WriteLine("Wrong number! Input the correct one!");
        break;
}
Console.SetCursorPosition(1, 45);
void printlifhts(List<Flight> info)
{
    ConsoleTable
    .From(info)
    .Configure(x => x.NumberAlignment = Alignment.Right)
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
        .RuleFor(x => x.terminal, x => x.PickRandom(terminals))
        .RuleFor(x => x.ID, x => x.Random.Int(0, 100))
        .RuleFor(x => x.aviacompany, x => x.PickRandom(aviacompanys))
        .RuleFor(x => x.gate, x => x.Random.Int(1, 20))
        .RuleFor(x => x.flight_Type, x => x.Random.Enum<Flight_Type>());

    return flights.Generate(10);
}