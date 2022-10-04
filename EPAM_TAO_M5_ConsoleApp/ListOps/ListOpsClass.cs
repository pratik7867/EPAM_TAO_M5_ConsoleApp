using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_TAO_M5_ConsoleApp.ListOps
{
    class ListOpsClass
    {
        List<string> ListOfItems = new List<string>();

        public void AddElementToArrayList(dynamic ItemToAdd)
        {
            ListOfItems.Add(ItemToAdd.ToString());
            Console.WriteLine("Element added to array list: " + ItemToAdd);
            IterateOverArrayList(ListOfItems);
        }

        public void InsertElementAtIndexToArrayList(int IntPosition, dynamic ItemToAdd)
        {
            if (IntPosition >= 0)
            {
                ListOfItems.Insert(IntPosition, ItemToAdd.ToString());
                Console.WriteLine(String.Format("Element added at index {0} to array list {1}", IntPosition, ItemToAdd));
                IterateOverArrayList(ListOfItems);
            }
            else
            {
                Console.WriteLine("Invalid position to insert the element at.");
            }
        }

        public void RemoveElementFromArrayList(dynamic ItemToRemove)
        {
            if (ListOfItems.Contains(ItemToRemove))
            {
                ListOfItems.Remove(ItemToRemove.ToString());
                Console.WriteLine("Element removed from array list: " + ItemToRemove);
                IterateOverArrayList(ListOfItems);
            }
        }

        public void RemoveElementAtIndexFromArrayList(int IntPosition)
        {
            if (IntPosition >= 0)
            {
                ListOfItems.RemoveAt(IntPosition);
                Console.WriteLine(String.Format("Element removed at index {0} from array list", IntPosition));
                IterateOverArrayList(ListOfItems);
            }
            else
            {
                Console.WriteLine("Invalid position to remove the element at.");
            }
        }

        private void IterateOverArrayList(List<string> List)
        {
            foreach (var Item in List)
            {
                Console.WriteLine(Item + "\t");
            }
        }
    }
}
