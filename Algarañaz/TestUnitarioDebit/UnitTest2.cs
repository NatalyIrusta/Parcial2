using System;
using Algarañaz;
using Algarañaz.BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarioDebit
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Miss Nataly Irusta", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
    }
}
