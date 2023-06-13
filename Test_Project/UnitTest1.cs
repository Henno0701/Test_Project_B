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
}