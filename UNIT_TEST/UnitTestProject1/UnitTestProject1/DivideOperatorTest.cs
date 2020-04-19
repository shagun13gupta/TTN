using DivideOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DivideOperatorTest
{
    [TestClass]
    public class DivideOperatorTest
    {
        public const double Tolerance = 0.0000001;

        //divide positive and negative numbers
        [TestMethod]
        [DynamicData(nameof(GetFinityValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_DividePositiveNegativeArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange

            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var divideOperator = new DivideOperator();

            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(divideOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
        }



        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (Division: new object[] { 0, 14 }, Expected: 0D) };
            yield return new object[] { (Division: new object[] { 0, -14 }, Expected: 0D) };
            yield return new object[] { (Division: new object[] { 1, 1 }, Expected: 1D) };
            yield return new object[] { (Division: new object[] { 17, -2 }, Expected: -8.5D) };
            yield return new object[] { (Division: new object[] { -22, -11 }, Expected: 2D) };
            yield return new object[] { (Division: new object[] { 12, 30.5 }, Expected: 0.3934426229508197D) };
            yield return new object[] { (Division: new object[] { 12.2, 22 }, Expected: 0.5545454545454D) };
            yield return new object[] { (Division: new object[] { 20.65, 10.45 }, Expected: 1.9760765550239D) };
            yield return new object[] { (Division: new object[] { 12.10, -3.5 }, Expected: -3.4571428571428D) };
            yield return new object[] { (Division: new object[] { -12.10, -3.5, }, Expected: 3.4571428571428D) };
            yield return new object[] { (Division: new object[] { 0.00000000000000000000123, 0.0000000000000000000023 }, Expected: 0.5347826086956D) };
            yield return new object[] { (Division: new object[] { 1235349, 8, 3 }, Expected: 51472.875D) };
            yield return new object[] { (Division: new object[] { 1235349, 8, 3, 2 }, Expected: 25736.4375D) };
        }



    }
}
