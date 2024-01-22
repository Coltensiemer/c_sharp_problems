
// initialize variables - graded assignments 
using System.Data.Common;

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
var sophiaSum = (sophia1 +sophia2 + sophia3 +sophia4 + sophia5);
var sophiaScore = (decimal) sophiaSum/currentAssignments; 

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
var nicolasSum = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5);
var nicolasScore = (decimal) nicolasSum/currentAssignments; 

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
var zahirahSum = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5); 
var zahirahSCore =  (decimal) zahirahSum/currentAssignments;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
var jeongSum = (jeong1 +jeong2 + jeong3 + jeong4 + jeong5); 
var jeongScore = (decimal) jeongSum/currentAssignments;


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

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}




