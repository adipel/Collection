using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Collection
{
    internal class CollectionOperations : ICollectionOperations
    {

        public void ListOperations(List<string> list)
        {
            if(list == null || list.Count == 0) throw new ArgumentNullException("list");

            RemoveAtTheMiddle(list);
            Add6IfContaindMama(list);
            ReverseIf(list);
        }

        public void DictionaryOperations(Dictionary<string, int> dict)
        {
            if (dict == null) throw new ArgumentNullException(nameof(dict));

            if (dict.ContainsKey("scuba") && dict["scuba"] == 6)
            {
                dict.Add("dive", 6);
            }
        }

        public void StackOperations(Stack<DateTime> stack)
        {
            if (stack == null) throw new ArgumentNullException(nameof(stack));

            if(stack.Peek() < DateTime.Now)
            {
                stack.Pop();
                stack.Push(DateTime.Now);
            }
        }



        private void RemoveAtTheMiddle (List<string> list)
        {
            int middleIndex = list.Count / 2;
            list.RemoveAt(middleIndex);
        }

        private void Add6IfContaindMama (List<string> list)
        {
            if (list.Contains("mama"))
            {
                list.Add("6");
            }
        }

        private void ReverseIf (List<string> list)
        {
            if (list.Contains("course59") && list.IndexOf("course59")%2!=0)
            {
                list.Reverse();
            }
        }

        private void If3DifferentValues (List<string> list)
        {
            List<string> onlyDiffrentValues = new List<string>();

            foreach (string value in list)
            {
                if(!onlyDiffrentValues.Contains(value))
                {
                    onlyDiffrentValues.Add(value);
                }
            }

            if(onlyDiffrentValues.Count == 3)
            {
                list.Insert(2, "2");
                list.Insert(1, "3");
                list.Insert(2, "4");
            }
        }
        
    }
}
