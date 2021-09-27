using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Class1
    {

        public class Solution
        {
            public int MinSubArrayLen(int target, int[] numbers)
            {
                var slow = 0;
                var fast = 0;
                var sum = 0;
                var min = int.MaxValue;

                while (fast < numbers.Length)
                {
                    sum += numbers[fast];

                    while (sum >= target)
                    {
                        min = Math.Min(min, fast + 1 - slow);
                        sum -= numbers[slow++];
                    }

                    fast++;
                }

                return min == int.MaxValue ? 0 : min;
            }
        }
    }
    }

