using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCsharp
{
    partial class main
    {
        static int[] TwoSum(int[] nums, int target)
        {
            //local data
            int[] array = new int[2];
            int sizeOfArray = 0;
            int counter = 0;

            foreach (int i in nums)
            {
                sizeOfArray = sizeOfArray + 1;
            }

            for (int e = 0; e < sizeOfArray - 1; e++)
            {
                counter = 0;

                foreach (int i in nums)
                {
                    if (e != counter)
                    {
                        if (nums[e] + i == target)
                        {
                            array[0] = e;
                            array[1] = counter;
                        }
                    }

                    counter = counter + 1;
                }
            }

            return array;
        }
    }
}
