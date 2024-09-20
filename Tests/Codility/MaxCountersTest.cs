using Petras.codility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Codility
{
    [TestFixture]
    public class MaxCountersTest
    {
        [Test]
        public void MaxCounters() { 
            var counter=new MaxCounters();
        Assert.AreEqual(counter.solution(5, [3, 4, 4, 6, 1, 4, 4]),new int [3, 2, 2, 4, 2]);
        }
    }
}
