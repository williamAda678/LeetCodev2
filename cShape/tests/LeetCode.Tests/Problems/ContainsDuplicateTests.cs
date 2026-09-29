using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class ContainsDuplicateTests
{
    [Fact]
    public void Example1()
    {
        var result = ContainsDuplicate.HasDuplicate(new[] { 1, 2, 3, 1 });

        Assert.True(result);
    }
}
