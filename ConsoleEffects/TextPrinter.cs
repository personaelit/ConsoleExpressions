using System;

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
    }
}
