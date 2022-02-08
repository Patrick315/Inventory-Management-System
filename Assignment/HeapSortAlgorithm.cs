using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class HeapSortAlgorithm
    {
        // convert a complete binary tree into a heap
        public static void HeapBottomUp(Tool[] data)
        {
            int n = HeapSortAlgorithm.ReturnArraySize(data);
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                int k = i;
                Tool v = data[i];
                bool heap = false;
                while ((!heap) && ((2 * k + 1) <= (n - 1)) && v != null)
                {
                    int j = 2 * k + 1;  //the left child of k
                    if (j < (n - 1))   //k has two children
                        if (data[j] != null && data[j + 1] != null && data[j].NoBorrowings < data[j + 1].NoBorrowings)
                            j = j + 1;  //j is the larger child of k
                    if (v != null && data[j] != null && v.NoBorrowings >= data[j].NoBorrowings)
                        heap = true;
                    else
                    {
                        data[k] = data[j];
                        k = j;
                    }
                }
                data[k] = v;
            }
        }

        // sort the elements in an array 
        public static Tool[] HeapSort(Tool[] data)
        {
            Tool[] testArray = new Tool[3];
            int dataSize = HeapSortAlgorithm.ReturnArraySize(data);
            //Use the HeapBottomUp procedure to convert the array, data, into a heap
            HeapBottomUp(data);


            //repeatly remove the maximum key from the heap and then rebuild the heap
            for (int i = 0; i < 3; i++)
            {
                testArray[i] = MaxKeyDelete(data, data.Length - i);               
            }

            return testArray;
        }

        //delete the maximum key and rebuild the heap
        public static Tool MaxKeyDelete(Tool[] data, int size)
        {
            
            //1. Exchange the root’s key with the last key K of the heap;
            Tool temp = data[0];
            data[0] = data[size - 1];
            data[size - 1] = temp;

            //2. Decrease the heap’s size by 1;
            int n = size - 1;

            //3. “Heapify” the complete binary tree.
            bool heap = false;
            int k = 0;
            Tool v = data[0];
            while ((!heap) && ((2 * k + 1) <= (n - 1)))
            {
                int j = 2 * k + 1; //the left child of k
                if (j < (n - 1))   //k has two children
                    if (data[j] != null && data[j + 1] != null && data[j].NoBorrowings < data[j + 1].NoBorrowings)
                        j = j + 1;  //j is the larger child of k
                if (v != null && data[j] != null && v.NoBorrowings >= data[j].NoBorrowings)
                    heap = true; 
                else
                {
                    data[k] = data[j];
                    k = j;
                }
            }
            data[k] = v;
            return data[n];
        }

        public static int ReturnArraySize(Tool[] toolArray)
        {
            int arraySize = 0;
            for (int i = 0; i < toolArray.Length; i++)
            {
                if (toolArray[i] != null)
                {
                    arraySize++;
                }
            }
            return arraySize;
        }
    }
}
