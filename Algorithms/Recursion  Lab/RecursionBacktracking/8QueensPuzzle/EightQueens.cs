using System;
using System.Collections.Generic;

namespace _8QueensPuzzle
{
    class EightQueens
    {
        private const int Size = 8;
        static bool[,] chessBoard = new bool[Size, Size];

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

       // static int solutionsFound = 1; 

        static void Main(string[] args)
        {
            PutQueen(0);
        }

        static void PutQueen(int row)
        {
            if (row == Size)
            {
                PrintSolution();
                return;
                 
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueen(row + 1);
                        UnMarkAllAttackedPositions(row, col);

                    }
                }
            }

        }

        private static void UnMarkAllAttackedPositions(int row, int col)
        {
            
            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(row + col);
            chessBoard[row, col] = false;
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(row + col);
            chessBoard[row, col] = true;

        }

        private static bool CanPlaceQueen(int row, int col)
        {
            if (attackedRows.Contains(row)
             || attackedCols.Contains(col)
             || attackedLeftDiagonals.Contains(col-row)
             || attackedRightDiagonals.Contains(row+col))
            {
                return false;
            }

            return true; //???


        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (chessBoard[row, col] == true)
                    {
                        Console.Write("* ");
                    }

                    else
                    {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
           // Console.WriteLine(solutionsFound++);
             
        }

    }
}
