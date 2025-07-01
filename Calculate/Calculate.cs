internal class Calculation
{
    public void calculate(int num1, int num2)
    {
        int result = 0;
        try
        {
            result = num1 / num2;
            Console.WriteLine(result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Divisão por zero não é possível. Tente novamente");
        }
        finally
        {
            Console.WriteLine(result);
        }
    }
}