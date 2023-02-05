public class LoadEntry
{
    public string _fileName = "";

    public void EntryLoader()
    {
        string data = File.ReadAllText($"{_fileName}.txt");
        Program.toBeSaved.Add(data);
    }
}