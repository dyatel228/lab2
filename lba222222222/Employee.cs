class Employee
{
    public string Name;
    public Department Department;

    public Employee(string name, Department department)
    {
        Name = name;
        Department = department;
    }

    public override string ToString()
    {
        if (Department != null && Department.Boss == this)
        {
            return Name + " начальник отдела " + Department.Name;
        }
        else if (Department != null && Department.Boss != null)
        {
            return Name + " работает в отделе " + Department.Name + ", начальник которого " + Department.Boss.Name;
        }
        else if (Department != null)
        {
            return Name + " работает в отделе " + Department.Name;
        }
        else
        {
            return Name + " (без отдела)";
        }
    }
}