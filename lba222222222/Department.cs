class Department
{
    public string Name;
    public Employee Boss;

    public Department(string name, Employee boss)
    {
        Name = name;
        Boss = boss;
    }

    public void SetBoss(Employee boss)
    {
        Boss = boss;
    }
}