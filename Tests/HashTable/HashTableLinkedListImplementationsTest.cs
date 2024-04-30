using NUnit.Framework.Internal;
using Petras.HashTable;
using Petras.StringManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.HashTable
{
    [TestFixture]
    public class HashTableLinkListImplementation_Generics_Tests
    {
        [Test]
        public void Add_2keys_ReturnsCorrectValue()
        {
            // Arrange
            HashTableLinkedListGenerics<string, string> hachTable = new HashTableLinkedListGenerics<string, string>(9);

            // Act
            hachTable.AddValue("test", "value test");
            hachTable.AddValue("test2", "value test2");

            // Assert
            Assert.AreEqual("value test", hachTable.GetValue("test"));

            Assert.AreEqual("value test2", hachTable.GetValue("test2"));
        }

        [Test]
        public void RemoveValue_GetException()
        {
            // Arrange
            HashTableLinkedListGenerics<string, string> hachTable = new HashTableLinkedListGenerics<string, string>(9);

            // Act
            hachTable.AddValue("test", "value test");

            Assert.Throws<KeyNotFoundException>(()=> hachTable.RemoveValue("test3"));
        }
    }
}
