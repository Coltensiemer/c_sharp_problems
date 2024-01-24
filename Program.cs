
// initialize variables - graded assignments 
using System.Data.Common;
using System.Runtime.InteropServices;

// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;
// var sophiaSum = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5);
// var sophiaScore = (decimal)sophiaSum / currentAssignments;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;
// var nicolasSum = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5);
// var nicolasScore = (decimal)nicolasSum / currentAssignments;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;
// var zahirahSum = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5);
// var zahirahSCore = (decimal)zahirahSum / currentAssignments;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;
// var jeongSum = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5);
// var jeongScore = (decimal)jeongSum / currentAssignments;


// Console.WriteLine("Student\tGrade"); 
// Console.WriteLine("Sophia\t" + sophiaScore); 
// Console.WriteLine("Jeong\t" + jeongScore); 
// Console.WriteLine("Zahirah\t" + zahirahSCore); 
// Console.WriteLine("Nicolas\t" + nicolasScore); 


// Random dice = new(); 
// int roll1 = dice.Next();
// int roll2 = dice.Next(50);
// int roll3 = dice.Next(90,100); 

// Console.WriteLine(roll1);
// Console.WriteLine(roll2);
// Console.WriteLine(roll3);



int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

////////////////////////////
///


// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if (total > 14) { 
// 	Console.WriteLine("You Win"); 
// }
// if (total < 15) { 
// 	Console.WriteLine("Sorry, you lose"); 
// }

////////////////////////
///

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }


/////////////////////

// string[] orderIDs = new string[3]; 
// orderIDs[0] = "1123"; 
// orderIDs[1] = "A123";
// orderIDs[2] = "B123";
// // orderIDs[3] = "C123"; 

// Console.WriteLine($"First: {orderIDs[0]}"); 
// Console.WriteLine($"Second: {orderIDs[1]}"); 
// Console.WriteLine($"third: {orderIDs[2]}"); 

// orderIDs[0] = "replaced";

// Console.WriteLine($"First again: {orderIDs[0]}");

// int[] inventory = { 200, 450, 700, 175, 250 };
// 	int sum = 0; 
// 	int bin = 0; 

// foreach(int items in inventory) { 
// 	bin++; 
// 	sum+= items; 
// 	Console.WriteLine($"{bin} = {items}"); 
// }

// Console.WriteLine($"We have {sum} items in inventory"); 


/////////////////////////

// string[] order = {"B123",
// "C234",
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179"};

// foreach (string id in order)
// {
// 	if (id.StartsWith("B"))
// 	{
// 		Console.WriteLine($"{id} may be fraudulent");
// 	}

// }

////////////////



// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

//  foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42){
// 	bool found = true;
// 	if (found) Console.WriteLine("Set contains 42");
// 	} 

    
// Console.WriteLine($"Total: {total}");

// }

//////////////////////


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

// Console.WriteLine($"Product: {size} {color} {type}");


///////////////////////////////
///


for (int i =10; i>= 0; i--) { 
Console.WriteLine(i); 
if (i == 7) break; 

}
