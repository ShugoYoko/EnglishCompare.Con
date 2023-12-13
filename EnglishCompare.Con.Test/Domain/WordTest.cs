using EnglishCompare.Con.Domain;

namespace EnglishCompare.Con.Test.Domain;

internal class WordTest
{
    [Test]
    public void TestWord()
    {
        var word1 = new Word("ABC");
        Assert.IsTrue(word1.Content == "abc");
        Assert.IsTrue(word1.CanAdd());

        var word2 = new Word("A1");
        Assert.IsTrue(word2.Content == "a1");
        Assert.IsTrue(!word2.CanAdd());

        var word3 = new Word("yoU'll");
        Assert.IsTrue(word3.Content == "you'll");
        Assert.IsTrue(!word3.CanAdd());




        
    }
}
