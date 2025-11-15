using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.BLLTests
{
    public class AddTestDataClass
    {
        public static IEnumerable<object[]> GetAddTestData()
        {
            return new List<object[]>
            {
                new object[]{ 1, 2, 3 },
                new object[]{ 10, -2, 18 },
            };
        }    
    }
}
