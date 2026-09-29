from leetcode.problems.three_sum import three_sum


def test_example_1():
    result = three_sum([-1, 0, 1, 2, -1, -4])
    assert len(result) == 2
