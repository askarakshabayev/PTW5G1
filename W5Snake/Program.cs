using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Wall wall = new Wall();
            while (true)
            {
                ConsoleKeyInfo pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (pressed.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (pressed.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (pressed.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (pressed.Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
                snake.Draw();
                wall.Draw();
            }
        }
    }
}
