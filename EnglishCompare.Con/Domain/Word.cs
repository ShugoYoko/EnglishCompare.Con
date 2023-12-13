using System.Text.RegularExpressions;

namespace EnglishCompare.Con.Domain;

public class Word
{
	public string Content { get; private set; }
	public Word(string word)
	{
        Content = word.ToLower();
    }

    public bool CanAdd()
	{
		var numRegex = new Regex(@"\d+");

		if (numRegex.IsMatch(this.Content) || this.Content.Contains("'") || this.Content.Contains("’"))
		{
			return false;
        }

        return true;
	}

    public override int GetHashCode()
    {
        return this.Content.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        Word? word = obj as Word;
        if (word == null)
        {
            return false;
        }
        return this.Content == word.Content;
    }
}
