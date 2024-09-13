
int poäng = 0;

Console.WriteLine("Fråga 1. Hur många ögon har en fluga?");
Console.WriteLine("a)800 b)2 c)6");
String svar1 = Console.ReadLine();
if (svar1 == "c")
{
  poäng++;
  Console.WriteLine("rätt");
  Console.ReadLine();

}

else 
{


Console.WriteLine("Så dålig");
Console.ReadLine();

}

Console.WriteLine("Fråga två. Hur gammal måste man minst vara för att kunna bli USAs president?");
Console.WriteLine("a)35 b)21 c)50");
String svar2 = Console.ReadLine();
if(svar2 == "a")
{
poäng++;
Console.WriteLine("rätt");
Console.ReadLine();

}

else

{

Console.WriteLine("fel");
Console.ReadLine();

}


Console.WriteLine("Fråga 3.Vilken färg har giraffens tunga?");
Console.WriteLine("a)blå-svart b)rosa c)röd-brun");
String svar3 = Console.ReadLine();

if (svar3 == "a")
{

poäng++;
Console.WriteLine("rätt");
Console.ReadLine();

}

else 

{

Console.WriteLine("fel");
Console.ReadLine();

}

Console.WriteLine($"Du fick {poäng} poäng!");
if( poäng == 0 )
{

Console.WriteLine("Så dålig");
Console.ReadLine();

}

else if (poäng < 3)

{

Console.WriteLine("Så bra");
Console.ReadLine();

}