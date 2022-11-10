// Console.WriteLine("enter number");
// int num = Convert.ToInt32(Console.ReadLine());
int[] myNum = {1,2,3,4,5,6,7,8,9};
// Console.WriteLine(num);
foreach(int num in myNum){
    
    if(num == 8){
        Console.WriteLine("break");
        break;
        
    }
    if(num == 2){
        Console.WriteLine("skip 2");
        continue;
        
    }
    Console.WriteLine(num);
    
}
