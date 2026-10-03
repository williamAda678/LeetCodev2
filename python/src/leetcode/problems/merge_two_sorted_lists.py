from __future__ import annotations

from dataclasses import dataclass


class ListNode:
     def __init__(self, val=0, next=None):
         self.val = val
         self.next = next


def merge_two_lists(
    list1: ListNode | None, list2: ListNode | None
) -> ListNode | None:
        mergedList = ListNode(0)
        currentList = mergedList

        while list1  and list2 :
            if list1.val <= list2.val:
                currentList.next = list1
                list1 = list1.next
            else:
                currentList.next = list2
                list2 = list2.next
        
            currentList = currentList.next
    
        currentList.next = list1 or list2
        return mergedList.next
