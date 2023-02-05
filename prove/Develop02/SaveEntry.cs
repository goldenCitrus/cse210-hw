public class SaveEntry
{
    public string _fileName = "";
    public List<string> _textContent = new List<string>();

    public void EntrySaver()
    {
        File.WriteAllLines($"{_fileName}.txt", _textContent);
    }
}