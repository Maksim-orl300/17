enum EmployementStatus { Active, OnLeave, Terminated}

class Employee
{
    public string Name;
    public DateTime? HireDate;
    public EmployementStatus Status;

    public int GetYearsWorked()
    {
        return HireDate == null ? -1 : DateTime.Now.Year;
    }

    public override string ToString()
    {
        string gh = HireDate == null ? "Не указан" : (DateTime.Now - HireDate).ToString();
        return ($"{Name}, cтатус {Status}, стаж {gh}"); 
    }
}
