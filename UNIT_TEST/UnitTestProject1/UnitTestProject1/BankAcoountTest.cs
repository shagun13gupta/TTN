
using BankAccounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountTest
{
    [TestClass]
    public class BankAccountTests
    {


        // debit with valid amount
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            double loadFactor = 0.001;
            BankAccount account = new BankAccount("Shagun Gupta", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, loadFactor, "Account not debited correctly");
        }

        // debit when amount is less than 0
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Shagun Gupta", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }


        // debit when amount is not greater than 5000
        [TestMethod]
        public void Debit_WhenAmountIsNotGreaterThanFiveThousand_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 10000;
            double debitAmount = 5500;
            BankAccount account = new BankAccount("Shagun Gupta", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }


    }
}
