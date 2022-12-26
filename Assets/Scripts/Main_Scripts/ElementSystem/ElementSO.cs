using Main_Scripts.Platform.PlatformBehaviours;
using UnityEngine;

namespace ElementSystem {
    public class ElementSO : ScriptableObject {
        public BaseBehaviourSO[] PlatformBehavioursArray;
        public Sprite platformSprite;
        
        public Sprite bulletSprite;
        public ElementSO opositeElement;
    }
}