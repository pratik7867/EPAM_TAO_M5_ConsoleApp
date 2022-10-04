using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_TAO_M5_ConsoleApp.ArrayOps
{
    class ArrayOpsClass
    {        
        string[] ArrOfStr = new string[5];

        bool BoolIsArrayOverFlow;

        public void AddElementToArray(dynamic ItemToAdd)
        {
            BoolIsArrayOverFlow = false;

            for (int i=0; i<ArrOfStr.Length; i++)
            {
                if(ArrOfStr[i] == null)
                {
                    ArrOfStr[i] = ItemToAdd.ToString();
                    break;
                }
                else
                {
                    if (i == ArrOfStr.Length)
                        BoolIsArrayOverFlow = true;
                }
            }

            if(BoolIsArrayOverFlow)
            {
                Console.WriteLine("The array is overflowed");
            }
            else
            {
                Console.WriteLine("Element added to array: " + ItemToAdd);
            }
        }

        public void RemoveElementFromArray(dynamic ItemToRemove)
        {
            ArrOfStr = ArrOfStr.Where(val => val != ItemToRemove).ToArray();
            Console.WriteLine("Element removed from array: " + ItemToRemove);

            foreach (var Item in ArrOfStr)
            {
                Console.WriteLine(Item);
            }
        }

        public void SortArray(dynamic[] ArrOfItems)
        {
            for(int i=1; i<ArrOfItems.Length; i++)
            {
                var Item = ArrOfItems[i];
                int j = i-1;

                while(j >= 0 && ArrOfItems[j].CompareTo(Item) > 0)
                {
                    ArrOfItems[j + 1] = ArrOfItems[j];
                    j = j - 1;
                }
                ArrOfItems[j+1] = Item;
            }

            foreach (var Item in ArrOfItems)
            {
                Console.WriteLine("Sorted array in ascending order: " + Item);
            }
        }
    }
}
