using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal interface ICollectionOperations
    {
        void ListOperations(List<string> list);
        void DictionaryOperations(Dictionary<string, int> dictionary);
        void StackOperations(Stack<DateTime> stack);
    }
}
