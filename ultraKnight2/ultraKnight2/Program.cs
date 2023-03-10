using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            int row = 10, col = 10;

            Console.SetCursorPosition(col, row);
            Console.Write("P");

            Console.CursorVisible = false;
            // Controladores
            while (true)
            {
                tecla = Console.ReadKey();
                // Subir
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (row > 0)
                    row--;
                    Console.SetCursorPosition(col, row);
                    Console.Write("P");
                }
                // Bajar
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (row < 79) ;
                    row++;
                    Console.SetCursorPosition(col, row);
                    Console.Write("P");
                }
                // Izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (col > 0)
                        col--;
                    Console.SetCursorPosition(col, row);
                    Console.Write("P");
                }
                // Derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if(col < 79)
                    col++;
                    Console.SetCursorPosition(col, row);
                    Console.Write("P");
                }
                if (tecla.Key == ConsoleKey.Escape)
                    break;
            }
            Console.CursorVisible = true;


        }
    }
}