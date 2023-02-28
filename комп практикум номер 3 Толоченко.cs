using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задание 1
            //int[] work1 = { 5353, 35574, 9, 325242, 73423 };

            //int max = work1[0];
            //int maxIndex = 0;


            //for (int i = 1; i < work1.Length; i++)
            //{
            //    if (work1[i] > max)
            //    {
            //        max = work1[i];
            //        maxIndex = i;
            //    }
            //}
            //Console.WriteLine("max element: " + max);
            //Console.WriteLine("maxindex: " + maxIndex);

            //Задание 2
            //int[] work2 = { 25252, 5352, 23425, 525252, 2244421 };
            //int min = work2[0];
            //int minindex = 0;
            //int max = work2[0];
            //int maxindex = 0;
            //for (int i = 0; i < work2.Length; i++)
            //{
            //    if (work2[i] > max)
            //    {
            //        max = work2[i];
            //        maxindex = i;
            //    }
            //}
            //for (int j = 0; j < work2.Length; j++)
            //{
            //    if (work2[j] < min)
            //    {
            //        min = work2[j];
            //        minindex = j;
            //    }
            //}
            //int temp = work2[maxindex];
            //work2[maxindex] = work2[minindex];
            //work2[minindex] = temp;
            //Console.WriteLine("max element: " + max);
            //Console.WriteLine("maxindex: " + maxindex);
            //Console.WriteLine("array after: ");
            //for (int i = 0; i < work2.Length; i++)
            //{
            //    Console.Write(work2[i] + " ");
            //}

            //Задание 3
            int[] work3 = { 352, 4653, 4633, 214, 141, 5463, 3241, 463636, };
            int minindex = 0;
            int maxindex = 0;
            for (int i = 1; i < work3.Length; i++)
            {
                if (work3[i] < work3[minindex])
                {
                    minindex = i;
                }
                if (work3[i] > work3[maxindex])
                {
                    maxindex = i;
                }
                int startindex = Math.Min(minindex, maxindex) + 1;
                int endindex = Math.Max(minindex, maxindex) - 1;
                int count = Math.Max(0, endindex - startindex + 1);
                Console.WriteLine($"value of elements between min and max:" + count);
            }

        }

    }

}

