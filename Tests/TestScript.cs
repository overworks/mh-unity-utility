using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Mh.Tests
{
    public class TestScript
    {
        [Test]
        public void Test_Vector2Rotate()
        {
            var v = Vector2.right;

            Assert.IsTrue(v.Rotate(90.0f) == Vector2.up);
            Assert.IsTrue(v.Rotate(-90.0f) == Vector2.down);
            Assert.IsTrue(v.Rotate(180.0f) == Vector2.left);
            Assert.IsTrue(v.Rotate(360.0f) == v);
        }

        [Test]
        public void Test_ObjectPool()
        {
            var pool = new ObjectPool<GameObject>(() => { return new GameObject(); });
            
            var obj1 = pool.Pop();
            pool.Push(obj1);
            var obj2 = pool.Pop();

            Assert.AreEqual(obj1, obj2);
        }
    }
}
