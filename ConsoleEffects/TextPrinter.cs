using System;
using static System.Console;

namespace ConsoleEffects
{
    public class TextPrinter
    {
        string _message;
        public string Printed { get; private set; }
        public char[] Typed { get; private set; }
        public TextPrinter(string message)
        {
            _message = message;
        }

        public void Print()
        {
            Console.WriteLine(_message);
            Printed = _message;
        }

        public void Type()
        {
            Typed = _message.ToCharArray();
            foreach (char character in Typed)
            {
                Console.Write(character);
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
        }

        public void StarWars(string message)
        {
            //TODO: handle line breaks.
            //TODO: handle printing true center;

            //if (CursorTop < 0)
            //{
            //    Line
            //    Jogger.Jog(Console.WindowLeft, Console.CursorTop - 1);

            //}

        }
    }
}
