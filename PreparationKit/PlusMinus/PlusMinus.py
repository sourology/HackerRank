import math
import os
import random
import re
import sys


def plusMinus(arr):
    pos, neg, zer = 0, 0, 0
    for i in arr:
        if i > 0:
            pos += 1
        elif i < 0:
            neg += 1
        else:
            zer += 1

    pos_val, neg_val, zer_val = pos / n, neg / n, zer / n
    print("{:.6f}\n{:.6f}\n{:.6f}".format(pos_val, neg_val, zer_val))


if __name__ == "__main__":
    n = int(input().strip())
    arr = list(map(int, input().rstrip().split()))
    plusMinus(arr)
