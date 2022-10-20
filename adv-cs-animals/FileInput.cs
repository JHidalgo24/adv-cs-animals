namespace AdvCSAnimals;

public class FileInput
{
    private StreamReader _inReader;
    private string _fileName;

    public FileInput(String fileName) {
        this._fileName = fileName;
        try
        {
            _inReader = new StreamReader(fileName);
        } catch (FileNotFoundException e) {
            Console.WriteLine($"File Open Error: {fileName} \n {e} ");
        }
    }

    public void fileRead() {
        string line;
        try {
            while ((line = _inReader.ReadLine()) != null) {
                Console.WriteLine(line);
            }
        } catch (Exception e) {
            Console.WriteLine($"File Read Error: {_fileName} {e}");
        }
        _inReader.Close();
    }

    public String fileReadLine() {
        try {
            String line = _inReader.ReadLine();
            return line;
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + _fileName + " " + e);
            return null;
        }
    }

    public void fileClose() {
        if (_inReader != null) {
            try {
                _inReader.Close();
            } catch (IOException e) {
                Console.Write(e.Message);
            }
        }

    }
}