from leetcode.problems.palindrome_number import is_palindrome_number


def test_example_1():
    assert is_palindrome_number(121) is True


def test_example_2():
    assert is_palindrome_number(-121) is False


def test_example_3():
    assert is_palindrome_number(10) is False
