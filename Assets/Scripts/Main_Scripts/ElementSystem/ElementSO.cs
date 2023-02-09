using Main_Scripts.Platform.PlatformBehaviours;
using UnityEngine;
using UnityEditor.Animations;

namespace Main_Scripts.ElementSystem {
    public class ElementSO : ScriptableObject {
        public BaseBehaviourSO[] PlatformBehavioursArray;
        public Sprite platformInitialSprite;
        public Sprite bulletSprite;
        public ElementSO elementToLoseFor;
        public AnimatorController animatorController;
        public int elementSpawnIndex;
    }
}