using Assignment1_UnitTests;

namespace TestsFootballPlayer;

[TestClass]
public class UnitTests
{

    readonly FootballPlayer _player = new() { Id = 1, Name = "M", Age = 30, ShirtNumber = 10 };

    [TestMethod]
    public void ValidateName_OutOfRange()
    {
        //Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ValidateName());
    }


    [TestMethod]
    public void ValidateName_Null()
    {
        //Arrange
        _player.Name = null;

        //Assert
        Assert.ThrowsException<ArgumentNullException>(() => _player.ValidateName());
    }

    [TestMethod]
    public void ValidateAge()
    {
        //Arrange
        _player.Age = 0;

        //Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ValidateAge());
    }

    [TestMethod]
    public void ValidateShirtNumber()
    {
        _player.ShirtNumber = 100;
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ValidateShirtNumber());

        _player.ShirtNumber = 0;
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ValidateShirtNumber());
    }
}