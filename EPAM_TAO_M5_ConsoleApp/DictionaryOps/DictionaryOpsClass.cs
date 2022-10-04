using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_TAO_M5_ConsoleApp.DictionaryOps
{
    class DictionaryOpsClass
    {
        Dictionary<string, dynamic> DictOfItems = new Dictionary<string, dynamic>();

        public void AddOrUpdateToDictionary(string StrKey, dynamic Value)
        {
            if(!DictOfItems.ContainsKey(StrKey))
            {
                Console.WriteLine(String.Format("Key {0}-Value {1} added to dictionary", StrKey, Value));
                DictOfItems.Add(StrKey, Value);
            }
            else
            {
                Console.WriteLine(String.Format("Key {0}-Value {1} updated in dictionary", StrKey, Value));
                DictOfItems[StrKey] = Value;
            }
            IterateOverDictionary(DictOfItems);
        }

        public void LookUpValueFromDictionary(string StrKey)
        {
            if (DictOfItems.ContainsKey(StrKey))
            {
                Console.WriteLine(String.Format("Looked up value:{0} for key:{1}",DictOfItems[StrKey], StrKey));
            }
        }

        public void RemoveFromDictionary(string StrKey)
        {
            if (DictOfItems.ContainsKey(StrKey))
            {
                DictOfItems.Remove(StrKey);
                Console.WriteLine(String.Format("Key {0} removed from dictionary", StrKey));
            }
            IterateOverDictionary(DictOfItems);
        }

        private void IterateOverDictionary(Dictionary<string, dynamic> Dictionary)
        {
            foreach(KeyValuePair<string, dynamic> KeyValuePairItem in Dictionary)
            {
                Console.WriteLine(KeyValuePairItem.Key + "->" + KeyValuePairItem.Value + "\t");
            }
        }
    }
}
