Console.WriteLine("enter username");
string username = Console.ReadLine();

Console.WriteLine("enter password");
string password = Console.ReadLine();

User myobj = new();
myobj.Username = username;
myobj.Password = password;

Console.WriteLine("enter yes to login or no to exit");
string input  = Console.ReadLine();
string auth = input.ToLower();

// to login
switch(auth){
    case "yes":{
         Console.WriteLine("enter your username");
        string user =Console.ReadLine();
        Console.WriteLine("enter your password");
        string pass = Console.ReadLine();
        

        if(myobj.Username == user && myobj.Password == pass){
            Console.WriteLine("login successful");
            break;
        }else{
            Console.WriteLine("invalid username or password");
            break;
        }
        
    }
    break;

    default :{
         Console.WriteLine("logout successful");
    }
    break;
}

class User{
    public string Username {get; set;}
    public string Password {get; set;}
}






