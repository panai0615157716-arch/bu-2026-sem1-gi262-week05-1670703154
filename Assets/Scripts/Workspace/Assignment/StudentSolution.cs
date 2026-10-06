using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture 

        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }
                int temp = numbers[min];
                numbers[min] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[max])
                    {
                        max = j;
                    }
                }
                int temp = numbers[max];
                numbers[max] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers.Length < 2) return 0;

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max1)
                {
                    max2 = max1;
                    max1 = numbers[i];
                }
                else if (numbers[i] > max2 && numbers[i] != max1)
                {
                    max2 = numbers[i];
                }
            }
            return max2;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            Array.Sort(numbers);

            int longest = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    if (numbers[i] == numbers[i - 1] + 1)
                    {
                        currentCount++;
                    }
                    else
                    {
                        if (currentCount > longest)
                        {
                            longest = currentCount;
                        }
                        currentCount = 1;
                    }
                }
            }

            if (currentCount > longest)
            {
                longest = currentCount;
            }

            return longest;
        }

        #endregion
    }
}