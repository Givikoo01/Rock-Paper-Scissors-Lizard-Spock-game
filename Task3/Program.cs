using Org.BouncyCastle.Security;
using Task3;


if (args.Length != args.Distinct().Count())
{
    Console.WriteLine("Command line arguments contain duplicates! Try again!");
    return;
}

if (args.Length < 3 || args.Length % 2 == 0)
{
    Console.WriteLine("Incorrect number of arguments. Please provide an odd number >= 3.");
    Console.WriteLine("Ex: dotnet run Rock Paper Scissors");
    return;
}

    Random rand = new Random();
    string key = KeyGeneration.GenerateKey();

    int computerMove = rand.Next(1, args.Length+1); //1- rock, 2-spock, 3 - paper etc...
    string hmac = GenerateHMAC.GetHMAC(computerMove.ToString(), key);
    Console.WriteLine($"HMAC: {hmac}");

    DisplayTable displayTable = new DisplayTable(args);
    ShowWinner showWinner = new ShowWinner(args, computerMove, key);
