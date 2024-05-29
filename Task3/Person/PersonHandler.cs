namespace Task3.Person;

/// <summary>
/// A controller and factory class for a <see cref="IPerson"/>
/// </summary>
internal class PersonHandler
{
    #region Get Ops
    public int GetAge(IPerson person)
    {
        return person.Age;
    }

    public string GetFName(IPerson person)
    {
        return person.FName;
    }

    public string GetLName(IPerson person)
    {
        return person.LName;
    }

    public double GetWeight(IPerson person)
    {
        return person.Weight;
    }

    public double GetHeight(IPerson person)
    {
        return person.Height;
    }
    #endregion
    
    #region Set Ops
    public void SetAge(IPerson person, int age)
    {
        person.Age = age;
    }

    public void SetFName(IPerson person, string fName)
    {
        person.FName = fName;
    }

    public void SetLName(IPerson person, string lName)
    {
        person.LName = lName;
    }

    public void SetWeight(IPerson person, double weight)
    {
        person.Weight = weight;
    }

    public void SetHeight(IPerson person, double height)
    {
        person.Height = height;
    }
    #endregion

    public IPerson CreatePerson(
        int age,
        string fName,
        string lName,
        double height,
        double weight) 
    {
            return new Person(fName, lName) {
                Age = age,
                Height = height,
                Weight = weight
            };  
    }

    public string GetPersonPropertiesAsString(IPerson person) 
    {
        return person.ToString() ?? "";
    }
}
