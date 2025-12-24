class NameNew
{
    public string LastName;
    public string FirstName;
    public string Patronymic;

    public NameNew(string firstName)
    {
        FirstName = firstName;
        LastName = "";
        Patronymic = "";
    }

    public NameNew(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = "";
    }

    public NameNew(string firstName, string lastName, string patronymic)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
    }

    public override string ToString()
    {
        string result = FirstName;

        if (!string.IsNullOrWhiteSpace(LastName))
        {
            result += " " + LastName;
        }

        if (!string.IsNullOrWhiteSpace(Patronymic))
        {
            result += " " + Patronymic;
        }

        return result;
    }
}