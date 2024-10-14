using System;
// Resume.cs
public class Resume : IDocument
{
    public void Open() => Console.WriteLine("Opening Resume document...");
    public void Save() => Console.WriteLine("Saving Resume document...");
    public void Close() => Console.WriteLine("Closing Resume document...");
}
