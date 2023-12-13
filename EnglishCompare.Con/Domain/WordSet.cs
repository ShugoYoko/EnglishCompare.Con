

namespace EnglishCompare.Con.Domain;

public class WordSet
{
    HashSet<Word> _words;

    public WordSet()
    {
        this._words = new HashSet<Word>();
    }


    public int GetCount()
    {
        return this._words.Count;
    }

    public void Add(string content)
    {
        var words = content.Split(',', ':', '!', '?',' ','.');
        foreach (var word in words)
        {
            var addWord = new Word(word);
            if (addWord != null && addWord.CanAdd() && word!="")
            {
                this._words.Add(addWord);
            }
        }
    }

    public HashSet<Word> GetAll()
    {
        HashSet<Word> result = new HashSet<Word>();
        foreach(var w in this._words)
        {
            result.Add(w);
        }
        return result;
    }

    public HashSet<Word> ReturnMatch(HashSet<Word> wordSet)
    {
        if (wordSet != null)
        {
            var sets = this.GetAll();
            sets.IntersectWith(wordSet);
            return sets;
        }

        var empty = new HashSet<Word>();
        return empty;

    }

    public HashSet<Word> ReturnNonMatch(HashSet<Word> wordSet)
    {
        if (wordSet != null)
        {
            var sets = this.GetAll();
            sets.ExceptWith(wordSet);
            return sets;
        }

        return this._words;

    }


}
