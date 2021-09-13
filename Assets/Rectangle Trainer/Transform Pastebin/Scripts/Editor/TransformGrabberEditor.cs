using System;
using UnityEditor;
using UnityEngine;

namespace RectangleTrainer.TransformPastebin.Inspector
{
    [CustomEditor(typeof(TransformGrabber))]
    public class TransformGrabberEditor : Editor
    {
        private TransformGrabber grabber;
        
        private void Awake() {
            grabber = target as TransformGrabber;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (grabber.HasPastebin) {
                Editor pasteBinEditor = CreateEditor(grabber.Pastebin);
                pasteBinEditor.OnInspectorGUI();
            }
            else {
                EditorGUILayout.HelpBox("To use this tool, create a pastebin object from 'Create/Rectangle Trainer/Transform Pastebin' and assign it to the pastebin field above.", MessageType.Warning);
            }
        }
    }
}
