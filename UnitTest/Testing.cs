using NUnit.Framework;
using System;
using System.IO;
using Opgaver;

namespace UnitTest
{
    public class TestsOfVariabels
    {
        private StringWriter stringWriter;

        [SetUp]
        public void Setup()
        {
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            stringWriter.Dispose();
        }

        [Test]
        public void TestInt1()
        {
            Opgaver.Variabler.Int1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 1:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen int og tildel den en v�rdi af ti!"));
            Assert.IsTrue(output.Contains("10"));
        }

        [Test]
        public void TestDouble1()
        {
            Opgaver.Variabler.Double1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 2:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen double og tildel den en v�rdi komma (decimal) v�rdi af 5 og en 1/4"));
            Assert.IsTrue(output.Contains("5.25") || output.Contains("5,25"));
        }

        [Test]
        public void TestStrings1()
        {
            Opgaver.Variabler.Strings1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 3:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen string og tildel den en v�rdi - den skal indeholde teksten 'Hello, World' med et udr�bstegn til sidst!"));
            Assert.IsTrue(output.Contains("Hello, World!"));
        }

        [Test]
        public void TestBool1()
        {
            Opgaver.Variabler.Bool1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 4:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen bool og tildel den en sandhedsv�rdi (true/false)."));
            Assert.IsTrue(output.Contains("True"));
        }

        [Test]
        public void TestStringInterpolation()
        {
            Opgaver.Variabler.StringInterpolation();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 5:"));
            Assert.IsTrue(output.Contains("Lav to string variabeler og udskriv dem ved brug af string interpolation."));
            Assert.IsTrue(output.Contains("Hello, World!"));
        }

        [Test]
        public void TestFloat1()
        {
            Opgaver.Variabler.Float1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 6:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen float og tildel den en v�rdi af 3.14"));
            Assert.IsTrue(output.Contains("3,14"));
        }

        [Test]
        public void TestChar1()
        {
            Opgaver.Variabler.Char1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 7:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen char og tildel den en v�rdi af det f�rste bogstav i alfabetet (Det skal v�re stort!)"));
            Assert.IsTrue(output.Contains("A"));
        }

        [Test]
        public void TestDecimal1()
        {
            Opgaver.Variabler.Decimal1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Opgave 8:"));
            Assert.IsTrue(output.Contains("Lav en variabel af typen decimal og tildel den en v�rdi af 100.50"));
            Assert.IsTrue(output.Contains("100,50"));
        }
    }

    public class TestsOfIndputs
    {
        private StringWriter stringWriter;
        private StringReader stringReader;

        [SetUp]
        public void Setup()
        {
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            stringWriter.Dispose();
            stringReader?.Dispose();
        }

        [Test]
        public void TestString1()
        {
            stringReader = new StringReader("Hello, World!");
            Console.SetIn(stringReader);
            Opgaver.Indputs.String1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"));
            Assert.IsTrue(output.Contains("Indtast en streng:"));
            Assert.IsTrue(output.Contains("Hello, World!"));
        }

        [Test]
        public void TestInt1()
        {
            stringReader = new StringReader("42");
            Console.SetIn(stringReader);
            Opgaver.Indputs.Int1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"));
            Assert.IsTrue(output.Contains("Indtast et tal:"));
            Assert.IsTrue(output.Contains("42"));
        }

        [Test]
        public void TestDouble1()
        {
            stringReader = new StringReader("3,14");
            Console.SetIn(stringReader);
            Opgaver.Indputs.Double1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"));
            Assert.IsTrue(output.Contains("Indtast et decimaltal:"));
            Assert.IsTrue(output.Contains("3.14") || output.Contains("3,14"));
        }


        [Test]
        public void TestBool1()
        {
            stringReader = new StringReader("true");
            Console.SetIn(stringReader);
            Opgaver.Indputs.Bool1();
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Lav et program som gemmer et input som en sandhedsv�rdi og skriver v�rdien ud i konsollen"));
            Assert.IsTrue(output.Contains("Indtast en sandhedsv�rdi (sandt/falsk): "));
            Assert.IsTrue(output.Contains("true", StringComparison.OrdinalIgnoreCase));
        }
    }
}
