
Console.WriteLine("select word c,o,d,e");
string input = Console.ReadLine();

    switch(input.ToLower()){
    case "c":
    Console.WriteLine("c# books");
    break;

    case "o":
    Console.WriteLine(".Net core books");
    break;

    case "d":
    Console.WriteLine("clean coding books");
    break;

    case "e":
    Console.WriteLine("EF core books");
    break;
    default:
     Console.WriteLine("does not exist");
    break;
}



