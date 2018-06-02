using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM2.Library
{
    public class Builder
    {

        public IEnumerable<int> BuildIntegerSequence()
        {
            //var integers = Enumerable.Range(0, 10)
            //                .Select(i => 5+(10 * i));

            var integers = Enumerable.Repeat(-1, 10);
            return integers;
        }

        public IEnumerable<string> BuildStringSequence()
        {
            var strings = Enumerable.Range(0, 10)
                            .Select(i => ((char)('A' + i)).ToString());

            return strings; 
        }
    }
}
