using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCsharp
{
    partial class main
    {
        static int SearchInsert(int[] nums, int target)
        {
            // local
            int result = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == target)
                {
                    result = i;
                    return result;
                }
                else if (target > nums[i])
                {
                    result = i + 1;
                }
            }

            if (target > nums[result])
            {
                result = result + 1;
            }

            return result;
        }
    }
}
