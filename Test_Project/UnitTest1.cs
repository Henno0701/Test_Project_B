namespace Test_Project; 

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        string email = "test@gmail.com";
        bool result = ValidationLogic.IsValidEmail(email);

        Assert.AreEqual(result, true);
    }

    [TestMethod]
    public void TestMethod2()
    {
        string password = "Abc123!";
        bool result = ValidationLogic.IsValidPassword(password);

        Assert.AreEqual(result, true);
    }

    [TestMethod]
    public void IsNumeric_ValidNumericString_ReturnsTrue()
    {
        // Arrange
        string number = "12345";

        // Act
        bool result = ValidationLogic.IsNumeric(number);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsNumeric_ValidNonNumericString_ReturnsFalse()
    {
        // Arrange
        string number = "abc123";

        // Act
        bool result = ValidationLogic.IsNumeric(number);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsNumeric_EmptyString_ReturnsFalse()
    {
        // Arrange
        string number = "";

        // Act
        bool result = ValidationLogic.IsNumeric(number);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValidPassword_ValidPassword_ReturnsTrue()
    {
        string password = "Abcdef1";
        bool isValid = ValidationLogic.IsValidPassword(password);
        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void IsValidPassword_MissingNumber_ReturnsFalse()
    {
        string password = "Abcdefg";
        bool isValid = ValidationLogic.IsValidPassword(password);
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsValidPassword_MissingUppercase_ReturnsFalse()
    {
        string password = "abcdefg";
        bool isValid = ValidationLogic.IsValidPassword(password);
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsValidPassword_PasswordTooShort_ReturnsFalse()
    {
        string password = "short";
        bool isValid = ValidationLogic.IsValidPassword(password);
        Assert.IsFalse(isValid);
    }   
}
