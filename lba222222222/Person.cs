class Person
{
    public string Name;
    public int Height;

    public Person(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public override string ToString()
    {
        return Name + ", рост: " + Height;
    }
}