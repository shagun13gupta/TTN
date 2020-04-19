using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectExtension;
using System;
using System.Collections.Generic;
using System.Text;
using SubOperators;

namespace SubOperatorTest
{

    [TestClass]
    public class SubOperatorTest
    {
        public const double Tolerance = 0.0000001;

        //subtraction of positive and negative integers
        [TestMethod]
        [DynamicData(nameof(GetFinityValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_SubtractPositiveNegativeArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange

            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var subOperator = new SubOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(subOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
        }


        //subtraction of string and a number
        [TestMethod]
        [DynamicData(nameof(GetStringAndNumberValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_MinusStirngAndNumberArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange
            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                if (operand.IsNumeric())
                {
                    list.Add(operand);
                }
                else
                {
                    continue;
                }

            }
            // Act
            var minusOperator = new SubOperator();
            //addOperator.Evaluate(list);
            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(minusOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
            //Assert.AreEqual(minusOperator.Evaluate(list), Convert.ToString(info.expected));
        }

        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (Subtraction: new object[] { 0, 14 }, Expected: -14D) };
            yield return new object[] { (Subtraction: new object[] { 0, 14 }, Expected: -14D) };
            yield return new object[] { (Subtraction: new object[] { 1, 1 }, Expected: 0D) };
            yield return new object[] { (Subtraction: new object[] { 17, -2 }, Expected: 19D) };
            yield return new object[] { (Subtraction: new object[] { -22, -11 }, Expected: -11D) };
            yield return new object[] { (Subtraction: new object[] { 12, 30.5 }, Expected: -18.5D) };
            yield return new object[] { (Subtraction: new object[] { 12.2, 22 }, Expected: -9.8D) };
            yield return new object[] { (Subtraction: new object[] { 20.65, 10.45 }, Expected: 10.2D) };
            yield return new object[] { (Subtraction: new object[] { 12.10, -3.5 }, Expected: 15.6D) };
            yield return new object[] { (Subtraction: new object[] { -12.10, -3.5, }, Expected: -8.6D) };
            yield return new object[] { (Subtraction: new object[] { 0.00000000000000000000123, 0.0000000000000000000023 }, Expected: -1.07E-21D) };
            yield return new object[] { (Subtraction: new object[] { 1235349, 8, 3 }, Expected: 1235338D) };
            yield return new object[] { (Subtraction: new object[] { 1235349, 8, 3, 2 }, Expected: 1235336D) };
        }

        public static IEnumerable<object[]> GetStringAndNumberValueDataRow()
        {
            yield return new object[] { (Subtraction: new object[] { "I", "J", "M", "G", "E", 3 }, Expected: 3D) };
            yield return new object[] { (Subtraction: new object[] { "u", "d", "c", "c", "F", 0.56 }, Expected: 0.56D) };
            yield return new object[] { (Subtraction: new object[] { "u", "D", "C", "c", "F", 5.6 }, Expected: 5.6D) };
        }

    }
}
