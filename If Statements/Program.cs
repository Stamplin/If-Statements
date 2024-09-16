//SPACE BOXING

double weight, selection, venus, mars, jupiter, saturn, uranus, neptune; 
venus = 0.78;
mars = 0.39;
jupiter = 2.65; 
saturn = 1.17;
uranus = 1.05;
neptune = 1.23;
Console.WriteLine("\r\n #1 Venus \r\n #2 Mars \r\n #3 Jupiter \r\n #4 Saturn \r\n #5 Uranus \r\n #6 Neptune \r\n");
Console.WriteLine("Please enter your current weight on earth: "); //ASK FOR WEIGHT FOR THE MATH LATER ON
double.TryParse(Console.ReadLine(), out weight);
Console.WriteLine("Select a planet listed above: "); //SELECTION TO SEE WHICH TO PICK FOR THE MATH
double.TryParse(Console.ReadLine(),out selection);
if (selection == 1)
{
    Console.WriteLine("Your weight would be: " + Math.Round(weight * venus));
}
else if (selection == 2)
{
    Console.WriteLine("Your weight would be: " + Math.Round(weight * mars));
}
else if (selection == 3)
{
    Console.WriteLine("Your weight would be: " + Math.Round(weight * jupiter));
}
else if (selection == 4)
{
    Console.WriteLine("Your weight would be: " + Math.Round(weight * saturn));
}
else if (selection == 5)
{
    Console.WriteLine("Your weight would be: " + Math.Round(weight * uranus));
}
else if (selection == 6)
{
    Console.WriteLine("Your weight would be: " + Math.Round(weight * neptune));
}

Console.ReadLine();
Console.WriteLine("Press enter to move to the next part");
Console.Clear();

//SILLY GUESSING GAME
int spesNum;
spesNum = 7;
Console.WriteLine("Welcoming to the goofy ahh guessing game please input a number from 1-10");
Console.WriteLine("Your number:");
int.TryParse(Console.ReadLine(), out spesNum);
if (spesNum == 7)
{
    Console.WriteLine("Bingo correct it is 7!!");
}
else if (spesNum < 10)
{
    Console.WriteLine("Your number is lower than 10!");
}
else if (spesNum > 10)
{
    Console.WriteLine("Your number is higher than 10!");
}