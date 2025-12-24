class EmployeeWithList
{
    public string Name;
    public DepartmentWithList Department;

    public EmployeeWithList(string name, DepartmentWithList department)
    {
        Name = name;
        Department = department;
        department.AddEmployee(this);
    }

    public EmployeeWithList[] GetDepartmentEmployees()
    {
        if (Department != null)
        {
            return Department.GetAllEmployees();
        }
        return new EmployeeWithList[0];
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