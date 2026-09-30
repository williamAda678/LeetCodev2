namespace LeetCode.Problems;

public static class ContainsDuplicate
{
    public static bool HasDuplicate(int[] nums)
    {
        HashSet<int> seen = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.Contains(nums[i]))
            {
                return true;
            }
            seen.Add(nums[i]);
        }

        return false;
    }
}
