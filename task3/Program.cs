Console.WriteLine("enter date");
string input = Console.ReadLine();
dateFunction(input);
static void dateFunction(string input){
    DateTime Data = DateTime.Parse(input);
DateTime output = Data.AddDays(7);
Console.WriteLine($"{output.ToString("dd/MMM/yy")}");
}




