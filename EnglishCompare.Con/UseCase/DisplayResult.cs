using EnglishCompare.Con.Domain;

namespace EnglishCompare.Con.UseCase;

public class DisplayResult
{
	private IWordSetRepo _target;
	private IWordSetRepo _database;
	public DisplayResult(IWordSetRepo target, IWordSetRepo database)
	{
		this._target = target;
		this._database = database;
	}

	public void Run()
	{
		DateTime now=DateTime.Now;
		var nowTime = now.ToString("yyyyy/MM/dd HH:mm:ss");

        Console.WriteLine($"処理開始:{nowTime}");
		try
		{
            var target = _target.GetWordSet();
            var database = _database.GetWordSet();

			Console.WriteLine($"Target:{target.GetCount()}");
            Console.WriteLine($"Database:{database.GetCount()}");

			var interSet = target.ReturnMatch(database.GetAll());
			int targetCount = target.GetCount();
			double cover=(double)interSet.Count()/ (double)targetCount*100;
			Console.WriteLine($"カバー率:{cover.ToString("N1")}");

			Console.WriteLine("一致しなかった単語");
			var deffSet = target.ReturnNonMatch(database.GetAll());
			foreach(var deff in deffSet )
			{
				Console.WriteLine(deff.Content);
			}

        }
        catch(Exception ex)
		{
			Console.WriteLine(ex);
		}
		


	}
    
}
