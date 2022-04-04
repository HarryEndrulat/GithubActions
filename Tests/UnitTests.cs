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
        public void Subtract_Valid_Endrulat()
        {
            Assert.AreEqual(13, Program.Subtract("15", "2"));
            Assert.AreEqual(0, Program.Subtract("3", "3"));
            Assert.AreEqual(-2, Program.Subtract("5", "7"));
        }

        [Test]
        public void Subtract_Invalid_Endrulat()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "b"));
        }

        [Test]
        public void Subtract_Null_Endrulat()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid_Endrulat()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(0, Program.Multiply("0", "2"));
            Assert.AreEqual(42, Program.Multiply("6", "7"));
        }

        [Test]
        public void Multiply_Invalid_Endrulat()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "c"));
            Assert.Throws<FormatException>(() => Program.Multiply("c", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("c", "c"));
        }

        [Test]
        public void Multiply_Null_Endrulat()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid_Endrulat()
        {
            Assert.AreEqual(2, Program.Divide("2", "1"));
            Assert.AreEqual(3, Program.Divide("1.5", "0.5"));
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
        }

        [Test]
        public void Divide_Invalid_Endrulat()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "d"));
            Assert.Throws<FormatException>(() => Program.Divide("d", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("d", "d"));
        }

        [Test]
        public void Divide_Null_Endrulat()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid_Endrulat()
        {
            Assert.AreEqual(1, Program.Power("1", "4"));
            Assert.AreEqual(1, Program.Power("3", "0"));
            Assert.AreEqual(125, Program.Power("5", "3"));
        }

        [Test]
        public void Power_Invalid_Endrulat()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "e"));
            Assert.Throws<FormatException>(() => Program.Power("e", "1"));
            Assert.Throws<FormatException>(() => Program.Power("e", "e"));
        }

        [Test]
        public void Power_Null_Endrulat()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
