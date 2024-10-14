using System;
public class DocumentFactory
{
    public IDocument CreateDocument(string documentType)
    {
        switch (documentType.ToLower())
        {
            case "resume":
                return new Resume();
            case "report":
                return new Report();
            default:
                throw new ArgumentException("Invalid document type.");
        }
    }
}