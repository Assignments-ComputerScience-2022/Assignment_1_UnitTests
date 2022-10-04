using Assignment1_UnitTests;

namespace TestsFootballPlayer;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void ValidateName_OutOfRange()
    {
        //Arrange
        FootballPlayer player = new FootballPlayer{ Id = 1, Name = "M", Age = 30, ShirtNumber = 10 };
        //Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateName());
    }

    [TestMethod]
    public void ValidateName_Null()
    {
        //Arrange
        FootballPlayer player = new FootballPlayer{ Id = 1, Name = "M", Age = 30, ShirtNumber = 10 };
        
        //Act
        player.Name = null;

        //Assert
        Assert.ThrowsException<ArgumentNullException>(() => player.ValidateName());
    }

    [TestMethod]
    public void ValidateAge()
    {
        //Arrange
        FootballPlayer player = new FootballPlayer{ Id = 1, Name = "M", Age = 30, ShirtNumber = 10 };
        
        //Act
        player.Age = 0;

        //Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateAge());
    }

    [TestMethod]
    public void ValidateShirtNumber()
    {
        //Arrange
        FootballPlayer player = new FootballPlayer{ Id = 1, Name = "M", Age = 30, ShirtNumber = 10 };
        
        player.ShirtNumber = 100;
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateShirtNumber());

        player.ShirtNumber = 0;
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateShirtNumber());
    }
    
    [TestMethod]
    public void ValidateToStringMethod()
    {
        //Arrange
        FootballPlayer player = new() { Id = 1, Name = "Max", Age = 30, ShirtNumber = 10 };
        
        //Act
        string str = player.ToString();
        
        //Assert
        Assert.AreEqual("1 Max 30 10", str);
    }
    
    [TestMethod]
    public void ValidateValidator()
    {
        //Arrange
        FootballPlayer player = new() { Id = 1, Name = "Max", Age = 30, ShirtNumber = 10 };
        
        //Act
        player.Validator();
    }
}