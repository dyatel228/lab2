class DepartmentWithList
{
    public string Name;
    public EmployeeWithList Boss;
    private EmployeeWithList[] employees;
    private int employeeCount;

    public DepartmentWithList(string name, EmployeeWithList boss)
    {
        Name = name;
        Boss = boss;
        employees = new EmployeeWithList[20];
        employeeCount = 0;

        if (boss != null)
        {
            AddEmployee(boss);
        }
    }

    public void SetBoss(EmployeeWithList boss)
    {
        Boss = boss;
    }

    public void AddEmployee(EmployeeWithList employee)
    {
        if (employeeCount < employees.Length)
        {
            employees[employeeCount] = employee;
            employeeCount++;
        }
    }

    public EmployeeWithList[] GetAllEmployees()
    {
        EmployeeWithList[] result = new EmployeeWithList[employeeCount];
        for (int i = 0; i < employeeCount; i++)
        {
            result[i] = employees[i];
        }
        return result;
    }
}