using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class TrappingRainWaterTests
{
    [Fact]
    public void Example1()
    {
        var result = TrappingRainWater.Trap(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });

        Assert.Equal(6, result);
    }
}
