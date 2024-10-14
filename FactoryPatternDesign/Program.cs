using System;

class Program
{
    static void Main(string[] args)
    {
        // Get document type from user
        Console.WriteLine("What type of document do you want to create (Resume/Report)?");
        string documentType = Console.ReadLine();

        // Create document using the factory
        DocumentFactory factory = new DocumentFactory();
        IDocument document = factory.CreateDocument(documentType);

        // Use the document
        document.Open();
        document.Save();
        document.Close();

        Console.ReadKey();
    }
}

// Design pattern being used is Factory Method, creational design, its needed due to an interface for creating objects in a superclass but allows subclasses to alter the type of objects created
// website used was refactoring guru-design patterns-factory method, I found this interesting because you are able to add multiple classes and you could use in a lot of ways working in the shipping industry like Boeing, UPS, or Amazon