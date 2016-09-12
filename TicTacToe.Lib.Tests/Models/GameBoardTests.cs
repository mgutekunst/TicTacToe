using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TicTacToe.Lib.Models;
using Assert = NUnit.Framework.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace TicTacToe.Lib.Tests.Models
{
    [TestFixture]
    public class GameBoardTests
    {
        private GameBoard _cut;

        [SetUp]
        public void SetUp()
        {
            // Setup for Test
            _cut = new GameBoard();
        }

        [TearDown]
        public void TearDown()
        {
            _cut = null;
        }

        [Test]
        public void ctor_BoardCreatedWith3x3GameFields()
        {
            var po = new PrivateObject(_cut);
            var fields = po.GetField("_fields") as IList;
            Assert.That(fields.Count, Is.EqualTo(9));
        }

        [Test]
        public void Enumerate_AllFieldsAreGameFields()
        {
            CollectionAssert.AllItemsAreInstancesOfType(_cut, typeof(GameField));
        }

        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(1,0)]
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        public void Index_GetFieldAtPosition1x2_FieldIsReturned(int i, int j)
        {
            var field = _cut[i, j];

            Assert.That(field,Is.InstanceOf<GameField>());
        }

        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(1,0)]
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        public void Indices_GetFieldWithBothIndexMethods_EnsureThatFieldsAreTheSame(int x, int y)
        {
            var field1 = _cut[x, y];
            var field2 = _cut[x*3 + y];

            Assert.That(field1,Is.EqualTo(field2));
        }
    }
}