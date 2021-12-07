// NOTE DONT put in an editor folder

using UnityEngine;
using System;

namespace UnityToolBox.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public class MethodButtonAttribute : PropertyAttribute
    {
        public bool isActiveAtRuntime = true;
        public bool isActiveInEditor = true;
        
        public MethodButtonAttribute(string name = "", int order = 1)
        {
            this.order = order;
        }
    }
}