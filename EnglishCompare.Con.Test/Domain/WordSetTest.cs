using EnglishCompare.Con.Domain;

namespace EnglishCompare.Con.Test.Domain;

internal class WordSetTest
{
    [Test]
    public void TestWordSet()
    {
        var test = "Mom, do you know where my phone is?is 5ab";
        var wordset = new WordSet();
        wordset.Add(test);
        Assert.IsTrue(wordset.GetCount() == 8);

    }

    [Test]
    public void TestReturn()
    {
        var target = "Mom, do you know where my phone is?is";
        var targetset = new WordSet();
        targetset.Add(target);

        var data = "mom,do you have A pen?";
        var dataset = new WordSet();
        dataset.Add(data);

        //積集合
        var inter=targetset.ReturnMatch(dataset.GetAll());
        Assert.IsTrue(inter.Count == 3);

        //和集合
        var diff=targetset.ReturnNonMatch(dataset.GetAll());
        Assert.IsTrue(diff.Count == 5);


    }
}
