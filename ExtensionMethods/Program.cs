int number = 100;

bool result = number.IsGreaterThan(100);

Console.WriteLine(result);

//Teste de código da documentação da Microsoft
int[] numbers = [10, 45, 15, 39, 21, 26];
IOrderedEnumerable<int> resultArray = numbers.OrderBy(g => g);
foreach (int i in resultArray)
{
    Console.Write(i + " ");
}
//Output: 10 15 21 26 39 45