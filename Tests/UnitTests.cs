using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid_Shin()
        {
            Assert.AreEqual(1, Program.Subtract("2", "1"));
            Assert.AreEqual(-5, Program.Subtract("1", "6"));
            Assert.AreEqual(10, Program.Subtract("20", "10"));
        }

        [Test]
        public void Subtract_Invalid_Shin()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "2"));
            Assert.Throws<FormatException>(() => Program.Subtract("c", "d"));
        }

        [Test]
        public void Subtract_Null_Shin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid_Shin()
        {
            Assert.AreEqual(0, Program.Multiply("0", "1"));
            Assert.AreEqual(12, Program.Multiply("3", "4"));
            Assert.AreEqual(-24, Program.Multiply("-4", "6"));
        }

        [Test]
        public void Multiply_Invalid_Shin()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("6", "e"));
            Assert.Throws<FormatException>(() => Program.Multiply("f", "9"));
            Assert.Throws<FormatException>(() => Program.Multiply("g", "h"));
        }

        [Test]
        public void Multiply_Null_Shin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("4", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "4"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid_Shin()
        {
            Assert.AreEqual(5, Program.Divide("5", "1"));
            Assert.AreEqual(2, Program.Divide("4", "2"));
            Assert.AreEqual(8, Program.Divide("-24", "-3"));
        }

        [Test]
        public void Divide_Invalid_Shin()
        {
            Assert.Throws<FormatException>(() => Program.Divide("7", "i"));
            Assert.Throws<FormatException>(() => Program.Divide("j", "8"));
            Assert.Throws<FormatException>(() => Program.Divide("k", "l"));
        }

        [Test]
        public void Divide_Null_Shin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("5", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "5"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid_Shin()
        {
            Assert.AreEqual(1, Program.Power("1", "0"));
            Assert.AreEqual(27, Program.Power("3", "3"));
            Assert.AreEqual(-8, Program.Power("-2", "3"));
        }

        [Test]
        public void Power_Invalid_Shin()
        {
            Assert.Throws<FormatException>(() => Program.Power("4", "m"));
            Assert.Throws<FormatException>(() => Program.Power("n", "5"));
            Assert.Throws<FormatException>(() => Program.Power("o", "p"));
        }

        [Test]
        public void Power_Null_Shin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("6", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "6"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
