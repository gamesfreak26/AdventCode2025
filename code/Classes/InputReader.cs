public class InputReader : IInputReader<string>
{
    private string Path { get; set; }

    public InputReader(string FilePath)
    {
        Path = FilePath;
    }

    public List<string> ReadEntireFile()
    {
        List<string> FileContents = [];

        try
        {
            FileContents = [.. File.ReadAllLines(Path)];
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }

        return FileContents;
    }
}