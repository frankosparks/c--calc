namespace calc;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        while(true){
            Console.WriteLine("Enter first number:");
            if(!double.TryParse(Console.ReadLine(),out double num1)){
                Console.WriteLine("Invalid input.Please enter a valid number.");
                continue;
            }
            Console.WriteLine("Enter operator(+,-,*,/):");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter second number:");
            if(!double.TryParse(Console.ReadLine(),out double num2)){
                Console.WriteLine("Invalid input.Please enter a valid number.");
                continue;
                
            }
            double result = 0;
            switch (operation){
                case '+':
                result=num1+num2;
                break;
                case '-':
                result=num1-num2;
                break;
                case '*':
                result=num1*num2;
                break;
                case '/':
                while(num2==0){
                    Console.WriteLine("Enter a non-zero devisor.");
                    num2 = Convert.ToDouble(Console.ReadLine());
                
                }
                decimal quotient = (decimal)num1 / (decimal)num2;
                result = num1/num2;
                break;
            }
            Console.WriteLine($"Result:{result}");
            Console.Write("Do you want to perform another calculation?(Y/N):");
            char continueCalculation=Console.ReadKey().KeyChar;
            Console.WriteLine();
            if(char.ToUpper(continueCalculation)!='Y')
            break;
        }
    }
}
