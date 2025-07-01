internal class User
{
    private string name;
    private string companyName;
    private int age;

    public User()
    {
        companyName = "ABC";
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //ReadOnly because don't have a setter    
    public string CompanyName
    {
        get { return companyName; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new ArithmeticException("Invalid Age");
            age = value;
        }
    }
}