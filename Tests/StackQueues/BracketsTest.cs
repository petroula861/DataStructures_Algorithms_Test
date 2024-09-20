using Petras.codility.StackQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.StackQueues
{
    [TestFixture]
    public class StackQUEUES
    {

        [Test]
        public void Bracket_Test()
        {
            var brackets = new Brackets();

            Assert.AreEqual(brackets.solution("({[()()]})"), 1);
            //Assert.AreEqual(brackets.Solution("{{[()(])}}"), 1);

           // Assert.AreEqual(brackets.Solution("{[())]}"), 0);

        }
    }
}
