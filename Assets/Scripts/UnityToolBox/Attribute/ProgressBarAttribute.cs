using UnityEngine;

namespace UnityToolBox.CustomAttributes
{
    public class ProgressBarAttribute : PropertyAttribute
    {
        public bool hideWhenZero;
        public string label;
    }
}