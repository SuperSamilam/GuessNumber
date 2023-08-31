int random = new Random().Next(0,100);
Console.WriteLine("Gissa ett nummer mellan 0-100");
for (int i = 5; i > 0; i--){
    Console.WriteLine("Gissa ett nummer");
    int guess = Convert.ToInt32(Console.ReadLine());
    if (guess == random){
        Console.WriteLine("Du gissa rätt");
                break;
    }
    else if (guess < random){
        Console.WriteLine("Nummret är högre, Du har " + i.ToString() + " Gissningar kvar");
    }
    else if (guess > random){
        Console.WriteLine("Nummret är lägre, Du har " + i.ToString() + " Gissningar kvar");
    }
    Console.WriteLine("g");
}