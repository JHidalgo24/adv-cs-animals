namespace AdvCSAnimals;

public class FileOutput
{

    private string _fileName;
    private StreamWriter _writer;
    
    public FileOutput(string fileName) {
        this._fileName = fileName;
    }

    public void FileWrite(string line)
    {
        using(FileStream stream = new FileStream(_fileName, FileMode.Append))
        using (_writer = new StreamWriter(stream))
        {
            _writer.WriteLine(line);
        }
    }

    public void FileClose() {
            if (_writer != null) {
                try {
                    _writer.Close();
                } catch (IOException e) {
                    Console.WriteLine(e.StackTrace);
                }
            }

    }
    
    
}