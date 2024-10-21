using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        string Number1 = Console.ReadLine();
        int NumberTyped = int.Parse(Number1);

        switch (NumberTyped)
        {
            case 0:
                Console.WriteLine("Your number is zero");
                break;
            case 1:
                Console.WriteLine("Your  number is one ");
                break;
            case 2:
                Console.WriteLine("Your number is two");
                break;
            case 3:
                Console.WriteLine("Your number is three");
                break;
            case 4:
                Console.WriteLine("Your number is four");
                break;
            case 5:
                Console.WriteLine("Your number is five");
                break;
            case 6:
                Console.WriteLine("Your Number is six ");
                break;
                case 7:
                Console.WriteLine("Your number is seven");
                break;
                case 8: 
                Console.WriteLine("Your number is eight ");
                break;
                case 9:
                Console.WriteLine("Your number is nine");
                break;
                case 10:
                Console.WriteLine("Your number is ten");
                break;

            default:
                Console.WriteLine( "That number is out of range");
                break;

        }



    }
}
