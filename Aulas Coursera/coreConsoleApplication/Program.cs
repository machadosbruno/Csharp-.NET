using System;
using System.Text;
using coreConsoleApplication;

// See https://aka.ms/new-console-template for more information

/*
string userType = "admin";
switch(userType){
    case "admin":
        Console.WriteLine("You have full access!");
        goto case "user";
    case "subadmin":
        Console.WriteLine("You can create or delete courses!");
        break;
    case "user":
        Console.WriteLine("You can access the courses!");
        break;
    default:
        Console.WriteLine("Trial user!");
        break;
}
*/

/*
int i = 100;
do{
    Console.WriteLine("Hi");
    i++;
}while(i < 5);
*/

/*string[] names = new string[5] {"nome1", "nome2", "nome3", "nome4", "nome5"};

for(int i = 0; i < names.Length; i++)
    Console.WriteLine(names[i]);

Console.WriteLine();

for(int i = names.Length-1; i >= 0; i--)
    Console.WriteLine(names[i]);

Console.WriteLine();

int j = 0;
while(j<names.Length){
    Console.WriteLine(names[j]);
    j++;
}

Console.WriteLine();

foreach(string name in names)
    Console.WriteLine(name);
*/

/*
for(int i = 0; i < 10; i++){
    Console.WriteLine(i);
}
Console.WriteLine();

for(int i = 0; i < 10; i++){
    if(i == 5) break;
    Console.WriteLine(i);
}
Console.WriteLine();


for(int i = 0; i < 10; i++){
    if(i==5)continue;
    Console.WriteLine(i);
}
Console.WriteLine();
*/

/*
int[] marks = new int[5] {45, 56, 65, 67, 78};
/*
marks[0] = 25;
marks[1] = 50;
marks[2] = 55;
marks[3] = 60;
marks[4] = 40;
*/
/*
foreach (int mark in marks)
    Console.WriteLine(mark);

Console.WriteLine();

for(int i = 0; i < marks.Length; i++)
    Console.WriteLine(marks[i]);

Console.WriteLine();

int[,] multiArray = new int[3,4]{
    {1, 2, 3, 4},
    {1, 2, 3, 4},
    {1, 2, 3, 4}
};

//multiArray[0,0] = 5

for(int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
        Console.Write(multiArray[i, j]);
    }  
    Console.WriteLine(); 
}
*/

/*
int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int [2];
jaggedArray[1] = new int [3];
*/
/*
string str1 = "Hello World";
string str2 = "C# Programming";
Console.WriteLine(str1);
Console.WriteLine(str1.Length);
Console.WriteLine(string.Concat(str1, " ", str2));
Console.WriteLine(str1.Equals(str2));

//Immutable String

string s1 = "C# Programming", s2 = "Hello World";

//Mutable String

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("C# Programming");
stringBuilder.Append("Hello World");

Console.WriteLine(stringBuilder);
*/
/*
Student student = new Student(1, "Coisa");
//student.acceptDetails();
student.displayDetails();
*/

Marks marks = new Marks();
marks.acceptDetails();
marks.displayDetails();