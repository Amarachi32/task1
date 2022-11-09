// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Amara!");

Console.WriteLine("enter text");
string input = Console.ReadLine();
int size = input.Length;
// Console.WriteLine(size);
char hash = '#';
string outputText = "";
string firstLetters = input.Substring(0, size-4);
Console.WriteLine(firstLetters);

string lastFour = input.Substring(size-4);
Console.WriteLine(lastFour);

foreach(char letters in firstLetters){
    outputText +=  hash;
}
foreach(char letters in lastFour){
    outputText +=  letters;
}
// string result = firstLetters + lastFour;
Console.WriteLine(outputText);