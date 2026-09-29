def two_sum(nums: list[int], target: int) -> list[int]:
        numDict = {}
        
        for i in range(len(nums)):
            curNum = nums[i]
            curTarget = target - curNum
            
            if curTarget in numDict:
                return [numDict[curTarget], i]
            
            numDict[curNum] = i
            
        return []
