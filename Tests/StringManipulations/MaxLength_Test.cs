using Petras.StringManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.StringManipulations
{
    [TestFixture]
    public class MaxLength_Test
    {
        [Test]
        public void is_max_length_concatenated_string() 
        {
            MaxLength test= new MaxLength();
            Assert.That(test.MaxLengthConcatenatedString(["cha", "r", "act", "ers"]), Is.EqualTo(6));

            Assert.That(test.MaxLengthConcatenatedString(["abcdefghijklmnopqrstuvwxyz"]), Is.EqualTo(26));

        }
    }
}
