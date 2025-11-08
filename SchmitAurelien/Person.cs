public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthDate { get; set; }

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }
}
