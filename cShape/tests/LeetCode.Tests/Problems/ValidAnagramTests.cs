using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class ValidAnagramTests
{
    [Fact]
    public void Example1()
    {
        var result = ValidAnagram.IsAnagram("anagram", "nagaram");

        Assert.True(result);
    }
}
