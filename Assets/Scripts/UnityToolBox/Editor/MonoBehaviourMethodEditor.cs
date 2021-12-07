using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CustomEditors
{
    [CustomEditor(typeof(Object), true, isFallback = true)]
    [CanEditMultipleObjects]
    public class MonoBehaviourMethodEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            //GUI.Button(new Rect(0, 0, 100, 100), "test");
            serializedObject.Update();
            serializedObject.ApplyModifiedProperties();
        }

        private void OnSceneGUI()
        {
            GUI.Button(new Rect(0, 0, 100, 100), "test");
        }
    }
}