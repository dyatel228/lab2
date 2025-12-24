class Name
{
    public string LastName;
    public string FirstName;
    public string Patronymic;

    public Name(string lastName, string firstName, string patronymic)
    {
        LastName = lastName;
        FirstName = firstName;
        Patronymic = patronymic;
    }

    public override string ToString()
    {
        string result = "";

        if (!string.IsNullOrWhiteSpace(LastName))
        {
            result += LastName;
        }

        if (!string.IsNullOrWhiteSpace(FirstName))
        {
            if (result.Length > 0) result += " ";
            result += FirstName;
        }

        if (!string.IsNullOrWhiteSpace(Patronymic))
        {
            if (result.Length > 0) result += " ";
            result += Patronymic;
        }

        return result;
    }
}