namespace Rovy_Assignment_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // Problem 1: Display digits using recursion
            // -------------------------------
            Console.Write("Input any number: ");// prompt user for input
            var inputNumber = Console.ReadLine();// read user input

            // Validate input and convert to integer
            if (!int.TryParse(inputNumber, out var number))
            {
                // Handle invalid input
                Console.WriteLine("Invalid number input.");
                return;
            }

            // Display digits using recursion
            Console.Write($"The digits in the number {number} are: ");
            PrintDigits(number);
            Console.WriteLine(); // newline

            // -------------------------------
            // Problem 2: Sum of right diagonal of a matrix
            // -------------------------------
            Console.Write("\nInput the size of the square matrix: ");
            var inputSize = Console.ReadLine();

            // Validate input and convert to integer
            if (!int.TryParse(inputSize, out var size) || size <= 0)
            {
                // Handle invalid input
                Console.WriteLine("Invalid matrix size.");
                return;
            }

            // Initialize the matrix
            var matrix = new int[size, size];

            Console.WriteLine("Input elements in the matrix:");
            for (var i = 0; i < size; i++) // loop through rows
            {
                for (var j = 0; j < size; j++) // loop through columns
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    var elementInput = Console.ReadLine(); // read element input

                    // Validate input and convert to integer
                    if (!int.TryParse(elementInput, out var value))
                    {
                        // Handle invalid input
                        Console.WriteLine("Invalid element input. Defaulting to 0.");
                        value = 0;//
                    }

                    matrix[i, j] = value;// assign value to matrix element
                }
            }

            // Display matrix
            Console.WriteLine("\nThe matrix is:");
            for (var i = 0; i < size; i++) //
            {
                for (var j = 0; j < size; j++) // loop through columns
                {
                    Console.Write(matrix[i, j] + " ");// print element followed by space
                }
                Console.WriteLine();// newline after each row
            }

            // Calculate right diagonal sum
            var diagonalSum = 0;
            for (var i = 0; i < size; i++)// loop through rows
            {
                var j = size - 1 - i;// calculate column index for right diagonal
                diagonalSum += matrix[i, j];// add right diagonal element to sum
            }
            // Display the sum of right diagonal elements
            Console.WriteLine($"\nAddition of the right diagonal elements is : {diagonalSum}");
        }

        // Recursive method to print digits from left to right
        static void PrintDigits(int n)
        {
            if (n < 10) // Base case: if n is a single digit, print it and return
            {
                Console.Write(n + " ");// print the single digit followed by space
                return;
            }

            // Process all higher-order digits first
            PrintDigits(n / 10);

            // Then print the last digit
            Console.Write((n % 10) + " ");
        }
    }
}
