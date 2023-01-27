//This is a comment

//rakendus küsib kasutajal sisetada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter Your name:"); //Output
//string - sõne
string userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output
//string interpolation
Console.WriteLine($"Hello, {userName}!"); //Output