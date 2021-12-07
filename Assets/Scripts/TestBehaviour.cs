using System;
using UnityEngine;
using UnityToolBox.CustomAttributes;

namespace DefaultNamespace
{
    public class TestBehaviour : MonoBehaviour
    {
        [SortingLayer]
        [TestButton("TestButton", "TestButton")]
        public int test;

        [ContextMenu("TestButton")]
        public void TestButton()
        {
            Debug.Log("Test");
        }
    }
}