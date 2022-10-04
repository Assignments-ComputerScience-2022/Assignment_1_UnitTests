namespace Assignment1_UnitTests;

public class FootballPlayer
{
    
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int ShirtNumber { get; set; }
    
    public void ValidateName()
    {
        if (string.IsNullOrEmpty(Name)) throw new ArgumentNullException(nameof(Name), "Name cannot be null or empty");
        if (Name.Length < 2) throw new ArgumentOutOfRangeException(nameof(Name),"Name is too short");
    }
    
    public void ValidateAge()
    {
        if (Age < 1) throw new ArgumentOutOfRangeException(nameof(Age), "Age is too low");
    }

    public void ValidateShirtNumber()
    {
        if (ShirtNumber is < 1 or > 99) throw new ArgumentOutOfRangeException(nameof(ShirtNumber), "Shirt does not match the range");
    }

    public void Validator()
    {
        ValidateName();
        ValidateAge();
        ValidateShirtNumber();
    }

}