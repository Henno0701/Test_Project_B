namespace Test_Project;

[TestClass]
public class IsNumericTests
{
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
    [TestMethod]
    public void testmethod3()
    {
        // Arrange
        var prijs = new Prijs();
        int aantal = 5;
        int selectedClass = 1; // Example selectedClass value
        int onder_12 = 2; // Example onder_12 value
        int wineCount = 1; // Example wineCount value
        //(tijdens runnen moet de aantal welke class onder 12 en wine count wel zelfde zijn anders werkt hij niet)
        // Act
        var result = prijs.prijs(aantal);

        // Assert
        decimal expectedPrice = CalculateExpectedPrice(aantal, selectedClass, onder_12, wineCount);
        Assert.AreEqual(expectedPrice, result, 0.01m);
    }


    // benodigd voor testmethod3
    private decimal CalculateExpectedPrice(int aantal, int selectedClass, int onder_12, int wineCount)
    {
        decimal gangenmenu_2 = 25.50m; // Example gangenmenu prices
        decimal gangenmenu_3 = 30.50m;
        decimal gangenmenu_4 = 35.50m;
        decimal wijn_arrangement = 10.00m; // Example wijn arrangement price
        decimal discount = 0.1m;

        decimal menuPrijs = 0;
        switch (selectedClass)
        {
            case 0:
                menuPrijs = gangenmenu_2;
                break;
            case 1:
                menuPrijs = gangenmenu_3;
                break;
            case 2:
                menuPrijs = gangenmenu_4;
                break;
            default:
                return 0.0m;
        }

        decimal totPrijs = menuPrijs * aantal;

        if (onder_12 > 0)
        {
            decimal korting = menuPrijs * onder_12 * discount;
            totPrijs -= korting;
        }

        if (wineCount > 0)
        {
            decimal wijnprijs = wijn_arrangement * wineCount;
            totPrijs += wijnprijs;
        }

        return totPrijs;
    }

}
