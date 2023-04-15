using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordClassLibrary;
using System;

namespace PasswordUnitTestProject
{
    [TestClass]
    public class PasswordCheckerUnitTest
    {
        [TestMethod]
        public void ValidatePasswordTest()
        {
            // Arrange
            string password = "_Password1";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestLowLengthFalse()
        {
            // Arrange
            string password = "_Pasd1";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestHighLengthFalse()
        {
            // Arrange
            string password = "_Pasasdasdasdasdaasddasdasdasdasdasdasdd1";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestDigitFalse()
        {
            // Arrange
            string password = "_Passwords";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestDigitSimblosFalse()
        {
            // Arrange
            string password = "Password1";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePasswordTestLowerFalse()
        {
            // Arrange
            string password = "_PASSWORD1";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidatePasswordTestUpperFalse()
        {
            // Arrange
            string password = "_password1";
            bool expected = true;


            // Act 
            bool actual = PasswordChecker.ValidatePassword(password);


            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
