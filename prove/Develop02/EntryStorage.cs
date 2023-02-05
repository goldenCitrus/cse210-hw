public class EntryStorage
{
    public string _entry = "";
    public string _askedQuestion = "";
    public DateTime _date = DateTime.Now;

    public void TempEntry()
    {
        string _toBeSaved = ($"On {_date}, in response to the question: {_askedQuestion}:\n{_entry}\n");
        Program.toBeSaved.Add(_toBeSaved);
    }
}