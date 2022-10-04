namespace Assignment1_UnitTests;

public class FootballPlayer
{
    
    private const int MIN_NAME_LENGTH = 2;
    private const int MIN_AGE_LENGTH = 1;
    private const int MIN_SHIRT_LENGTH = 1;
    private const int MAX_SHIRT_LENGTH = 99;
    
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int ShirtNumber { get; set; }
    
    public void ValidateName()
    {
        if (string.IsNullOrEmpty(Name)) throw new ArgumentNullException(nameof(Name), "Name cannot be null or empty");
        if (Name.Length < MIN_NAME_LENGTH) throw new ArgumentOutOfRangeException(nameof(Name),"Name is too short");
    }
    
    public void ValidateAge()
    {
        if (Age < MIN_AGE_LENGTH) throw new ArgumentOutOfRangeException(nameof(Age), "Age is too low");
    }

    public void ValidateShirtNumber()
    {
        if (ShirtNumber is < MIN_SHIRT_LENGTH or > MAX_SHIRT_LENGTH) throw new ArgumentOutOfRangeException(nameof(ShirtNumber), "Shirt does not match the range");
    }
    
    public override string ToString()
    {
        return $"{Id} {Name} {Age} {ShirtNumber}";
    }
    
    public void Validator()
    {
        ValidateName();
        ValidateAge();
        ValidateShirtNumber();
    }
    
    

    

}