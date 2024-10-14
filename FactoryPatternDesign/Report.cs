using System;
// Report.cs
public class Report : IDocument
{
    public void Open() => Console.WriteLine("Opening Report document...");
    public void Save() => Console.WriteLine("Saving Report document...");
    public void Close() => Console.WriteLine("Closing Report document...");
}