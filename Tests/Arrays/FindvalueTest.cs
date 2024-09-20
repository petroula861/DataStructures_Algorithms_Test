using Petras.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Arrays
{
    [TestFixture]
    public class FindvalueTest
    {
        [Test]
        public void GetsmallestPositiveIntegertest()
        {
            var val = new FindValue();
            Assert.That(val.GetsmallestPositiveInteger([1,3,6,4,1,2]), Is.EqualTo(5));
            Assert.That(val.GetsmallestPositiveInteger([1, 2,3]), Is.EqualTo(4));
            Assert.That(val.GetsmallestPositiveInteger([-1,-3]), Is.EqualTo(1));


        }
    }
}
