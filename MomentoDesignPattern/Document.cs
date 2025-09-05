public class Document
{
    public string Content { get; set; }

    public Document(string content)
    {
        Content = content;
    }

    // Save state (create a copy)
    public Memento Save()
    {
        return new Memento(Content);
    }

    // Restore state from Memento
    public void Restore(Memento memento)
    {
        Content = memento.Content;
    }

    public void Show(string label)
    {
        Console.WriteLine($"{label}: {Content}");
    }
}
