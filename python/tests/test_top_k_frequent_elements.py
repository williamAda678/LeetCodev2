from leetcode.problems.top_k_frequent_elements import top_k_frequent


def test_example_1():
    result = top_k_frequent([1, 1, 1, 2, 2, 3], 2)
    assert len(result) == 2
