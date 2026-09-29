from leetcode.problems.group_anagrams import group_anagrams


def test_example_1():
    result = group_anagrams(["eat", "tea", "tan", "ate", "nat", "bat"])
    assert len(result) == 3
