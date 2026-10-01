def is_anagram(s: str, t: str) -> bool:
     if len(s) != len(t):
        return False

     sLetter = {}
     tLetter = {}

     for i in range(len(s)):
        sLetter[s[i]] = sLetter.get(s[i], 0) + 1
        tLetter[t[i]] = tLetter.get(t[i], 0) + 1

     return sLetter == tLetter