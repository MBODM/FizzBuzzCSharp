using FizzBuzzCSharp;
using FizzBuzzLib;

var user = new FizzBuzzUser(new FizzBuzzDefault());

Console.WriteLine("Running FizzBuzz now...");
Console.WriteLine();

var result = user.TestRun1();
//var result = user.TestRun2();
result.ToList().ForEach(s => Console.WriteLine(s));

Console.WriteLine();
Console.WriteLine("Have a nice day.");
