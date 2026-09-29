using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class ValidPalindromeTests
{
    [Fact]
    public void Example1()
    {
        var result = ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama");

        Assert.True(result);
    }
}
