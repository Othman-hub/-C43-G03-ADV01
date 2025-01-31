using Assignment01ِADV.Q4;
using System.Collections;

namespace Assignment01ِADV
{
    internal class Program
    {
        #region 2.	You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        static void RevarseArrayList(ref ArrayList list)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                arrayList.Add(list[list.Count - 1 - i]);
            }
            list = arrayList;
        }
        #endregion
        #region 3.	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list
        static List<int> ReturnEvenNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                if (i % 2 == 0)
                    result.Add(i);
            }
            return result;
        }
        #endregion

        
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList() { 1,2,3,4,5};
            //RevarseArrayList(ref list);
            //foreach (object item in list)
            //{
            //    Console.WriteLine(item);
            //}
            FixedSizeList<int> list = new FixedSizeList<int>(3);
            list.GetItem(1);
            

        }
    }
}
