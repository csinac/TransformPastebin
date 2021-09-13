using System;
using UnityEngine;

namespace RectangleTrainer.TransformPastebin
{
    [Serializable]
    public class PastebinEntry
    {
        private Transform toUnpack;
        [SerializeField] private bool isLocal;
        [SerializeField] private Vector3 position;
        [SerializeField] private Quaternion rotation;
        [SerializeField] private Vector3 scale;

        public bool IsLocal => isLocal;
        public Vector3 Position => position;
        public Quaternion Rotation => rotation;
        public Vector3 Scale => scale;

        public void Initialize(Transform toCopy, bool useLocal) {
            isLocal = useLocal;

            position = useLocal ? toCopy.localPosition : toCopy.position;
            rotation = useLocal ? toCopy.localRotation : toCopy.rotation;
            scale = useLocal ? toCopy.localScale : toCopy.lossyScale;
        }

        public void Unpack() {
            if (toUnpack == null) {
                Debug.LogWarning($"Assign a Transform component to the {nameof(toUnpack)} property as the recipient.");
            }
        }
    }
}