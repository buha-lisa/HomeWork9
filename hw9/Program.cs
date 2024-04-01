namespace hw9
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        var vector1 = new Vector(14, 2, 5);
                        var vector2 = new Vector(4, 4, 1);
                        Console.WriteLine($"Vector 1: {vector1}");
                        Console.WriteLine($"Vector 2: {vector2}");

                        var sum = vector1.Addition(vector2);
                        Console.WriteLine($"Sum: {sum}");
                        var difference = vector1.Subtraction(vector2);
                        Console.WriteLine($"Difference: {difference}");
                        var product = vector1.MultiplicationOnNumber(4);
                        Console.WriteLine($"Product: {product}");
                        break;
                    case 2:
                        var number = new DecimalNumber("98");
                        Console.WriteLine($"Decimal: {number}");

                        var binaryNum = number.DecimalToBinary();
                        Console.WriteLine($"Binary: {binaryNum}");

                        var octalNum = number.DecimalToOctal();
                        Console.WriteLine($"Octal: {octalNum}");

                        var hexadecimalNum = number.DecimalToHexadecimal();
                        Console.WriteLine($"Hexadecimal: {hexadecimalNum}");
                        break;
                    case 3:
                        var color = new RGBcolor(255, 0, 0);

                        Console.WriteLine($"RGB:  {color}");
                        Console.WriteLine($"Hex:  {color.RGBToHEX()}");
                        color.RGBToHSL();
                        color.RGBToCMYK();
                        break;
                }
                if (task == 0) break;
            }
        }
    }
}
