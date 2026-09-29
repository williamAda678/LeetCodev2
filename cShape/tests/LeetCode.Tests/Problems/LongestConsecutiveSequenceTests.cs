using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class LongestConsecutiveSequenceTests
{
    [Fact]
    public void Example1()
    {
        var result = LongestConsecutiveSequence.LongestConsecutive(new[] { 100, 4, 200, 1, 3, 2 });

        Assert.Equal(4, result);
    }
}
