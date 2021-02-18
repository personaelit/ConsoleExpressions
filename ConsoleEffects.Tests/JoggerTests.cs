using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleEffects;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEffects.Tests
{
    [TestClass()]
    public class JoggerTests
    {
        [TestMethod]
        public void RunDiagnostics()
        {
            new JoggerDiagnostics();
        }
    }
}