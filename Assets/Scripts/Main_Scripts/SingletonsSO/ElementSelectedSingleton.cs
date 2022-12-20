using System;
using ElementSystem;
using UnityEngine;

namespace Main_Scripts.SingletonsSO {
    [CreateAssetMenu(fileName = "new Element Singleton", menuName = "Singletons/Element Selected")]
    public class ElementSelectedSingleton : ScriptableObject {
        public ElementSO Value;

        private void OnDisable() {
            Value = null;
        }
    }
}