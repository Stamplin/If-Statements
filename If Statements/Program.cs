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
double.TryParse(Console.ReadLine(), out selection);
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
int spesNum, numGuess;
spesNum = 7;
Console.WriteLine("Welcoming to the goofy ahh guessing game please input a number from 1-10");
Console.WriteLine("Your number:");
int.TryParse(Console.ReadLine(), out numGuess);
if (numGuess == spesNum)
{
    Console.WriteLine("Bingo correct!!");
}
else if (numGuess != spesNum)
{
    Console.WriteLine("Wrong number! The number is " + spesNum);
}


//Mini Wuiz
int quizScore, quizQ1;
quizScore = 0;
Console.WriteLine("Welcome to the mini quiz, where you'll be asked mini sized questions.");
Console.WriteLine("");
Console.WriteLine("Question 1: What is 8^2+5?");
//prep for the mini quiz
int.TryParse(Console.ReadLine(), out quizQ1);
//question 1 (Numbers)
if (quizQ1 == 69)
{
    Console.WriteLine("Correct. Nice. +1p"); quizScore = +1;
}
else if (quizQ1 <= 70 && quizQ1 >= 60)
{
    Console.WriteLine("Very close but that aint right, Nice try.");
}
else if (quizQ1 > 70 || quizQ1 < 60)
{
    Console.WriteLine("Yeah.. Nah you're not even close.");
}
//question 2 (writing)
string quizQ2;
Console.WriteLine();
Console.WriteLine("Are you dead? \n There only one answer don't lie.");
quizQ2 = Console.ReadLine().ToUpper();
if (quizQ2 == "YES")
{
    Console.WriteLine("Dead people dont do quizzes, you liar. No score for you.");
}
else if (quizQ2 == "NO")
{
    Console.WriteLine("Make sense... aight u get a point. +1p"); quizScore = +1;
}
//question 3 mutiple choice
Console.WriteLine();


Console.ReadLine();
