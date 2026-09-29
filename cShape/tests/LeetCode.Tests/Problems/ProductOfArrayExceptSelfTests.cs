using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class ProductOfArrayExceptSelfTests
{
    [Fact]
    public void Example1()
    {
        var result = ProductOfArrayExceptSelf.ProductExceptSelf(new[] { 1, 2, 3, 4 });

        Assert.Equal(new[] { 24, 12, 8, 6 }, result);
    }
}
