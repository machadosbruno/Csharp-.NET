using System.Linq.Expressions;

// Expression Tree
Func<string, string, string> stringJoins = (str1, str2) => string.Concat(str1, str2);

Expression<Func<string, string, string>> stringJoinExpr = (str1, str2) => string.Concat(str1, str2);

var func = stringJoinExpr.Compile();
var result = func("Hello", " World");
Console.WriteLine(result);

//OR

result = stringJoinExpr.Compile()("Hello", " Everyone");
Console.WriteLine(result);