using System;
using UnityEngine;

namespace RectangleTrainer.TransformPastebin {
    public class TransformGrabber : MonoBehaviour
    {
        [SerializeField] private Pastebin pastebin;

        public Pastebin Pastebin => pastebin;
        public bool HasPastebin => pastebin != null;

        private static TransformGrabber instance;
        
        private void Awake() {
            if (instance && instance != this) {
                Destroy(this);
            }

            instance = this;
        }

        public static void InsertToPastebin(Transform transform, bool useLocal) {
            if (!Application.isPlaying) {
                Debug.LogWarning("You can use this only at runtime.");
                return;
            }
            if (instance == null) {
                Debug.LogWarning("There is no runtime instance of TransformGrabber. Assign it as a component to a scene object.");
                return;
            }
            
            if (!instance.HasPastebin) {
                Debug.LogWarning($"Transform Grabber doesn't have a Pastebin object. Create one from 'Create/Rectangle Trainer/Transform Pastebin' and assign it to {nameof(pastebin)}.");
                return;
            }
            
            PastebinEntry entry = new PastebinEntry();
            entry.Initialize(transform, useLocal);
                
            instance.pastebin.entries.Add(entry);
        }
    }
}
