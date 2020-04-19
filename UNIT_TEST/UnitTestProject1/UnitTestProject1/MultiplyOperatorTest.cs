using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MultiplyOperators;


namespace MultiplyOperatorTest
{
    [TestClass]
    public class MultiplyOperatorTest
    {
        public const double Tolerance = 0.0000001;

        //multiply 2 postive or negative numbers
        [TestMethod]
        [DynamicData(nameof(GetFinityValueDataRow), DynamicDataSourceType.Method)]
        public void Evaluate_MultiplyPositiveNegativeArgs_ResultReturns((object[] operands, double expected) info)
        {
            // Arrange

            List<object> list = new List<object>();
            foreach (var operand in info.operands)
            {
                list.Add(operand);
            }
            // Act
            var multiplyOperator = new MultiplyOperator();

            // Assert
            Assert.IsTrue(Math.Abs(Convert.ToDouble(multiplyOperator.Evaluate(list)) - Convert.ToDouble(info.expected)) < Tolerance);
        }



        public static IEnumerable<object[]> GetFinityValueDataRow()
        {
            yield return new object[] { (Multiply: new object[] { 0, 14 }, Expected: 0D) };
            yield return new object[] { (Multiply: new object[] { 0, -14 }, Expected: 0D) };
            yield return new object[] { (Multiply: new object[] { 1, 1 }, Expected: 1D) };
            yield return new object[] { (Multiply: new object[] { 17, -2 }, Expected: -34D) };
            yield return new object[] { (Multiply: new object[] { -22, -11 }, Expected: 242D) };
            yield return new object[] { (Multiply: new object[] { 12, 30.5 }, Expected: 366D) };
            yield return new object[] { (Multiply: new object[] { 12.2, 22 }, Expected: 268.4D) };
            yield return new object[] { (Multiply: new object[] { 20.65, 10.45 }, Expected: 215.7925D) };
            yield return new object[] { (Multiply: new object[] { 12.10, -3.5 }, Expected: -42.35D) };
            yield return new object[] { (Multiply: new object[] { -12.10, -3.5, }, Expected: 42.35D) };
            yield return new object[] { (Multiply: new object[] { 0.00000000000000000000123, 0.0000000000000000000023 }, Expected: 2.829E-42D) };
            yield return new object[] { (Multiply: new object[] { 1235349, 8, 3 }, Expected: 29648376D) };
            yield return new object[] { (Multiply: new object[] { 1235349, 8, 3, 2 }, Expected: 59296752D) };
        }



    }
}
