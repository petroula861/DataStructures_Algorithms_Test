using Petras.codility.Leader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Leader
{
    [TestFixture]
    public class DominatorTest
    {
        [Test]
       public void Dominator()
        {
            var d=new Dominator();

            Assert.Equals(d.solution([2, 1, 1, 1, 3]), 1);
        } 
    }
}
