Console.WriteLine("Enter Text");
// string output = " ";

string input = Console.ReadLine();
// int size = input.Length;
List <int> indexes = new List<int>();
for(int i=0; i<=input.Length-1; i++){
    if(input[i] >= 'A' && input[i] <= 'Z'){
        indexes.Add(i);
        // Console.WriteLine("hello");
    }
}

// Console.WriteLine(indexes);
foreach(int num in indexes){
    Console.WriteLine($"{num} : {input[num]}");
}
