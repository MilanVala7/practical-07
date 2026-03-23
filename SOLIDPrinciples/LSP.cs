namespace SOLIDPrinciples;

interface IReadable
{
    string Content { get; }

    // Summary: 
    // Purpose: Read content of document.
    // return type: void
    void Read();
}

interface IWritable
{
    string Content { get; set; }

    // Summary:
    // Purpose: writes content to document.
    // return type: void
    void Write(string content);
}
public class WordDocs: IReadable, IWritable
{
    public string Content { get; set; }

    public void Read()
    {
        Console.WriteLine("Reading Word Document: " + Content);
    }

    public void Write(string content)
    {
        Content = content;
    }
}

public class PdfDocs : IReadable
{
    public string Content { get; }
    public PdfDocs(string content)
    {
        Content = content;
    }
    public void Read()
    {
        Console.WriteLine("Reading PDF Document: " + Content);
    }
}
