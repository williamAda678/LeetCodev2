from leetcode.problems.merge_two_sorted_lists import ListNode, merge_two_lists


def _values(node: ListNode | None) -> list[int]:
    result = []
    while node is not None:
        result.append(node.val)
        node = node.next
    return result


def test_example_1():
    list1 = ListNode(1, ListNode(2, ListNode(4)))
    list2 = ListNode(1, ListNode(3, ListNode(4)))

    assert _values(merge_two_lists(list1, list2)) == [1, 1, 2, 3, 4, 4]
