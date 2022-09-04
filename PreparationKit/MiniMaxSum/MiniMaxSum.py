import math
import os
import random
import re
import sys


def miniMaxSum(arr):
    temp = []
    for i in range(0, len(arr)):
        cop = arr.copy()
        tot, cop[i] = 0, 0
        for val in cop:
            tot += val
        temp.append(tot)

    min_val, max_val = min(temp), max(temp)
    print(min_val, max_val)


if __name__ == "__main__":
    arr = list(map(int, input().rstrip().split()))
    miniMaxSum(arr)
