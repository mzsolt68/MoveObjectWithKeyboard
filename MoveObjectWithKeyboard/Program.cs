using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveObjectWithKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int OrigX, OrigY, NextX, NextY;
            NextX = 0;
            NextY = 0;
            OrigX = 0;
            OrigY = 0;
            Console.CursorVisible = false;
            PrintChar(OrigX, OrigY, NextX, NextY);
            ConsoleKey key = ConsoleKey.NoName;
            do
            {
                OrigX = Console.CursorLeft;
                OrigY = Console.CursorTop;

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.LeftArrow:
                            NextX = (OrigX == 0) ? OrigX : OrigX - 1;
                            break;
                        case ConsoleKey.UpArrow:
                            NextY = (OrigY == 0) ? OrigY : OrigY - 1;
                            break;
                        case ConsoleKey.RightArrow:
                            NextX = (OrigX == Console.WindowWidth - 1) ? OrigX : OrigX + 1;
                            break;
                        case ConsoleKey.DownArrow:
                            NextY = (OrigY == Console.WindowHeight - 1) ? OrigY : OrigY + 1;
                            break;
                        default:
                            break;
                    }
                    PrintChar(OrigX, OrigY, NextX, NextY);
                }
            } while (key != ConsoleKey.Escape);
        }

        private static void PrintChar(int delX, int delY, int printX, int printY)
        {
            Console.SetCursorPosition(delX, delY);
            Console.Write(' ');
            Console.SetCursorPosition(printX, printY);
            Console.Write("O\b");
        }
    }
}
