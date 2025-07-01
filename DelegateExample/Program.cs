CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);

c1(100);
Console.WriteLine(DelegateExample.getNumber());

c2(20);
Console.WriteLine(DelegateExample.getNumber());

c1 += new CalculateDelegate(DelegateExample.multiplication);
c1(30);
Console.WriteLine(DelegateExample.getNumber());