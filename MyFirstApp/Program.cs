// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajal sisestada tema nime 
//Rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter your name:");
//string- sõne
string UserName = Console. ReadLine();

//string interpolation 
Console.WriteLine($"Hello, {UserName} !"); 

Console.WriteLine("Enter your password");
string Password = Console.ReadLine();