namespace LeetCode.Problems;

public static class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        int l = 0;
        int r = x;
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        while (r > l)
        {
            l = l * 10 + r % 10;
            r = r / 10;
        }

        return l == r || r == l / 10;
    }
}
