using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace Prog120_S24_L14_Matricies
{
    internal class Program
    {

        // 2d Array - Matrix
        // 1 2 3 4 5
        // 6 7 8 9 10
        // datatype[,] name = new datatype[sizeX,sizeY];
        // In trials X represents different trials, y represents our fields
        static int[,] intMatrix = new int[3,3];
        static int[,] randomMatrix;
        
        static void Main(string[] args)
        {
            char[,] board = {
              {'X', 'O', ' '},  // Row 1
              {' ', 'X', 'O'},  // Row 2
              {'O', ' ', 'X'},  // Row 3
            };

            char[,] board2 = {
                {'x', ' ', 'o' },
                { 'o', ' ', 'o'},
                {'x', ' ', 'o' }
            };

            if(CheckForWin(board2))
            {
                Console.WriteLine("This board has a winner");
                // If(X is the winner) Console.WriteLine(X Won)
            }
            else
            {
                Console.WriteLine("THis is a loosing Board");
            }

        } // Main

        public static bool CheckForWin(char[,] board)
        {
            // Write the code to check the board to see if it is a winning board.
            // Extra Credit 10 POints - Check to see if either player won on the diagnol
            // Extra Credit 10 Points - Check to see if any player won on the vertical or horizontal
            // Extra Credit - Display who won 
            return false;
        }

        // You will create a program, method, than when you pass in a 2d array of char
        // char[3,3]

        // You will check to see if the 2d array is a winning game of tic tac toe

        public static void MatrixExample2()
        {
            randomMatrix = PopulateIntMatrix(5, 5);
            DisplayMatrix(randomMatrix);
            Console.WriteLine();

            Console.Write("Diangonal: ");
            for (int x = 0; x < randomMatrix.GetLength(0); x++)
            {
                Console.Write(randomMatrix[x, x] + " ");
            }
        }

        public static int[,] PopulateIntMatrix(int xSize, int ySize)
        {
            int[,] temp = new int[xSize, ySize];
            Random rand = new Random();

            for (int x = 0; x < temp.GetLength(0); x++)
            {
                for (int y = 0; y < temp.GetLength(1); y++)
                {
                    temp[x, y] = rand.Next(1, 100);
                }
            }

            return temp;
        }

        public static void DisplayMatrix(int[,] matrix )
        {

            int xAxisLength = matrix.GetLength(0);
            int yAxisLength = matrix.GetLength(1);

            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.Write(matrix[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void FirstMatrixExample()
        {
            // Array.GetLength(dimension)
            Console.WriteLine(intMatrix.GetLength(0));

            int xAxisLength = intMatrix.GetLength(0);
            int yAxisLength = intMatrix.GetLength(1);

            intMatrix[0, 0] = 876;
            intMatrix[1, 0] = 123;

            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.WriteLine(intMatrix[x, y]);
                }
            }
        }

        public static void NestedLoopsExample()
        {
            // Nested Loops and Matricies

            // Nested Loops
            for (int i = 0; i < 7; i++)
            {
                Console.Write(i + ": ");

                // Place another loop INSIDE of our first loop
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }



        // -----------------------------------------------------

        //Assignment: Write a C# program that calculates the factorial of a given non-negative integer using a loop. The factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example, the factorial of 5 (5!) is calculated as 5 * 4 * 3 * 2 * 1 = 120.

        //Requirements:

        //Prompt the user to enter a non-negative integer.
        //Validate the user input to ensure it is a non-negative integer.
        //Calculate and print the factorial of the entered integer using a loop(for or while loop).
        //Feel free to ask if you need any further clarification or assistance!

        //public static double Factorial(double number)
        //{
        //    double total = 1;

        //    for (double i = number; i > 0; i--)
        //    {
        //        total *= i;
        //    }

        //    return total;
        //}


    } // class

} // namespace
