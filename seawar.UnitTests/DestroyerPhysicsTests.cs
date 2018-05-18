﻿using System.Collections.Generic;
using NUnit.Framework;

namespace seawar.UnitTests {
   [TestFixture]
   public class DestroyerPhysicsTests {
      [Test]
      public void CanMoveToEmptySea() {
         var physics = new DestroyerPhysics();
         Assert.IsTrue(physics.TryMoveTo(new Tile(0, new List<Actor>())));
      }
      [Test]
      public void CannotMoveToLand() {
         var physics = new DestroyerPhysics();
         Assert.IsFalse(physics.TryMoveTo(new Tile(1, new List<Actor>())));
      }
   }
}