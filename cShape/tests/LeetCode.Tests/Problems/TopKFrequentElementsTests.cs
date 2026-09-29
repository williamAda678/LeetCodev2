using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class TopKFrequentElementsTests
{
    [Fact]
    public void Example1()
    {
        var result = TopKFrequentElements.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);

        Assert.Equal(2, result.Length);
    }
}
