using System;
using System.Collections.Generic;
using System.Linq;

namespace AppCore.BLL
{
    public class Logic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public IEnumerable<int> GetNumbers()
        {
            return (new int[] { 1, 2, 3 }).OrderBy(n => Guid.NewGuid());
        }

        private Random _rnd = new Random();
        public virtual int GetRandom(int max)
        {
            return _rnd.Next(max);
        }

        public string GetRandomWord(IEnumerable<string> words)
        {
            return words.ElementAt(GetRandom(words.Count()));
        }

    }
}
