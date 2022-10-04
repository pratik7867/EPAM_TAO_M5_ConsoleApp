using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_TAO_M5_ConsoleApp.ArraListOps
{
    class ArrayListOpsClass
    {
        ArrayList ArrListOfItems = new ArrayList();

        public void AddElementToArrayList(dynamic ItemToAdd)
        {
            ArrListOfItems.Add(ItemToAdd);
            Console.WriteLine("Element added to array list: " + ItemToAdd);
            IterateOverArrayList(ArrListOfItems);
        }

        public void InsertElementAtIndexToArrayList(int IntPosition, dynamic ItemToAdd)
        {
            if (IntPosition >= 0)
            {
                ArrListOfItems.Insert(IntPosition, ItemToAdd);
                Console.WriteLine(String.Format("Element added at index {0} to array list {1}", IntPosition,ItemToAdd));
                IterateOverArrayList(ArrListOfItems);
            }
            else
            {
                Console.WriteLine("Invalid position to insert the element at.");
            }
        }

        public void RemoveElementFromArrayList(dynamic ItemToRemove)
        {
            if(ArrListOfItems.Contains(ItemToRemove))
            {
                ArrListOfItems.Remove(ItemToRemove);
                Console.WriteLine("Element removed from array list: " + ItemToRemove);
                IterateOverArrayList(ArrListOfItems);
            }
        }

        public void RemoveElementAtIndexFromArrayList(int IntPosition)
        {
            if (IntPosition >= 0)
            {
                ArrListOfItems.RemoveAt(IntPosition);
                Console.WriteLine(String.Format("Element removed at index {0} from array list", IntPosition));
                IterateOverArrayList(ArrListOfItems);
            }
            else
            {
                Console.WriteLine("Invalid position to remove the element at.");
            }
        }

        private void IterateOverArrayList(ArrayList ArrList)
        {
            foreach(var Item in ArrList)
            {
                Console.WriteLine(Item + "\t");
            }
        }
    }
}
