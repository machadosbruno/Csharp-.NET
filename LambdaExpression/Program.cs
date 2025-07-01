// Expression Lambda
var numbers = new int[] { 2, 4, 7, 6, 8, 1, 7, 3, 5, 7 };
var count = numbers.Count(x => x == 7);
Console.WriteLine(count);

//Statemante Lambda
List<int> numbers2 = new List<int> { 2, 4, 7, 6, 8, 1, 7, 3, 5, 7 };
count = numbers2.Count(x =>
{
    return x == 5;
});

Console.WriteLine(count);
