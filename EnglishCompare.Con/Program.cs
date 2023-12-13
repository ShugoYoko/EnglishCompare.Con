using EnglishCompare.Con.Domain;
using EnglishCompare.Con.UseCase;
using EnglishCompare.Con.Infrastructure;


namespace EnglishCompare.Con;

public class Program
{
    static void Main(string[] args)
    {
        string targetPath = @"./Target";
        string dataPath = @"./Database";
        IWordSetRepo target = new WordSetFileRepo(targetPath);
        IWordSetRepo database=new WordSetFileRepo(dataPath);

        var diplayCase = new DisplayResult(target, database);
        diplayCase.Run();
        Console.ReadLine();


    }
}