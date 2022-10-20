namespace AdvCSAnimals;

public class FileOutput
{

    private string _fileName;
    private StreamWriter _writer = null;
    
    public FileOutput(string fileName) {
        this._fileName = fileName;
    }

    public void fileWrite(string line)
    {
        using(FileStream stream = new FileStream(_fileName, FileMode.Append))
        using (_writer = new StreamWriter(stream))
        {
            _writer.Write(line);
        }
    }

    public void fileClose() {
            if (_writer != null) {
                try {
                    _writer.Close();
                } catch (IOException e) {
                    Console.WriteLine(e.StackTrace);
                }
            }

    }
    
    
}