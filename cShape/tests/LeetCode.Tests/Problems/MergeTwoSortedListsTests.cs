using LeetCode.Problems;

namespace LeetCode.Tests.Problems;

public class MergeTwoSortedListsTests
{
    [Fact]
    public void Example1()
    {
        ListNode list1 = new(1, new(2, new(4)));
        ListNode list2 = new(1, new(3, new(4)));

        var result = MergeTwoSortedLists.Merge(list1, list2);

        Assert.Equal(new[] { 1, 1, 2, 3, 4, 4 }, Values(result));
    }

    private static IEnumerable<int> Values(ListNode? node)
    {
        while (node is not null)
        {
            yield return node.val;
            node = node.next;
        }
    }
}
