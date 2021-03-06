﻿using ConsoleEffects;
using System;
using static System.Console;
using static System.ConsoleColor;

namespace ConsoleExpressions
{
    /// <summary>
    /// This has become quite a mess, but has been fun.
    /// </summary>
    class Program
    {

        static ConsoleHistory _consoleHistory = new ConsoleHistory();
        static BackgroundEffects _backgroundEffects = new BackgroundEffects(_consoleHistory);
        static TextPrinter _textPrinter;
        //static int _width;
        //static int _height;
        //static Point _target;
        //public struct Point {
        //    public static int x;
        //    public static int y;
        //    public int X;
        //    public int Y;
        //}
        static void Main(string[] args)
        {
            while (true)
            {
                string input = ReadLine();
                _consoleHistory.Add(input);
                input = input.ToLower().Trim();

                if (input == "jog")
                {
                    Jogger.Jog(5, 5);
                    System.Threading.Thread.Sleep(1000);
                    Jogger.Bottom();
                    System.Threading.Thread.Sleep(1000);
                    Jogger.CenterHorizontal();
                    System.Threading.Thread.Sleep(1000);
                    Jogger.CenterVertical();
                    System.Threading.Thread.Sleep(1000);
                    Jogger.End();
                    System.Threading.Thread.Sleep(1000);
                    Jogger.Home();
                    System.Threading.Thread.Sleep(1000);
                    Jogger.Top();


                }

                if (input == "strobe")
                {
                    _backgroundEffects.StrobeRandom(count: 30, new Milliseconds(10));
                }

                if (input == "print")
                {
                    _textPrinter = new TextPrinter("Print a thing");
                    _textPrinter.Print();
                    _textPrinter.Type();
                }

                if (input == "cycle")
                {
                    _backgroundEffects.CycleRandom(new Milliseconds(10));
                }
            }

            //_width = Console.WindowWidth;
            //_height = Console.WindowHeight;

            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.Clear();
            //SetTarget(new Random().Next(0, _width), new Random().Next(0, _height));
            //while (true)
            //{

            //    string input = Console.ReadLine();
            //    Fire(input);
            //    ////Speak(input);
            //    //int ceilingX = Console.WindowWidth;
            //    //int ceilingY = Console.WindowHeight;
            //    //Point.x = new Random().Next(0, ceilingX);
            //    //Point.y = new Random().Next(0, ceilingY);

            //    //SetCursor();
            //    //Color();
            //    //Stroke(1);


            //    //System.Threading.Thread.Sleep(5);

            //    //    Color();
            //    //    Stroke(1);

            //    //_width = Console.WindowWidth;
            //    //_height = Console.WindowHeight;

            //    //Point.x = Console.CursorLeft;
            //    //Point.y = Console.CursorTop;
            //    ////object character = Console.Read();
            //    ////object key = Console.ReadKey();
            //    //string input = Console.ReadLine().ToLower();
            //    //if (input == "d")
            //    //{
            //    //    Speak($"Width: {_width}");
            //    //    Speak($"Height: {_height}");
            //    //    Speak($"Point: {Point.x}:{Point.y}");
            //    //    //Speak($"key: { key }");
            //    //    //Speak($"character: { character }");
            //    //}
            //    ////NOTE: sample input color x y
            //    //if (input.StartsWith("color"))
            //    //{
            //    //    SetCursor(int.Parse(input.Split(' ')[1]), int.Parse(input.Split(' ')[2]));
            //    //    Color();
            //    //    Stroke(1);
            //    //}
            //}
        }

        //private static void Fire(string input)
        //{
        //    Console.SetCursorPosition(int.Parse(input.Split(" ")[0]), int.Parse(input.Split(" ")[1]));
        //    Color(ConsoleColor.Blue);
        //    Stroke(1);
        //    Home();
        //    if (Console.CursorLeft == _target.X && Console.CursorTop == _target.Y)
        //    {
        //        Console.WriteLine("Hit!!!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Miss!");
        //    }
        //}

        //private static void SetTarget(int v1, int v2)
        //{
        //    _target = new Point { X = v1, Y = v2 };
        //    SetCursor(v1, v2);
        //    Color(ConsoleColor.Red);
        //    Stroke(1);
        //    Home();
        //}

        //private static void Home()
        //{
        //    SetCursor(0,0);
        //}

        //private static void SetCursor()
        //{
        //    Console.SetCursorPosition(Point.x, Point.y);
        //}

        //private static void Stroke(int units)
        //{
        //    Console.Write(" ");
        //}

        //private static void SetCursor(int x, int y)
        //{
        //    Console.SetCursorPosition(x, y);
        //}

        //static void Color(ConsoleColor color)
        //{
        //    Console.BackgroundColor = color;
        //    //Console.BackgroundColor = (ConsoleColor)new Random().Next(0, 15);
        //}

        //static void Speak(object utterance)
        //{
        //    SetCursor(0, 0);
        //    Console.WriteLine(utterance);
        //}
    }
}
