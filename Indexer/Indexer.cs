internal class StringIndexerType
{
    private string[] strArray = new string[10];
    private int length = 10;
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= strArray.Length)
                throw new ArgumentOutOfRangeException("Index is out of range.");
            return strArray[index];
        }
        set
        {
            if (index < 0 || index >= strArray.Length)
                throw new IndexOutOfRangeException("Index out of range");
            strArray[index] = value;
        }
    }
    public int Length
    {
        get{ return length; }
    }
}