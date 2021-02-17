using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleEffects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEffects.Tests
{
    [TestClass()]
    public class TextUttererTests
    {

        [TestMethod, Description("Asserts that the printer prints.")]
        public void Test_Printer_Prints()
        {
            //arrange
            TextPrinter printer = new TextPrinter("utterance");
            //act
            Assert.IsTrue(string.IsNullOrEmpty(printer.Printed));
            printer.Print();
            //assert
            Assert.IsTrue(printer.Printed== "utterance");
        }

        [TestMethod, Description("Asserts that the printer can print text as if typed.")]
        public void Test_Printer_Types()
        {
            //arrange
            TextPrinter printer = new TextPrinter("utterance");
            //act
            printer.Type();
            //assert
            Assert.IsTrue(printer.Typed.Length == "utterance".Length);

        }


    }
}