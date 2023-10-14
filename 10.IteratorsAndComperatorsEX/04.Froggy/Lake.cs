using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> items;
        public Lake(List<int> stones)
        {
            items = new List<int>(stones);
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return items[i];
                }
            }
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return items[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
