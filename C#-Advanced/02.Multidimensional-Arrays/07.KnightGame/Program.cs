using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    chessBoard[row, col] = input[col];
                }

                Console.WriteLine();
            }

            int count = 0;
            int knightRow = 0;
            int knightCol = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currentSymbol = chessBoard[row, col];
                        int countAttacks = 0;
                        if (currentSymbol == 'K')
                        {
                            if (IsInMatrix(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                countAttacks++;
                            }

                            if (IsInMatrix(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                countAttacks++;
                            }

                            if (IsInMatrix(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                countAttacks++;
                            }

                            if (IsInMatrix(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                countAttacks++;
                            }

                            if (IsInMatrix(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                countAttacks++;
                            }

                            if (IsInMatrix(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                countAttacks++;
                            }

                            if (IsInMatrix(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                countAttacks++;
                            }

                            if (IsInMatrix(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                countAttacks++;
                            }

                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                knightRow = row;
                                knightCol = col;
                            }

                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chessBoard[knightRow, knightCol] = '0';
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    break;
                }
            }

        }

        private static bool IsInMatrix(char[,] matrix, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0) && targetCol >= 0 && targetCol < matrix.GetLength(1);
        }
    }
}


