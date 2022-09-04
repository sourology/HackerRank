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
    public static void miniMaxSum(List<int> arr)
    {
        int size = arr.Count;
        List<long> temp = new List<long>(size);
        
        for (int i = 0; i < size; i++)
        {
            List<int> cop = new List<int>(arr);
            cop[i] = 0; long sum = 0;
            
            foreach (var val in cop)
                sum += val;
            
            temp.Add(sum);
        }
        
        Console.Write(temp.Min() + " " + temp.Max());
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.miniMaxSum(arr);
    }
}