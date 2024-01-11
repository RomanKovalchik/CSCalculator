// See https://aka.ms/new-console-template for more information
using Calculator;

double val1 = 0;
double val2 = 0;
char opcode = ' ';

string input = "";

do {

    
    
    Console.WriteLine("Enter number 1");
    val1  = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter number 2");
    val2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter action, like '+', '-', '*', '/'");
    opcode = Convert.ToChar(Console.ReadLine());
    double val = Calculator.Calculator.calculate(val1, val2, opcode);
    
    Console.WriteLine(val);
    Console.WriteLine("Would you like to continue? If yes - press 'y' key");
    input = Console.ReadLine();

} while (input == "Y"|| input=="y");


