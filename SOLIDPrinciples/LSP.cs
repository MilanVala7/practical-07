namespace SOLIDPrinciples;

interface IReadable
{
    public string Content { get; }

    // Summary: 
    // Purpose: Read content of document.
    // return type: void
    void Read();
}

interface IWritable
{
    public string Content { get; set; }

    // Summary:
    // Purpose: writes content to document.
    // return type: void
    void Write(string content);
}
public class WordDocs: IReadable, IWritable
{
    public string Content { get; set; }

    /// <summary>
    /// Purpose: Displays the Content of the word document.
    /// Return type: Void
    /// </summary>
    public void Read()
    {
        Console.WriteLine("Reading Word Document: " + Content);
    }

    /// <summary>
    /// Purpose: Write the content to the Word file.
    /// Return type: void
    /// </summary>
    /// <param name="content">Content to be written in word file</param>
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

    /// <summary>
    /// Purpose: Displays the content of the PDF document.
    /// Return type: Void
    /// </summary>
    public void Read()
    {
        Console.WriteLine("Reading PDF Document: " + Content);
    }
}
