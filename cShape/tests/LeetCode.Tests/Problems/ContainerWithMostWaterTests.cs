using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void Example1()
    {
        var result = ContainerWithMostWater.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

        Assert.Equal(49, result);
    }
}
