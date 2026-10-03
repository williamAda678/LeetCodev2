namespace LeetCode.Problems;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode next = next;
}

public static class MergeTwoSortedLists
{
    public static ListNode? Merge(ListNode? list1, ListNode? list2)
    {
        ListNode mergedList = new ListNode(0);
        ListNode currentList = mergedList;


        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                currentList.next = list1;
                list1 = list1.next;
            }
            else
            {
                currentList.next = list2;
                list2 = list2.next;
            }

            currentList = currentList.next;

        }
        currentList.next = list1 ?? list2;
        return mergedList.next;
    }
}
