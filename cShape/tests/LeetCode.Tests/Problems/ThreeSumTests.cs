using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class ThreeSumTests
{
    [Fact]
    public void Example1()
    {
        var result = ThreeSum.Solve(new[] { -1, 0, 1, 2, -1, -4 });

        Assert.Equal(2, result.Count);
    }
}
