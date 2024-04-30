using Petras.StringManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.StringManipulations
{
    [TestFixture]
    public class PermutationsTests
    {
        [Test]
        public void ArePermutations_tests()
        {
            // Arrange
            Permutations p = new Permutations();

            // Act

            // Assert
            Assert.IsTrue(p.ArePremutations("rte","ter"));
            Assert.IsTrue(p.ArePremutations("sss", "sss"));


            Assert.IsFalse(p.ArePremutations("rtee", "ters"));

        }

        [Test]
        public void IsPermutationPalindromes_test()
        {
            Palindromes p=new Palindromes();

            Assert.IsTrue(p.IsPermutationPalindromes("utt mnmn"));
        }
    }
}
