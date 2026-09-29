namespace LeetCode.Problems;

public static class TwoSum
{
    public static int[] Solve(int[] nums, int target)
    {
        Dictionary<int, int> num = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int curNum = nums[i];
            int curTarget = target - curNum;

            if (num.ContainsKey(curTarget))
            {
                return [num[curTarget], i];
            }

            num[curNum] = i;
        }

        return [];
    }
}
