
using EnglishCompare.Con.Domain;
using System.IO;

namespace EnglishCompare.Con.Infrastructure;

public class WordSetFileRepo:IWordSetRepo
{
    private string _path;
    public WordSetFileRepo(string path){
        this._path = path;

    }
 
    public WordSet GetWordSet()
    {

        var files = Directory.GetFiles(this._path, "*", SearchOption.AllDirectories);
        var results=new WordSet();
        try
        {
            foreach (var file in files)
            {
                using (var reader = new StreamReader(file))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line != null)
                        {
                            results.Add(line);
                        }
                        
                    }

                }
            }
        }
        catch (Exception)
        {
            throw;
        }

        return results;
    }
}
