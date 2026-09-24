using dotnet_learning.Classes___Objects;

Console.WriteLine("***dotnet learning***");
Console.WriteLine("1. classes and objects\n");

// "new" keyword: "allocate ram memory for a new player"
Player player1= new Player();

// properties 
player1.username = "username1";
player1.health = 100;
player1.level = 1;

Player player2= new Player();

player2.username = "username2";
player2.health = 260;
player2.level = 6;

player1.TakeDamage(30);
player2.heal(25);

