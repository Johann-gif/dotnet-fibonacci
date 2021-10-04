// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using Fibonacci;

Stopwatch stopwatch = new();
stopwatch.Start();

var tasks = await Fibo.ExecuteAsync(args);

foreach (var task in tasks)
{
    Console.WriteLine($"Fibo result: {task}");
}

stopwatch.Stop();
// String interpolation, nouvelle syntaxe présente en c# et javascript
Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");