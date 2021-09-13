using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RectangleTrainer.TransformPastebin.Inspector
{
    public class TransformMenuItem
    {
        [MenuItem ("CONTEXT/Transform/Insert to Pastebin (Local)")]
        private static void InsertAsLocal (MenuCommand command) {
            Transform transform = (Transform)command.context;
            InsertToPastebin(transform, true);
        }

        [MenuItem ("CONTEXT/Transform/Insert to Pastebin (Global)")]
        private static void InsertAsGlobal (MenuCommand command) {
            Transform transform = (Transform)command.context;
            InsertToPastebin(transform, false);
        }

        private static void InsertToPastebin(Transform transform, bool useLocal) {
            TransformGrabber.InsertToPastebin(transform, useLocal);
        }
    }
}
