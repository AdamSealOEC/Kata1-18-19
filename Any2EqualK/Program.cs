using System;
using System.Collections.Generic;

namespace Any2EqualK
{
    class Program
    {
        static bool Main(List<int> nums, int k)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if ((nums[i] + nums[j]) == k)
                        return true;
                }
            }
            return false;
        }
    }
}