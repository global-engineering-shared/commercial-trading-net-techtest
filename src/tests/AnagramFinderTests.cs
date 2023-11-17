namespace tests;

public class AnagramFinderTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReturnExpectedAnagrams()
    {
        var output = TestHelper.CapturedStdOut(()=>TestHelper.RunConsoleApp(new string[] {@"..\..\..\..\..\example1.txt"}));

        StringAssert.IsMatch(output[0], "abc,bac,cba");        
        StringAssert.IsMatch(output[1], "fun,unf");        
        StringAssert.IsMatch(output[2], "hello");        
    }

}