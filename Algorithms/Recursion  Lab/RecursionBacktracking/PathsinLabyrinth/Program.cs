using System;
using System.Collections.Generic;
using System.Linq;

namespace PathsinLabyrinth
{
    class Program
    {
        static List<char> path = new List<char>();
        static char[,] field;

        static void Reader()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            field = new char[width, length];

            for (int row = 0; row < width; row++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < length; col++)
                {
                    field[row, col] = inputRow[col];
                }
            }

        }

      

        static void FindPath(int row, int col, char direction)
        {
            if (!IsInBound(row, col))
            {
                return;

            }

            path.Add(direction);

            if (IsExit(row, col))
            {
                Print();
            }

            else if (!IsVisited(row, col) && !IsWall(row, col))
            {
                MarkVisited(row, col);
                FindPath(row, col + 1, 'R');
                FindPath(row + 1, col, 'D');
                FindPath(row, col - 1, 'L');
                FindPath(row - 1, col, 'U');
                UnMarkField(row, col);
            }

            path.RemoveAt(path.Count - 1);
        }

        static bool IsInBound(int row, int col)
        {

            if (row < 0
             || row >= field.GetLength(0)
             || col < 0
             || col >= field.GetLength(1))
            {
                return false;
            }

            return true;

        }

        static bool IsExit(int row, int col)
        {
            if (field[row, col] == 'e')
            {
                return true;
            }

            return false;
        }

        static bool IsVisited(int row, int col)
        {

            if (field[row, col] == 'X') // has been visited 
            {

                return true;
            }


            return false;
        }

        static void Print()
        {
            Console.WriteLine(String.Join(string.Empty, path.Skip(1)));

        }

        static void MarkVisited(int row, int col)
        {
            field[row, col] = 'X';
        }

        static bool IsWall(int row, int col)
        {
            if (field[row, col] == '*')
            {
                return true;
            }

            return false;

        }

        static void UnMarkField(int row, int col)
        {
            field[row, col] = '-';

        }

        static void Main(string[] args)
        {

            Reader();
            FindPath(0, 0, 'S');


        }

    }
}
