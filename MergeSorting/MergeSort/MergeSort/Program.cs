using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {

        public void sortingTheArray(int[] array, int left, int right)
        {
            int middle;
            if (right > left)
            {
                middle = (right + left) / 2;

                sortingTheArray(array, left, middle);

                sortingTheArray(array, (middle + 1), right);

                 mergingTheArray(array, left, (middle + 1), right);

            }
        }

        public void mergingTheArray(int[] array, int left, int middle, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tempPosition;
            left_end = (middle - 1);
            tempPosition = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (middle <= right))
            {
                if (array[left] <= array[middle])
                {
                    temp[tempPosition++] = array[left++];
                }
                else
                {
                    temp[tempPosition++] = array[middle++];
                }
            }
            while (left <= left_end)
            {
                temp[tempPosition++] = array[left++];
            }

            while (middle <= right)
            {
                temp[tempPosition++] = array[middle++];
            }

            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right];
                right--;
            }

        }

        public static void Main(string[] args)

        {

            int[] array = { 4, 6, 9, 5, 2, 7, 1, 8, 5, 11 };
            int length = array.Length;
            Program obj = new Program();
            Console.WriteLine("The Initial Array is ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\n");
            obj.sortingTheArray(array, 0, length - 1);
            Console.WriteLine("The Sorted Array is ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
