using System.Collections.Generic;
using UnityEngine;

namespace RectangleTrainer.TransformPastebin {
    [CreateAssetMenu(fileName = "Pastebin", menuName = "Rectangle Trainer/Transform Pastebin")]
    public class Pastebin : ScriptableObject
    {
        [SerializeField] internal List<PastebinEntry> entries = new List<PastebinEntry>();
    }
}