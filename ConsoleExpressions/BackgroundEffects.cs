using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Threading.Thread;

namespace ConsoleExpressions
{
    internal class BackgroundEffects
    {
        ConsoleHistory _consoleHistory;
        public BackgroundEffects(ConsoleHistory consoleHistory)
        {
            _consoleHistory = consoleHistory;
        }

        internal void StrobeRandom(int count, Milliseconds rate)
        {
            ConsoleColor c1 = (ConsoleColor)new Random().Next(0, 15);
            ConsoleColor c2 = (ConsoleColor)new Random().Next(0, 15);

            Strobe(c1, c2, count, rate);

        }

        internal void Strobe(ConsoleColor c1, ConsoleColor c2, int count, Milliseconds rate)
        {

            --count;
            BackgroundColor = c1;
            Clear();
            Sleep(rate.Value);
            if (count > 0)
            {
                Strobe(c2, c1, count, rate);
            }
            else
            {
                _consoleHistory.WriteAll();
            }

        }

        //:--((
        internal void CycleRandom(Milliseconds duration)
        {
            List<int> colors = new List<int>();
            for (int i =0;i<GetNumberOfColors();i++)
            {
                colors.Add(i);
            }

            colors.Shuffle();

            foreach (int color in colors)
            {
                BackgroundColor = (ConsoleColor)color;
                Clear();
                Sleep(duration.Value);
            }
        }

        //DO this recursively for giggles.
        internal void Cycle(Milliseconds duration)
        {
            int numberOfColors = GetNumberOfColors();
            for (int i = 0; i < numberOfColors; i++)
            {
                BackgroundColor = (ConsoleColor)i;
                Clear();
                Sleep(duration.Value);
            }

            _consoleHistory.WriteAll();
        }

        private int GetNumberOfColors()
        {
            return Enum.GetNames(typeof(ConsoleColor)).Length;
        }
    }
}
