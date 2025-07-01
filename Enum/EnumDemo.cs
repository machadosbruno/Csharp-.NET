enum WeekDays : byte
{
    Monday,
    Tuesday = 14,
    Wednesday = 7,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
internal class EnumDemo
{
    public void display()
    {
        int day = (int)WeekDays.Monday;
        Console.WriteLine(WeekDays.Monday + " : " + day);

        day = (int)WeekDays.Tuesday;
        Console.WriteLine(WeekDays.Tuesday + " : " + day);

        day = (int)WeekDays.Wednesday;
        Console.WriteLine(WeekDays.Wednesday + " : " + day);
    }
}