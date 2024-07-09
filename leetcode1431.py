# candies = [2,3,5,1,3]
# extra = 3
# greates = max(candies)
# output_array = []
# for i in range(len(candies)):
#     if candies[i] + extra >= greates:
#         output_array.append("true")
#     else:
#         output_array.append("false")

# print(output_array)


# #leetcode


class Solution(object):
    def kidsWithCandies(self, candies, extraCandies):
        """
        :type candies: List[int]
        :type extraCandies: int
        :rtype: List[bool]
        """

        greatest = max(candies)
        output_array = []
        for i in range(len(candies)):
            output_array.append(candies[i] + extraCandies >= greatest) #boolean
        return output_array


    