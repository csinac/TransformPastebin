using UnityEditor;
using UnityEngine;

namespace RectangleTrainer.TransformPastebin.Inspector
{
    [CustomEditor(typeof(Pastebin))]
    public class PastebinEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }
}