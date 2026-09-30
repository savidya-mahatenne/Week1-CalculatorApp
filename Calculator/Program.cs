// This integer variable stores the first number
// Ask the user to type the first number
// int firstNumber = 5;
Console.WriteLine("Type in the first number, and then press Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// This integer variable stores the second number
// int secondNumber = 20;
// Ask the user to type the second number.
Console.WriteLine("Type the second number, and then press Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// The "result" variable contains the addition
// of firstNumber and secondNumber
// Note that the integer type is used for "result" variable
int result = firstNumber + secondNumber;
// Console.WriteLine("The addition of both numbers is {0}", result);

// Output the answer to the console
Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);

Console.ReadKey();