using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define an array of type "int" that can take up to 5 values.
            //Created the array in memory with the "new" keyword
            int[] nums = new int[5];

            //Define the values ​​of the array.
            //Arrays start at index zero
            nums[0] = 15;
            nums[1] = 20;
            nums[2] = 25;
            nums[3] = 5;
            nums[4] = 35;

            //If we use "nums[5] = 6;" we will encounter an error
            //because the array can hold at most 5 elements.

            printArray(nums);
            //output -> 15 20 25 5 35


            //We can find out the size of the array with "Length"
            Console.WriteLine("Length of array: "+nums.Length);
            //output -> Length of array: 5


            //We can sort the values ​​in the array with "Array.Sort()"
            Array.Sort(nums);
            printArray(nums);
            //output (new array) -> 5 15 20 25 35


            //We can print the array from the end with the "Array.Sort()" statement.
            Array.Reverse(nums);
            printArray(nums);
            //output (new array) -> 35 25 20 15 5


            //"Array.IndexOf()" is used to find the index of a value in the array.
            //If the value we are looking for is not in the array, the result is "-1"
            int searcIndex = Array.IndexOf(nums, 20);
            Console.WriteLine("Index of 20: "+searcIndex);
            //output -> Index of 20: 2

            searcIndex = Array.IndexOf(nums, 100);
            Console.WriteLine("Index of 100: " + searcIndex);
            //output -> Index of 100: -1


            //To clear a specific range of the array, "Array.Clear()" is used
            //Array.Clear(array, firstIndex, lastIndex)
            Array.Clear(nums, 1, 3);
            printArray(nums);
            //output -> 35 0 0 0 5


            //To change the size of the array, "Array.Resize()" is used
            Array.Resize(ref nums, 7);
            nums[5] = 85;
            nums[6] = 100;
            printArray(nums);
            //output -> 35 0 0 0 5 85 100
        }

        static void printArray(int[] arr)
        {
            for (int i = 0; i<arr.Length; i++)
                Console.Write(arr[i] +" ");
        }
    }
}
