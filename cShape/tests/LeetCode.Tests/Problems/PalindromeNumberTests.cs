using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class PalindromeNumberTests
{
    [Fact]
    public void Example1()
    {
        var result = PalindromeNumber.IsPalindrome(121);

        Assert.True(result);
    }

    [Fact]
    public void Example2()
    {
        var result = PalindromeNumber.IsPalindrome(-121);

        Assert.False(result);
    }

    [Fact]
    public void Example3()
    {
        var result = PalindromeNumber.IsPalindrome(10);

        Assert.False(result);
    }
}
