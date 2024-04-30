using Petras.StringManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.StringManipulations
{

    [TestFixture]
    public class OneCharacterChange_test
    {

        [Test]
        public void  CheckOneAway_test() {

            OneCharacterChange c = new OneCharacterChange(){ };

            Assert.IsTrue(c.CheckOneAway("pale","ple"));
            Assert.IsTrue(c.CheckOneAway("pales", "pale"));
            Assert.IsTrue(c.CheckOneAway("pale", "bale"));
            Assert.IsFalse(c.CheckOneAway("pale", "bae"));
            Assert.IsTrue(c.CheckOneAway("pale", "pale"));



        }


    }

}
