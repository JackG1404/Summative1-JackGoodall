// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many days was the car hired for?");

int CarHireLength = int.Parse(Console.ReadLine());

Console.WriteLine("How much fuel was in liters was left in the tank?");

int FuelLeftInTank = int.Parse(Console.ReadLine());

float FuelUsed = 50 - FuelLeftInTank;

int HireTimeCost = CarHireLength * 25;

float HireFuelCost = (float)((float)FuelUsed * 2.5);

float TotalCost = HireFuelCost + HireTimeCost + 10;

Console.WriteLine("The total charge for the car hire is " + TotalCost.ToString("C");
