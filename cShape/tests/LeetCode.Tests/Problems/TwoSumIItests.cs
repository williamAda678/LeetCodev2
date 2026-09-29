using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class TwoSumIITests
{
    [Fact]
    public void Example1()
    {
        var result = TwoSumII.TwoSum(new[] { 2, 7, 11, 15 }, 9);

        Assert.Equal(new[] { 1, 2 }, result);
    }
}
