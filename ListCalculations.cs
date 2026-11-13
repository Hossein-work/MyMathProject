using System;
using System.Collections.Generic;
using System.Text;

namespace MyMathProject
{
    internal static class ListCalculations
    {
        internal static void ListReverse(this List<long> listInput, List<long> outPut)
        {
            if (listInput.Count == 1)
            {
                outPut.Add(listInput[0]);
            }
            else
            {
                outPut.Add(listInput[listInput.Count - 1]);
                listInput.RemoveAt(listInput.Count - 1);
                ListReverse(listInput, outPut);
            }
        }
    }
}
