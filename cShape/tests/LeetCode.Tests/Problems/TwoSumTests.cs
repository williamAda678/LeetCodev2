using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class TwoSumTests
{
    [Fact]
    public void Example1()
    {
        var result = TwoSum.Solve(new[] { 2, 7, 11, 15 }, 9);

        Assert.Equal(new[] { 0, 1 }, result);
    }
}
