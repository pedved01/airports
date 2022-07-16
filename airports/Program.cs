List<double> date_arrival = new List<double>() { 1, 1, 3, 6, 3, 6, 7, 8, 9, 20 };
List<double> time_arrival = new List<double>() { 1, 1, 3, 6, 3, 6, 7, 8, 9, 20 };
List<int> flight_arrival = new List<int>() { 1, 1, 3, 6, 3, 6, 7, 8, 9, 20 };
List<string> destanation_arrival = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };
List<string> terminal_arrival = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };
List<string> aviacompany_arrival = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };
List<string> gate_arrival = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };

List<double> date_departures = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
List<double> time_departures = new List<double>() { 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, };
List<int> flight_departures = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, };
List<string> destanation_departures = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };
List<string> terminal_departures = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };
List<string> aviacompany_departures = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };
List<string> gate_departures = new List<string>() { "lol", "kek", "lolll", "rjfiue", "ldl", "fier", "gnfhf", "fjbg", "vudf", "fjvufv" };

Console.WriteLine("Choose operation\nAttantion, input a number!");
Console.WriteLine("1 - info table\n2 - editinh\n3 - search\n4 - nearest fly");
int operation = int.Parse(Console.ReadLine());
void BuildTable(int y, string name)
{
    char paint = '*';
    for (int i = 0; i < 13; i++)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, y - 2);
        Console.WriteLine(name);
        Console.SetCursorPosition(1, y + i);
        Console.Write(paint);
        Console.SetCursorPosition(17, y + i);
        Console.Write(paint);
        Console.SetCursorPosition(34, y + i);
        Console.Write(paint);
        Console.SetCursorPosition(51, y + i);
        Console.Write(paint);
        Console.SetCursorPosition(68, y + i);
        Console.Write(paint);
        Console.SetCursorPosition(85, y + i);
        Console.Write(paint);
        Console.SetCursorPosition(102, y + i);
        Console.Write(paint);
        Console.SetCursorPosition(Console.BufferWidth - 2, y + i);
        Console.Write(paint);
        for (int j = 0; j < Console.WindowWidth - 2; j++)
        {
            Console.SetCursorPosition(j + 1, y);
            Console.Write(paint);
            Console.SetCursorPosition(j + 1, y + 2);
            Console.Write(paint);
            Console.SetCursorPosition(j + 1, y + 13);
            Console.Write(paint);
        }
        Console.SetCursorPosition(7, y + 1);
        Console.Write("Date");
        Console.SetCursorPosition(24, y + 1);
        Console.Write("Time");
        Console.SetCursorPosition(40, y + 1);
        Console.Write("Flight");
        Console.SetCursorPosition(55, y + 1);
        Console.Write("Destanation");
        Console.SetCursorPosition(73, y + 1);
        Console.Write("Terminal");
        Console.SetCursorPosition(89, y + 1);
        Console.Write("Aviacompany");
        Console.SetCursorPosition(109, y + 1);
        Console.WriteLine("Gate");
    }
}
switch (operation)
{
    case 1:
        Console.Clear();
        BuildTable(9, "arrival");
        BuildTable(27, "departures");
        for (int i = 0; i < 10; i++)
        {
            Console.SetCursorPosition(3, 12 + i);
            Console.Write(date_arrival[i]);
            Console.SetCursorPosition(19, 12 + i);
            Console.WriteLine(time_arrival[i]);
            Console.SetCursorPosition(36, 12 + i);
            Console.WriteLine(flight_arrival[i]);
            Console.SetCursorPosition(53, 12 + i);
            Console.WriteLine(destanation_arrival[i]);
            Console.SetCursorPosition(70, 12 + i);
            Console.WriteLine(terminal_arrival[i]);
            Console.SetCursorPosition(87, 12 + i);
            Console.WriteLine(aviacompany_arrival[i]);
            Console.SetCursorPosition(104, 12 + i);
            Console.WriteLine(gate_arrival[i]);

            Console.SetCursorPosition(3, 30 + i);
            Console.Write(date_departures[i]);
            Console.SetCursorPosition(19, 30 + i);
            Console.WriteLine(time_departures[i]);
            Console.SetCursorPosition(36, 30 + i);
            Console.WriteLine(flight_departures[i]);
            Console.SetCursorPosition(53, 30 + i);
            Console.WriteLine(destanation_departures[i]);
            Console.SetCursorPosition(70, 30 + i);
            Console.WriteLine(terminal_departures[i]);
            Console.SetCursorPosition(87, 30 + i);
            Console.WriteLine(aviacompany_departures[i]);
            Console.SetCursorPosition(104, 30 + i);
            Console.WriteLine(gate_departures[i]);
        }
        break;
    case 2:
        Console.WriteLine("what do you want to change? \n1 - arriving \n 2 - departures");
        int action = int.Parse(Console.ReadLine());
        if 
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
