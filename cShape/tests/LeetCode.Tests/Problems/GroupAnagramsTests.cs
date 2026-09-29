using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class GroupAnagramsTests
{
    [Fact]
    public void Example1()
    {
        var result = GroupAnagrams.Group(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });

        Assert.Equal(3, result.Count);
    }
}
