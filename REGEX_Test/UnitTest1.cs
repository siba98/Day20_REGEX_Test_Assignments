using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20_REGEX_Assignments;
using Day20_REGEX_Assignments.UC1_FirstName;
using Day20_REGEX_Assignments.UC2_LastName;
using Day20_REGEX_Assignments.UC3_9_Email;
using Day20_REGEX_Assignments.UC4_MobileNumber;
using Day20_REGEX_Assignments.CustomException;

namespace REGEX_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenFirstName_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            FirstName_Pattern patternMatch = new FirstName_Pattern();
            bool expected = true;

            //Act
            var result = patternMatch.ValidateFirstName("Siba");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void GivenLastName_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            LastName_Pattern patternMatch = new LastName_Pattern();
            bool expected = true;

            //Act
            var result = patternMatch.ValidateLastName(null);
            //var result = patternMatch.ValidateLastName("Patro");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenEmail_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            Email_Pattern patternMatch = new Email_Pattern();
            bool expected = true;

            //Act
            var result = patternMatch.ValidateEmail("abc.xyz@bl.co.in");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenMobileNumber_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            MobileNumber_Pattern patternMatch = new MobileNumber_Pattern();
            bool expected = true;

            //Act
            var result = patternMatch.ValidatePhoneNumber("91 7504832115");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenPassword_If_Null_ShouldThrow_UserRegistrationCustomException()
        {
            //Arrange
            Password_Pattern patternMatch = new Password_Pattern();
            bool expected = true;

            //Act
            var result = patternMatch.ValidatePassword("Tr5h7stU&");

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
