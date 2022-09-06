
using GenericCollectionsTutorial;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

Console.WriteLine("Generic Collections");
Console.WriteLine("Covering.. Dictionary, Stack and Queue's");






/* 
 * The RPN Calculator
 * 
 * "2 3 * 1 +" evaluates to 7 by putting string eval = "2 3 * 1 +"
 * "6^2 + 5 * 6 - 27" we need to put "6 6 * 5 6 * + 27 -" put that into string eval.
 * 

Stack<int> stack = new();
string eval = "6 6 * 5 6 * + 27 -";
int a = 0;
int b = 0;

string[] parts = eval.Split(" ");
foreach(string part in parts)
{
    switch(part)
    {
        case "+":
            //add
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(a + b);
            break;
        case "-":
            //subtract
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(b - a);
            break;
        case "*":
            //multiply
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(a * b);
            break;
        case "/":
            //divide
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(b / a);
            break;
        default:
            //convert to number
            //and push on to stack
            int nbr = Convert.ToInt32(part);
            stack.Push(nbr);
            break;

    }
}

Console.WriteLine($"= {stack.Pop()}");

 */



/*
Stack<int> stack = new(); //creating a new stack

int anInt = GetUserInput();
stack.Push(anInt);

while(true)
{
    anInt = GetUserInput();
    stack.Push(anInt);
    if (anInt == 0) break;
    var a = stack.Pop();
    var b = stack.Pop();    
    stack.Push(a + b);
    Console.WriteLine($"{a + b}");
}

Console.WriteLine("Done...");



int GetUserInput()
{
    Console.Write("Enter an integer: ");
    string ans = Console.ReadLine();
    return Convert.ToInt32(ans);
}
*/


        //basic stack showing order
//stack.Push(1); //pushing 1, 2, 3, onto the stack, 3 is top.
//stack.Push(2);
//stack.Push(3);
//
//int i3 = stack.Pop(); //Pop to remove an item.
//int i2 = stack.Pop();
//int i1 = stack.Pop();
//
//Console.WriteLine($"{i3}, {i2}, {i1}");

/*

            //Dictionary 
//created a class Student with 3 properties.  Adding to Dictionary called students.
//TKey is Int, TValue is the class Student> dict name students = new instance
//then list the dict name, students.Add(int Tkey 10, new Student as value
//then braces defining all 3 properties in the student class;

Dictionary<int, Student> students = new();
students.Add(10, new Student { Id = 10, Name = "Noah Phence", SAT = 1200 });
students.Add(20, new Student { Id = 20, Name = "Graham Krakr", SAT = 1000 });

//assigned dict students 10 key to var noah. Cursor runto and hover noah it shows the values.
Student noah = students[10];



Dictionary<string, string> states = new();
states.Add("OH", "Ohio");
states.Add("KY", "Kentucky");
states.Add("IN", "Indiana");

string state = states["KY"];

//changing the dictionary to a List, to display the contents.

//foreach(var key in states.Keys.ToList())
//{
//    var value = states[key];
//    Console.WriteLine(value);
//}

List<int> ints = new();


for(int idx = 1; idx < 1000; idx+=13)
{
    ints.Add(idx);
}

Console.WriteLine($"The list has {ints.Count} items");

Console.WriteLine($"The fifth item in the List is {ints[4]}");

int sum = 0;

//foreach(int nVar in ints)
//{
//    sum += nVar;
//}

ints.ForEach(turkey => sum += turkey);

Console.WriteLine(sum);

List<string> Cities = new(10);

Cities.Add("London");
Cities.Add("Paris");
Cities.Add("London2");
Cities.Add("Santiago");
Cities.Add("Sydney");

Cities.Sort();

Console.WriteLine($"The Total Cities entered are: {Cities.Count}");

//Console.WriteLine($"{Cities[0]}, {Cities[1]}, {Cities[2]}, {Cities[3]}, {Cities[4]}");
//Better way is this;
Cities.ForEach(city => Console.WriteLine($"{city}, "));

//OR Could also do
//foreach (string city in Cities) {
//  Console.Write(city);}

*/

