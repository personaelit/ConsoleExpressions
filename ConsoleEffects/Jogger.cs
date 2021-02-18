using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleEffects
{
    public static class Jogger
    {
        public static void Jog(int x, int y) {
            SetCursorPosition(x, y);
        }
        public static void CenterVertical() {
            CursorTop = WindowHeight.IsOdd() ? WindowHeight / 2 + 1 : WindowHeight / 2;
        }
        public static void CenterHorizontal() {
            CursorLeft = WindowWidth.IsOdd() ? WindowWidth / 2 + 1 : WindowWidth / 2;
        }
        public static void Bottom() {
            CursorTop = WindowHeight;
        }
        public static void Top() {
            CursorTop = 0;
        }
        public static void End() {
            var fpp = "bar;";
            CursorLeft = 0;
            CursorLeft = BufferWidth -1;
        }
        public static void Home() {
            CursorLeft = 0;
        }

    }
}
