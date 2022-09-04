using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void plusMinus(List<int> arr)
    {
        double n = arr.Count, pos = 0, neg = 0, zer = 0;

        foreach (var i in arr)
        {
            if (i > 0)
                pos += 1;
            else if (i < 0)
                neg += 1;
            else
                zer += 1;
        }

        double posVal = pos / n;
        double negVal = neg / n;
        double zerVal = zer / n;
        
        Console.WriteLine(string.Format("{0:N6}", posVal));
        Console.WriteLine(string.Format("{0:N6}", negVal));
        Console.WriteLine(string.Format("{0:N6}", zerVal));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.plusMinus(arr);
    }
}
