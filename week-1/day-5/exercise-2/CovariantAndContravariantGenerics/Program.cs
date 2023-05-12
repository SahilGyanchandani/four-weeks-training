using System;
using System.IO;
// Create an interface called "IProcessor<in TInput, out TResult>" with a single method "TResult Process(TInput input)".
public interface IProcessor<in TInput, out TResult>
{
    TResult Process(TInput input);
}
// Create a class called "StringToIntProcessor" that implements "IProcessor<string, int>" and returns the length of the input string.
public class StringToIntProcessor : IProcessor<string, int>
{
    public int Process(string input)
    {
        return input.Length;
    }
}
// Create a class called "DoubleToStringProcessor" that implements "IProcessor<double, string>" and returns the string representation of the input double
public class DoubleToStringProcessor : IProcessor<double, string>
{
    public string Process(double input)
    {
        return input.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        StringToIntProcessor stringToIntProcessor = new StringToIntProcessor();
        int output1 = stringToIntProcessor.Process("Sahil");
        Console.WriteLine(output1);
        DoubleToStringProcessor doubleToStringProcessor = new DoubleToStringProcessor();
        string output2 = doubleToStringProcessor.Process(3.141146565546);
        Console.WriteLine(output2);
    }
}