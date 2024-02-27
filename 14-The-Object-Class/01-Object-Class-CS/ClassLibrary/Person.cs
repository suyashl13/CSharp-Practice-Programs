namespace ClassLibrary;

sealed public class Person
{
    //Properties
    public String PersonName { get; set; }
    public String Email { get; set; }

    public override bool Equals(System.Object obj)
    {
        Person personInParams = (Person)obj;
        return (personInParams.Email == this.Email && personInParams.PersonName == this.PersonName);
    }

    public override string ToString()
    {
        return $"Person: <{this.PersonName},{this.Email}>";
    }

}