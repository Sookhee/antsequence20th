using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] antsequence = new int[1000];
            int[] tempArray = new int[1000];
            antsequence[0] = 1;
            int count = 1, j = 0, tempIndex = 0;

            int loop = 20;
            for (int i = 1; i < loop; i++)
            {
                while (antsequence[j] != 0)
                {
                    if (antsequence[j] == antsequence[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        tempArray[tempIndex++] = antsequence[j];
                        tempArray[tempIndex++] = count;
                        count = 1;
                    }
                    j++;
                }
                //antsequence = (int[])tempArray.Clone();
                Array.Copy(tempArray, antsequence, tempArray.Length);
                j = 0; tempIndex = 0;
            }

            //출력
            foreach (var item in antsequence)
            {
                if (item == 0) break;
                Console.Write(item);
            }
        }
    }
}
