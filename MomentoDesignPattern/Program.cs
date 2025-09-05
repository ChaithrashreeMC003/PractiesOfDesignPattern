class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create object
        Document doc = new Document("Version 1");
        doc.Show("Original");

        // Step 2: Save copy
        Memento savedCopy = doc.Save();

        // Step 3: Modify object
        doc.Content = "Version 2 (modified)";
        doc.Show("Modified");

        // Step 4: Revert back to saved copy
        doc.Restore(savedCopy);
        doc.Show("Reverted to first copy");
    }
}