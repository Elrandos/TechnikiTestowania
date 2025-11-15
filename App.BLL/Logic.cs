using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class Logic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public IEnumerable<int> GetItems()
        {
            return new[] { 1, 2, 3 }.OrderBy(n=>Guid.NewGuid());
        }
    }
}
