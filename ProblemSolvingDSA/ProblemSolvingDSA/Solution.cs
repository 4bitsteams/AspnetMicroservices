﻿using System.Numerics;

namespace ProblemSolvingDSA
{
    public static class Solution
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;

            int[] temp1 = new int[n];

            temp1[0] = 1;

            for (int i = 1; i < n; i++)
            {
                temp1[i] = temp1[i - 1] * nums[i - 1];
            }

            int surfixProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                temp1[i] = temp1[i] * surfixProduct;
                surfixProduct = nums[i] * surfixProduct;
            }

            return temp1;
        }
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            int top = 0;
            int down = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;
            int diff = 0;
            List<int> outPutList = new List<int>();
            while (top <= down && left <= right)
            {

                if (diff == 0)
                {
                    for (int i = left; i <= right; i++)
                    {
                        outPutList.Add(matrix[top][i]);
                    }
                    top = top + 1;
                }
                else if (diff == 1)
                {
                    for (int i = top; i <= down; i++)
                    {
                        outPutList.Add(matrix[i][right]);
                    }
                    right = right - 1;
                }
                else if (diff == 2)
                {
                    for (int i = right; i >= left; i--)
                    {
                        outPutList.Add(matrix[down][i]);
                    }
                    down = down - 1;
                }
                else if (diff == 3)
                {
                    for (int i = down; top <= i; i--)
                    {
                        outPutList.Add(matrix[i][left]);
                    }
                    left = left + 1;
                }
                diff = (diff + 1) % 4;
            }
            return outPutList;
        }
    }
}
