using System;

namespace RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()); // get the number 

            DrawFigure(count);

        }

        static void DrawFigure(int count)
        {
            if (count == 0)
            {
                return;
            }

            // before 
            Console.WriteLine(new String('*', count)); //  print the * descending

            // body  of the recursion
            DrawFigure(count - 1); 


            // after 

            Console.WriteLine(new String('#', count)); // print the # ascending

        }
    }
}
