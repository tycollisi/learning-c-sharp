Console.WriteLine("Hello, Calculator!");
Console.WriteLine("Input the first number:");

var firstNumber = Console.ReadLine();

Console.WriteLine("Input the second number:");
var secondNumber = Console.ReadLine();

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

var operation = Console.ReadLine().ToUpper();

Calculator(firstNumber, operation, secondNumber);
Console.WriteLine("Press any key to close.");
Console.ReadKey();

void Calculator(string firstNumber, string operation, string secondNumber)
{
  var parsedFirstNumber = int.Parse(firstNumber);
  var parsedSecondNumber = int.Parse(secondNumber);

  if(operation == "A")
  {
    var solution = parsedFirstNumber + parsedSecondNumber;
    ReturnEquation(parsedFirstNumber, "+", parsedSecondNumber, solution);
  }
  else if(operation == "S")
  {
    var solution = parsedFirstNumber - parsedSecondNumber;
    ReturnEquation(parsedFirstNumber, "-", parsedSecondNumber, solution);

  }
  else if(operation == "M")
  {
    var solution = parsedFirstNumber * parsedSecondNumber;
    ReturnEquation(parsedFirstNumber, "*", parsedSecondNumber, solution);
  }
  else
  {
    Console.WriteLine("Invalid choice!");
  }
}

void ReturnEquation(int firstNumber, string operation, int secondNumber, int solution)
{
  Console.WriteLine(firstNumber + " " + operation + " " + secondNumber + " = " + solution);
}
