// See https://aka.ms/new-console-template for more information
using FibonachiHomeWork_Otus;

Console.WriteLine("Hello, World!");


var calculator = new FibonachiCalc();

int[] valuesToTest = { 5, 10, 20 };

foreach (var n in valuesToTest)
{
    Console.WriteLine($"\nВычисление F({n}):");

    // Измерение рекурсивного метода
    var recursiveTime = calculator.MeasureExecutionTime(() => calculator.FibonacciRecursive(n));
    int resultRecursive = calculator.FibonacciRecursive(n);
    Console.WriteLine($"Рекурсивный метод: F({n}) = {resultRecursive}, время = {recursiveTime.TotalMilliseconds:F6} мс");

    // Измерение итеративного метода
    var iterativeTime = calculator.MeasureExecutionTime(() => calculator.FibonacciIterative(n));
    int resultIterative = calculator.FibonacciIterative(n);
    Console.WriteLine($"Итеративный метод: F({n}) = {resultIterative}, время = {iterativeTime.TotalMilliseconds:F6} мс");
}