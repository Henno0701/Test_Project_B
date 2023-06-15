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
    public void TestMethod3()
    {
        // Arrange
        int aantal = 5;
        int selectedMenu = 3; // Assuming 3-course menu
        int onder12 = 2; // 2 people under 12
        int wineCount = 3; // 3 people want wine

        decimal gangenmenu_2 = 25.0M;
        decimal gangenmenu_3 = 35.0M;
        decimal gangenmenu_4 = 45.0M;
        decimal discount = 0.1M; // 10% discount
        decimal wijn_arrangement = 10.0M; // vanuit gaande dat de waardes kloppen, zo niet pas in json die value's of pas hier ff de values naar de juiste aan

        decimal expectedTotalPrice = gangenmenu_3 * aantal;

        // Calculate the discount for people under 12
        decimal korting = gangenmenu_3 * onder12 * discount;
        expectedTotalPrice -= korting;

        // Include the wine price
        if (wineCount > 0)
        {
            decimal wijnprijs = wijn_arrangement * wineCount;
            expectedTotalPrice += wijnprijs;
        }

        // Act
        var calculator = new PrijsCalculator();
        decimal totalPrice = calculator.Prijs(aantal, selectedMenu, onder12, wineCount);

        // Assert
        Assert.AreEqual(expectedTotalPrice, totalPrice);
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
