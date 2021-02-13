using System;

namespace ConsoleExpressions
{
    class Program
    {
        static int _width;
        static int _height;
        public struct Point {
            public static int x;
            public static int y;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int ceilingX = Console.WindowWidth;
                int ceilingY = Console.WindowHeight;
                Point.x = new Random().Next(0, ceilingX);
                Point.y = new Random().Next(0, ceilingY);

                SetCursor();
                Color();
                Stroke(1);
                System.Threading.Thread.Sleep(5);
                //    Color();
                //    Stroke(1);

                //_width = Console.WindowWidth;
                //_height = Console.WindowHeight;

                //Point.x = Console.CursorLeft;
                //Point.y = Console.CursorTop;
                ////object character = Console.Read();
                ////object key = Console.ReadKey();
                //string input = Console.ReadLine().ToLower();
                //if (input == "d")
                //{
                //    Speak($"Width: {_width}");
                //    Speak($"Height: {_height}");
                //    Speak($"Point: {Point.x}:{Point.y}");
                //    //Speak($"key: { key }");
                //    //Speak($"character: { character }");
                //}
                ////NOTE: sample input color x y
                //if (input.StartsWith("color"))
                //{
                //    SetCursor(int.Parse(input.Split(' ')[1]), int.Parse(input.Split(' ')[2]));
                //    Color();
                //    Stroke(1);
                //}
            }
        }

        private static void SetCursor()
        {
            Console.SetCursorPosition(Point.x, Point.y);
        }

        private static void Stroke(int units)
        {
            Console.Write(" ");
        }

        private static void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Color()
        {
            Console.BackgroundColor = (ConsoleColor)new Random().Next(0, 15);
        }

        static void Speak(object utterance)
        {
            Console.WriteLine(utterance);
        }
    }
}
