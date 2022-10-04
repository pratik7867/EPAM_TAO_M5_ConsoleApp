using EPAM_TAO_M5_ConsoleApp.ArraListOps;
using EPAM_TAO_M5_ConsoleApp.ArrayOps;
using EPAM_TAO_M5_ConsoleApp.DictionaryOps;
using EPAM_TAO_M5_ConsoleApp.ListOps;
using System;

namespace EPAM_TAO_M5_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Ops
            Console.WriteLine("---Array Operations---\n");
            ArrayOpsClass arrayOpsClass = new ArrayOpsClass();

            arrayOpsClass.AddElementToArray("APPLE");
            arrayOpsClass.AddElementToArray("ORANGE");
            arrayOpsClass.AddElementToArray("BANANA");

            arrayOpsClass.RemoveElementFromArray("BANANA");

            dynamic[] ArrOfInt = new dynamic[] { 1, 3, 6, 2 };
            arrayOpsClass.SortArray(ArrOfInt);

            //ArrayList Ops
            Console.WriteLine("\n---Array List Operations---\n");
            ArrayListOpsClass arrayListOpsClass = new ArrayListOpsClass();

            arrayListOpsClass.AddElementToArrayList("TREE");
            arrayListOpsClass.AddElementToArrayList(1);
            arrayListOpsClass.AddElementToArrayList('A');

            arrayListOpsClass.InsertElementAtIndexToArrayList(1, 1.5);

            arrayListOpsClass.RemoveElementFromArrayList('A');
            arrayListOpsClass.RemoveElementAtIndexFromArrayList(1);

            //List Ops
            Console.WriteLine("\n---List Operations---\n");
            ListOpsClass listOpsClass = new ListOpsClass();

            listOpsClass.AddElementToArrayList("RED");
            listOpsClass.AddElementToArrayList("GREEN");
            listOpsClass.AddElementToArrayList("BLUE");

            listOpsClass.InsertElementAtIndexToArrayList(1, "YELLOW");

            listOpsClass.RemoveElementFromArrayList("YELLOW");
            listOpsClass.RemoveElementAtIndexFromArrayList(1);

            //Dictionary Ops
            Console.WriteLine("\n---Dictionary Operations---\n");
            DictionaryOpsClass dictionaryOpsClass = new DictionaryOpsClass();

            dictionaryOpsClass.AddOrUpdateToDictionary("EMP1", "DEPT-A");
            dictionaryOpsClass.AddOrUpdateToDictionary("EMP2", "DEPT-B");
            dictionaryOpsClass.AddOrUpdateToDictionary("EMP3", "DEPT-C");
            dictionaryOpsClass.AddOrUpdateToDictionary("EMP3", "DEPT-D");

            dictionaryOpsClass.LookUpValueFromDictionary("EMP2");

            dictionaryOpsClass.RemoveFromDictionary("EMP3");

            Console.ReadLine();
        }
    }
}
